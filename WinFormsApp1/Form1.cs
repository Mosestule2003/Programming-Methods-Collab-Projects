using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace WinFormsApp1
{
    // Case Report Form.
    // The form collects the data, Python (case_bridge.py and case_manager.py) saves it in the text file,
    // and Database.cs copies it into the MySQL database ed5.
    public partial class Form1 : Form
    {
        // path of the Python script, list of records, form controls, field names, id being edited
        string scriptPath = Path.Combine(AppContext.BaseDirectory, "case_bridge.py");
        List<string> records = new List<string>();
        Control[] boxes = new Control[0];
        string[] labels = new string[0];
        string editingId = "";
        bool pythonWorked = true;

        public Form1()
        {
            InitializeComponent();
        }

        // Runs when the window opens
        private void Form1_Load(object sender, EventArgs e)
        {
            // the university logo is a picture file next to the program
            picLogo.ImageLocation = Path.Combine(AppContext.BaseDirectory, "university_logo.png");

            // the order here is the column order in the text file
            boxes = new Control[]
            {
                txtStudentName, txtStudentNumber, txtStudentEmail, txtFacultyName, txtCaseDate, txtCourse,
                txtAssignment, txtDepartment, txtTerm, txtOsa, txtViolation, chkAdvised1, chkAdvised2,
                txtStep1Sig, txtStep1Name, txtStep1Date,
                txtStudentName2, rdoReviewedYes, txtMyTruEmail, txtStep2Sig, txtStep2Date,
                txtStep3Sig, txtStep3Name, txtStep3Date,
                rdoChairYes, txtChairExplain, txtChairComments, txtChairSig, txtChairName, txtChairDate,
                rdoDeanYes, txtDeanExplain, txtDeanComments, txtDeanSig, txtDeanName, txtDeanDate,
                txtFacultyComments, txtStudentComments
            };
            labels = new string[]
            {
                "Student Name", "Student Number", "Student Email", "Faculty Member Name", "Date (Step 1)", "Course Name and Number",
                "Assignment Number or Exam", "Department", "Term or Semester", "OSA use only", "Description of Violation",
                "Student advised: may bring a support person", "Student advised: may submit a written statement",
                "Faculty Signature (Step 1)", "Faculty Name (Step 1)", "Signature Date (Step 1)",
                "Student Name (Step 2)", "Student reviewed the form and evidence", "MyTRU email", "Student Signature", "Date (Step 2)",
                "Faculty Signature (Step 3)", "Faculty Name (Step 3)", "Date (Step 3)",
                "Chair agrees with the case", "Chair: explanation of 'No'", "Chair Comments", "Chair Signature", "Chair Name", "Date (Step 4)",
                "Dean agrees with the case", "Dean: explanation of 'No'", "Dean Comments", "Dean Signature", "Dean Name", "Date (Step 5)",
                "Faculty Member Comments (Page 4)", "Student Comments (Page 5)"
            };

            cmbSearchBy.SelectedIndex = 0;
            ClearForm();
            LoadRecords();
            ShowRecords(records);
        }

        // ---------- Button clicks ----------

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecords();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearchBy.SelectedIndex = 0;
            ShowRecords(records);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        // Pressing Enter in the search box runs the search
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchRecords();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e)
        {
            ShowDetails();
        }

        // Double-clicking a record opens it for editing
        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ModifyRecord();
            }
        }

        // ---------- Save, search, modify, delete ----------

        // Add a new record, or update the one being edited
        private void SaveRecord()
        {
            if (ValidateForm() == false)
            {
                return;
            }

            // 1. save in the text file (Python)
            string values = BuildValues();
            string id = "";
            if (editingId == "")
            {
                id = RunPython("add", values).Trim();
            }
            else
            {
                id = RunPython("update " + editingId, values).Trim();
            }
            if (pythonWorked == false)
            {
                return;
            }

            // 2. save in the database
            string dbError = Database.SaveRecord(id + "|" + values);
            if (dbError == "")
            {
                MessageBox.Show("Record " + id + " was saved (text file and database).", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record " + id + " was saved in the text file, but NOT in the database:\n\n" + dbError,
                    "Database problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblStatus.Text = "Saved record " + id + ".";
            LoadRecords();
            ClearForm();
            ShowRecords(records);
        }

        // Show the records that match the search text
        private void SearchRecords()
        {
            string output = RunPython("search " + cmbSearchBy.SelectedIndex + " \"" + txtSearch.Text.Trim().Replace("\"", "") + "\"", "");
            if (pythonWorked == false)
            {
                return;
            }

            List<string> found = ToRecords(output);
            ShowRecords(found);
            if (found.Count == 0)
            {
                MessageBox.Show("No records match your search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Copy the selected record back into the form so it can be edited
        private void ModifyRecord()
        {
            string line = GetSelectedLine();
            if (line == "")
            {
                MessageBox.Show("Select a record in the list first.", "Modify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] parts = line.Split('|');
            for (int i = 0; i < boxes.Length; i++)
            {
                string value = "";
                if (i + 1 < parts.Length)
                {
                    value = parts[i + 1];
                }
                SetValue(boxes[i], value.Replace("<br>", Environment.NewLine));
            }

            editingId = parts[0];
            btnSave.Text = "Update Record";
            lblMode.Text = "Editing " + editingId;
            pnlForm.AutoScrollPosition = new Point(0, 0);
        }

        // Delete the selected record after asking
        private void DeleteRecord()
        {
            string line = GetSelectedLine();
            if (line == "")
            {
                MessageBox.Show("Select a record in the list first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] parts = line.Split('|');
            DialogResult answer = MessageBox.Show("Delete record " + parts[0] + " (" + parts[1] + ")? This cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            // 1. delete from the text file (Python)
            RunPython("delete " + parts[0], "");
            if (pythonWorked == false)
            {
                return;
            }

            // 2. delete from the database
            string dbError = Database.DeleteRecord(parts[0]);
            if (dbError == "")
            {
                MessageBox.Show("Record " + parts[0] + " was deleted (text file and database).", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record " + parts[0] + " was deleted from the text file, but NOT from the database:\n\n" + dbError,
                    "Database problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (editingId == parts[0])
            {
                ClearForm();
            }
            lblStatus.Text = "Deleted record " + parts[0] + ".";
            LoadRecords();
            ShowRecords(records);
        }

        // ---------- Python ----------

        // Run case_bridge.py with a command like "add" or "delete CR-1".
        // "input" is sent to Python as text. Returns what Python prints.
        // If something goes wrong a message is shown and pythonWorked becomes false.
        private string RunPython(string command, string input)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c py \"" + scriptPath + "\" " + command;
            info.WorkingDirectory = AppContext.BaseDirectory;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.StandardInputEncoding = new UTF8Encoding(false);
            info.StandardOutputEncoding = Encoding.UTF8;
            info.StandardErrorEncoding = Encoding.UTF8;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = info;
            process.Start();
            process.StandardInput.Write(input);
            process.StandardInput.Close();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            pythonWorked = (process.ExitCode == 0);
            if (pythonWorked == false)
            {
                if (error.Contains("not recognized"))
                {
                    error = "Python was not found. Install Python 3 and make sure the 'py' command works.";
                }
                MessageBox.Show(error.Trim(), "Python error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }

        // Get all records from Python
        private void LoadRecords()
        {
            string output = RunPython("list", "");
            records = ToRecords(output);
        }

        // Split the text printed by Python into one record per line
        private List<string> ToRecords(string output)
        {
            List<string> list = new List<string>();
            foreach (string line in output.Split('\n'))
            {
                if (line.Trim() != "" && line.Split('|').Length >= 7)
                {
                    list.Add(line.Trim());
                }
            }
            return list;
        }

        // ---------- Showing records ----------

        // Show a list of records in the grid
        private void ShowRecords(List<string> list)
        {
            dgvRecords.Rows.Clear();
            foreach (string line in list)
            {
                string[] parts = line.Split('|');
                dgvRecords.Rows.Add(parts[0], parts[1], parts[2], parts[4], parts[6], parts[5]);
            }
            ShowDetails();
            lblStatus.Text = list.Count + " record(s) shown.";
        }

        // Show every filled-in field of the selected record
        private void ShowDetails()
        {
            string line = GetSelectedLine();
            if (line == "")
            {
                txtDetails.Text = "Select a record in the list to see its details here.";
                return;
            }

            string[] parts = line.Split('|');
            string text = "Record " + parts[0] + Environment.NewLine + Environment.NewLine;
            for (int i = 0; i < labels.Length && i + 1 < parts.Length; i++)
            {
                if (parts[i + 1] != "")
                {
                    text = text + labels[i] + ": " + parts[i + 1].Replace("<br>", Environment.NewLine) + Environment.NewLine;
                }
            }
            txtDetails.Text = text;
        }

        // Return the selected record line ("" if nothing is selected)
        private string GetSelectedLine()
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                return "";
            }
            string id = Convert.ToString(dgvRecords.SelectedRows[0].Cells[0].Value) ?? "";
            foreach (string line in records)
            {
                if (line.Split('|')[0] == id)
                {
                    return line;
                }
            }
            return "";
        }

        // ---------- Form values ----------

        // Join all the form values into one "|" separated line
        private string BuildValues()
        {
            string line = "";
            for (int i = 0; i < boxes.Length; i++)
            {
                if (i > 0)
                {
                    line = line + "|";
                }
                string value = GetValue(boxes[i]);
                value = value.Replace("|", "/").Replace("\r\n", "<br>").Replace("\n", "<br>");
                line = line + value;
            }
            return line;
        }

        // Reset the form to a new empty record
        private void ClearForm()
        {
            foreach (Control box in boxes)
            {
                SetValue(box, "");
            }
            editingId = "";
            btnSave.Text = "Save New Record";
            lblMode.Text = "New record  (* = required)";
            pnlForm.AutoScrollPosition = new Point(0, 0);
        }

        // Each "Yes" radio button has a "No" button next to it
        private RadioButton GetNoButton(RadioButton yesButton)
        {
            if (yesButton == rdoReviewedYes)
            {
                return rdoReviewedNo;
            }
            if (yesButton == rdoChairYes)
            {
                return rdoChairNo;
            }
            return rdoDeanNo;
        }

        // Read a control as text
        private string GetValue(Control box)
        {
            if (box is CheckBox)
            {
                CheckBox checkBox = (CheckBox)box;
                if (checkBox.Checked)
                {
                    return "Yes";
                }
                return "No";
            }
            if (box is RadioButton)
            {
                RadioButton yesButton = (RadioButton)box;
                RadioButton noButton = GetNoButton(yesButton);
                if (yesButton.Checked)
                {
                    return "Yes";
                }
                if (noButton.Checked)
                {
                    return "No";
                }
                return "";
            }
            return box.Text.Trim();
        }

        // Put text into a control
        private void SetValue(Control box, string value)
        {
            if (box is CheckBox)
            {
                CheckBox checkBox = (CheckBox)box;
                checkBox.Checked = (value == "Yes");
            }
            else if (box is RadioButton)
            {
                RadioButton yesButton = (RadioButton)box;
                RadioButton noButton = GetNoButton(yesButton);
                yesButton.Checked = (value == "Yes");
                noButton.Checked = (value == "No");
            }
            else
            {
                box.Text = value;
            }
        }

        // ---------- Checking the form ----------

        // Returns true if everything is filled in correctly
        private bool ValidateForm()
        {
            Control[] required = { txtStudentName, txtStudentNumber, txtStudentEmail, txtFacultyName, txtCaseDate,
                                   txtCourse, txtAssignment, txtDepartment, txtTerm, txtViolation };
            Control[] dates = { txtCaseDate, txtStep1Date, txtStep2Date, txtStep3Date, txtChairDate, txtDeanDate };
            Control[] emails = { txtStudentEmail, txtMyTruEmail };

            // these boxes go into database columns, so they cannot be longer than the column
            Control[] limited = { txtStudentName, txtStudentNumber, txtStudentEmail, txtFacultyName,
                                  txtDepartment, txtTerm, txtAssignment, txtChairName, txtDeanName };
            int[] maxLengths = { 50, 10, 25, 50, 35, 30, 30, 50, 50 };

            foreach (Control box in required)
            {
                if (box.Text.Trim() == "")
                {
                    return Complain(box, "is required.");
                }
            }

            for (int i = 0; i < limited.Length; i++)
            {
                if (limited[i].Text.Trim().Length > maxLengths[i])
                {
                    return Complain(limited[i], "is too long (at most " + maxLengths[i] + " characters).");
                }
            }

            foreach (Control box in dates)
            {
                DateTime date;
                bool isDate = DateTime.TryParseExact(box.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
                if (box.Text.Trim() != "" && isDate == false)
                {
                    return Complain(box, "must be a real date written as yyyy-mm-dd.");
                }
            }

            foreach (Control box in emails)
            {
                string mail = box.Text.Trim();
                if (mail != "" && (mail.Contains("@") == false || mail.Contains(".") == false || mail.Contains(" ")))
                {
                    return Complain(box, "is not a valid email address.");
                }
            }

            if (rdoChairNo.Checked && txtChairExplain.Text.Trim() == "")
            {
                return Complain(txtChairExplain, "is required when the Chair answers 'No'.");
            }
            if (rdoDeanNo.Checked && txtDeanExplain.Text.Trim() == "")
            {
                return Complain(txtDeanExplain, "is required when the Dean answers 'No'.");
            }
            return true;
        }

        // Show a warning and move to the bad field. Always returns false.
        private bool Complain(Control box, string problem)
        {
            string name = box.Name;
            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i] == box)
                {
                    name = labels[i];
                }
            }
            MessageBox.Show("'" + name + "' " + problem, "Please fix this field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pnlForm.ScrollControlIntoView(box);
            box.Focus();
            return false;
        }
    }
}
