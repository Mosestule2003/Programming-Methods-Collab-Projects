using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace WinFormsApp1
{
    // Case Report Form: the form collects the data and Python (case_manager.py) stores it
    public partial class Form1 : Form
    {
        // path of the Python script, list of records, form controls, field names, id being edited
        string scriptPath = Path.Combine(AppContext.BaseDirectory, "case_manager.py");
        List<string> records = new List<string>();
        Control[] boxes = new Control[0];
        string[] labels = new string[0];
        string editingId = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Runs when the window opens
        private void Form1_Load(object sender, EventArgs e)
        {
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

        // Button clicks
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

        // Grid events
        private void dgvRecords_SelectionChanged(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ModifyRecord();
            }
        }

        // Add a new record or update the one being edited
        private void SaveRecord()
        {
            if (!ValidateForm())
            {
                return;
            }

            string values = BuildValues();
            string result;
            if (editingId == "")
            {
                result = RunPython(new string[] { "add" }, values);
            }
            else
            {
                result = RunPython(new string[] { "update", editingId }, values);
            }
            if (result == null)
            {
                return;
            }

            string id = result.Trim();
            lblStatus.Text = (editingId == "" ? "Saved new record " : "Updated record ") + id + ".";
            MessageBox.Show("Record " + id + (editingId == "" ? " was saved." : " was updated."),
                editingId == "" ? "Saved" : "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadRecords();
            ClearForm();
            ShowRecords(records);
        }

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
                // "|" would break the format and line breaks would split the record
                line = line + GetValue(boxes[i]).Replace("|", "/").Replace("\r\n", "<br>").Replace("\n", "<br>");
            }
            return line;
        }

        // Run case_manager.py with the given arguments and return what it prints (null on error)
        private string RunPython(string[] arguments, string input)
        {
            // try "python" first, then "py"
            string[] programs = { "python", "py" };
            string problem = "";

            foreach (string program in programs)
            {
                ProcessStartInfo info = new ProcessStartInfo(program);
                info.ArgumentList.Add(scriptPath);
                foreach (string argument in arguments)
                {
                    info.ArgumentList.Add(argument);
                }
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.RedirectStandardError = true;
                info.StandardInputEncoding = new UTF8Encoding(false);
                info.StandardOutputEncoding = Encoding.UTF8;
                info.StandardErrorEncoding = Encoding.UTF8;
                info.UseShellExecute = false;
                info.CreateNoWindow = true;

                try
                {
                    using (Process process = Process.Start(info)!)
                    {
                        process.StandardInput.Write(input);
                        process.StandardInput.Close();
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        if (process.ExitCode == 0)
                        {
                            return output;
                        }
                        problem = error.Trim();
                        if (!error.Contains("Python was not found"))
                        {
                            break;
                        }
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                }
            }

            if (problem == "")
            {
                problem = "Python was not found. Install Python 3 and make sure the 'python' command works.";
            }
            MessageBox.Show(problem, "Python error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null!;
        }

        // Split Python output into records, one per line
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

        // Get all records from Python
        private void LoadRecords()
        {
            string output = RunPython(new string[] { "list" }, "");
            records = output == null ? new List<string>() : ToRecords(output);
        }

        // Search records by the chosen column
        private void SearchRecords()
        {
            string output = RunPython(new string[] { "search", cmbSearchBy.Text, txtSearch.Text.Trim() }, "");
            if (output == null)
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

        // Show all fields of the selected record
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

        // Return the selected record line ("" if none)
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

        // Copy the selected record back into the form for editing
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
                string value = i + 1 < parts.Length ? parts[i + 1] : "";
                SetValue(boxes[i], value.Replace("<br>", Environment.NewLine));
            }

            editingId = parts[0];
            btnSave.Text = "Update Record";
            lblMode.Text = "Editing " + editingId;
            pnlForm.AutoScrollPosition = new Point(0, 0);
        }

        // Delete the selected record after confirming
        private void DeleteRecord()
        {
            string line = GetSelectedLine();
            if (line == "")
            {
                MessageBox.Show("Select a record in the list first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] parts = line.Split('|');
            DialogResult result = MessageBox.Show("Delete record " + parts[0] + " (" + parts[1] + ")? This cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            if (RunPython(new string[] { "delete", parts[0] }, "") == null)
            {
                return;
            }
            LoadRecords();

            if (editingId == parts[0])
            {
                ClearForm();
            }
            ShowRecords(records);
            lblStatus.Text = "Deleted record " + parts[0] + ".";
            MessageBox.Show("Record " + parts[0] + " was deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Read a control as text
        private string GetValue(Control box)
        {
            if (box is CheckBox)
            {
                return ((CheckBox)box).Checked ? "Yes" : "No";
            }
            if (box is RadioButton)
            {
                RadioButton noButton = (RadioButton)box.Parent!.Controls[box.Name.Replace("Yes", "No")]!;
                if (((RadioButton)box).Checked) return "Yes";
                if (noButton.Checked) return "No";
                return "";
            }
            return box.Text.Trim();
        }

        // Put text into a control
        private void SetValue(Control box, string value)
        {
            if (box is CheckBox)
            {
                ((CheckBox)box).Checked = (value == "Yes");
            }
            else if (box is RadioButton)
            {
                RadioButton noButton = (RadioButton)box.Parent!.Controls[box.Name.Replace("Yes", "No")]!;
                ((RadioButton)box).Checked = (value == "Yes");
                noButton.Checked = (value == "No");
            }
            else
            {
                box.Text = value;
            }
        }

        // Check required fields, dates, emails and Yes/No explanations
        private bool ValidateForm()
        {
            Control[] required = { txtStudentName, txtStudentNumber, txtStudentEmail, txtFacultyName, txtCaseDate,
                                   txtCourse, txtAssignment, txtDepartment, txtTerm, txtViolation };
            Control[] dates = { txtCaseDate, txtStep1Date, txtStep2Date, txtStep3Date, txtChairDate, txtDeanDate };
            Control[] emails = { txtStudentEmail, txtMyTruEmail };

            foreach (Control box in required)
            {
                if (box.Text.Trim() == "")
                {
                    return Complain(box, "is required.");
                }
            }
            foreach (Control box in dates)
            {
                DateTime when;
                if (box.Text.Trim() != "" && !DateTime.TryParseExact(box.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out when))
                {
                    return Complain(box, "must be a real date written as yyyy-mm-dd.");
                }
            }
            foreach (Control box in emails)
            {
                string mail = box.Text.Trim();
                if (mail != "" && (!mail.Contains("@") || !mail.Contains(".") || mail.Contains(" ")))
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

        // Show a warning and move to the bad field
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
