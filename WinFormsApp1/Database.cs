using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using MySqlConnector;

namespace WinFormsApp1
{
    // puts the saved records in MySQL (database ed5: users, ed_case_info, ed_case_comments)
    internal static class Database
    {
        const string connectionString = "Server=localhost;Port=3306;Database=ed5;User ID=root;Password=;";

        // field i of the record line (0 = Student Name, 1 = Student Number, ...)
        // <br> goes back to a real line break
        static string Get(string[] parts, int i)
        {
            if (i + 1 < parts.Length)
            {
                return parts[i + 1].Replace("<br>", Environment.NewLine);
            }
            return "";
        }

        // empty text becomes NULL
        static object OrNull(string text)
        {
            if (text == "")
            {
                return DBNull.Value;
            }
            return text;
        }

        // checks if MySQL is up (port 3306 is open)
        static bool MySqlIsRunning()
        {
            IPEndPoint[] listeners = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners();
            foreach (IPEndPoint listener in listeners)
            {
                if (listener.Port == 3306)
                {
                    return true;
                }
            }
            return false;
        }

        // insert or update a case, returns "" if ok, otherwise the problem
        public static string SaveRecord(string line)
        {
            if (MySqlIsRunning() == false)
            {
                return "MySQL is not running. Start MySQL in the XAMPP Control Panel.";
            }

            string[] parts = line.Split('|');
            string caseId = parts[0];
            string studentNumber = Get(parts, 1);
            string department = Get(parts, 7);

            DateTime violationDate;
            bool dateIsGood = DateTime.TryParseExact(Get(parts, 4), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out violationDate);
            if (dateIsGood == false)
            {
                return "The date is not written as yyyy-mm-dd.";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    // people first (users table)
                    SaveStudent(connection, transaction, studentNumber, Get(parts, 0), Get(parts, 2), department);
                    string facultyId = FindOrAddUser(connection, transaction, Get(parts, 3), "faculty", "F", department);
                    string chairId = FindOrAddUser(connection, transaction, Get(parts, 28), "chair", "C", department);
                    string deanId = FindOrAddUser(connection, transaction, Get(parts, 34), "dean", "D", department);

                    // the case (insert, or update if the id exists)
                    MySqlCommand info = new MySqlCommand(
                        "INSERT INTO ed_case_info (case_id, student_id, faculty_id, chair_id, dean_id, Term, Assignment_number, ed_violation_description, violation_date) " +
                        "VALUES (@case, @student, @faculty, @chair, @dean, @term, @assignment, @description, @date) " +
                        "ON DUPLICATE KEY UPDATE student_id = @student, faculty_id = @faculty, chair_id = @chair, dean_id = @dean, " +
                        "Term = @term, Assignment_number = @assignment, ed_violation_description = @description, violation_date = @date",
                        connection, transaction);
                    info.Parameters.AddWithValue("@case", caseId);
                    info.Parameters.AddWithValue("@student", studentNumber);
                    info.Parameters.AddWithValue("@faculty", facultyId);
                    info.Parameters.AddWithValue("@chair", OrNull(chairId));
                    info.Parameters.AddWithValue("@dean", OrNull(deanId));
                    info.Parameters.AddWithValue("@term", Get(parts, 8));
                    info.Parameters.AddWithValue("@assignment", Get(parts, 6));
                    info.Parameters.AddWithValue("@description", Get(parts, 10));
                    info.Parameters.AddWithValue("@date", violationDate);
                    info.ExecuteNonQuery();

                    // comments
                    MySqlCommand comments = new MySqlCommand(
                        "INSERT INTO ed_case_comments (case_id, chair_comments, dean_comments, faculty_comments, student_comments) " +
                        "VALUES (@case, @chair, @dean, @faculty, @student) " +
                        "ON DUPLICATE KEY UPDATE chair_comments = @chair, dean_comments = @dean, faculty_comments = @faculty, student_comments = @student",
                        connection, transaction);
                    comments.Parameters.AddWithValue("@case", caseId);
                    comments.Parameters.AddWithValue("@chair", OrNull(Get(parts, 26)));
                    comments.Parameters.AddWithValue("@dean", OrNull(Get(parts, 32)));
                    comments.Parameters.AddWithValue("@faculty", OrNull(Get(parts, 36)));
                    comments.Parameters.AddWithValue("@student", OrNull(Get(parts, 37)));
                    comments.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
            return "";
        }

        // delete a case, its comments go with it (cascade)
        public static string DeleteRecord(string caseId)
        {
            if (MySqlIsRunning() == false)
            {
                return "MySQL is not running. Start MySQL in the XAMPP Control Panel.";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand delete = new MySqlCommand("DELETE FROM ed_case_info WHERE case_id = @case", connection);
                delete.Parameters.AddWithValue("@case", caseId);
                delete.ExecuteNonQuery();
            }
            return "";
        }

        // student user_id = student number
        static void SaveStudent(MySqlConnection connection, MySqlTransaction transaction, string studentNumber, string name, string email, string department)
        {
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO users (user_id, name, email, department, user_type) VALUES (@id, @name, @email, @department, 'student') " +
                "ON DUPLICATE KEY UPDATE name = @name, email = @email, department = @department",
                connection, transaction);
            command.Parameters.AddWithValue("@id", studentNumber);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", OrNull(email));
            command.Parameters.AddWithValue("@department", OrNull(department));
            command.ExecuteNonQuery();
        }

        // faculty, chair and dean have no number on the form, so make ids F001, C001, D001
        // "" if the name is empty
        static string FindOrAddUser(MySqlConnection connection, MySqlTransaction transaction, string name, string userType, string prefix, string department)
        {
            if (name == "")
            {
                return "";
            }

            // already in the table?
            MySqlCommand find = new MySqlCommand("SELECT user_id FROM users WHERE name = @name AND user_type = @type LIMIT 1", connection, transaction);
            find.Parameters.AddWithValue("@name", name);
            find.Parameters.AddWithValue("@type", userType);
            string oldId = Convert.ToString(find.ExecuteScalar());
            if (oldId != "")
            {
                return oldId;
            }

            // new person: biggest number so far + 1
            int biggest = 0;
            MySqlCommand all = new MySqlCommand("SELECT user_id FROM users WHERE user_type = @type", connection, transaction);
            all.Parameters.AddWithValue("@type", userType);
            using (MySqlDataReader reader = all.ExecuteReader())
            {
                while (reader.Read())
                {
                    int number;
                    bool isNumber = int.TryParse(reader.GetString(0).Substring(1), out number);
                    if (isNumber && number > biggest)
                    {
                        biggest = number;
                    }
                }
            }
            string newId = prefix + (biggest + 1).ToString("D3");

            MySqlCommand insert = new MySqlCommand(
                "INSERT INTO users (user_id, name, email, department, user_type) VALUES (@id, @name, NULL, @department, @type)",
                connection, transaction);
            insert.Parameters.AddWithValue("@id", newId);
            insert.Parameters.AddWithValue("@name", name);
            insert.Parameters.AddWithValue("@department", OrNull(department));
            insert.Parameters.AddWithValue("@type", userType);
            insert.ExecuteNonQuery();
            return newId;
        }
    }
}
