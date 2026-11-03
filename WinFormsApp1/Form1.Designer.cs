namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlForm = new Panel();
            picLogo = new PictureBox();
            lblPolicy = new Label();
            lblFormTitle = new Label();
            lblOsa = new Label();
            txtOsa = new TextBox();
            lblAddress = new Label();
            lblIntro = new Label();
            grpStep1 = new GroupBox();
            lblStep1Instr = new Label();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblStudentNumber = new Label();
            txtStudentNumber = new TextBox();
            lblStudentEmail = new Label();
            txtStudentEmail = new TextBox();
            lblFacultyName = new Label();
            txtFacultyName = new TextBox();
            lblCaseDate = new Label();
            txtCaseDate = new TextBox();
            lblCourse = new Label();
            txtCourse = new TextBox();
            lblAssignment = new Label();
            txtAssignment = new TextBox();
            lblDepartment = new Label();
            txtDepartment = new TextBox();
            lblTerm = new Label();
            txtTerm = new TextBox();
            lblViolation = new Label();
            txtViolation = new TextBox();
            lblSanctions = new Label();
            lblAdvise = new Label();
            chkAdvised1 = new CheckBox();
            chkAdvised2 = new CheckBox();
            lblStep1Sig = new Label();
            txtStep1Sig = new TextBox();
            lblStep1Name = new Label();
            txtStep1Name = new TextBox();
            lblStep1Date = new Label();
            txtStep1Date = new TextBox();
            grpStep2 = new GroupBox();
            lblStep2Instr = new Label();
            lblStudentName2 = new Label();
            txtStudentName2 = new TextBox();
            lblStep2Statement = new Label();
            lblReviewed = new Label();
            rdoReviewedYes = new RadioButton();
            rdoReviewedNo = new RadioButton();
            lblFurther = new Label();
            lblMyTruEmail = new Label();
            txtMyTruEmail = new TextBox();
            lblCopyNote = new Label();
            lblStep2Sig = new Label();
            txtStep2Sig = new TextBox();
            lblStep2Date = new Label();
            txtStep2Date = new TextBox();
            lblMyTruNote = new Label();
            grpStep3 = new GroupBox();
            lblStep3Instr = new Label();
            lblStep3Sig = new Label();
            txtStep3Sig = new TextBox();
            lblStep3Name = new Label();
            txtStep3Name = new TextBox();
            lblStep3Date = new Label();
            txtStep3Date = new TextBox();
            grpStep4 = new GroupBox();
            lblStep4Instr = new Label();
            lblChairAgree = new Label();
            rdoChairYes = new RadioButton();
            rdoChairNo = new RadioButton();
            lblChairExplain = new Label();
            txtChairExplain = new TextBox();
            lblChairComments = new Label();
            txtChairComments = new TextBox();
            lblChairSig = new Label();
            txtChairSig = new TextBox();
            lblChairName = new Label();
            txtChairName = new TextBox();
            lblChairDate = new Label();
            txtChairDate = new TextBox();
            grpStep5 = new GroupBox();
            lblStep5Instr = new Label();
            lblDeanAgree = new Label();
            rdoDeanYes = new RadioButton();
            rdoDeanNo = new RadioButton();
            lblDeanExplain = new Label();
            txtDeanExplain = new TextBox();
            lblDeanComments = new Label();
            txtDeanComments = new TextBox();
            lblDeanSig = new Label();
            txtDeanSig = new TextBox();
            lblDeanName = new Label();
            txtDeanName = new TextBox();
            lblDeanDate = new Label();
            txtDeanDate = new TextBox();
            grpComments = new GroupBox();
            lblFacultyComments = new Label();
            txtFacultyComments = new TextBox();
            lblStudentComments = new Label();
            txtStudentComments = new TextBox();
            grpSearch = new GroupBox();
            lblSearchBy = new Label();
            cmbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgvRecords = new DataGridView();
            colRecordId = new DataGridViewTextBoxColumn();
            colStudent = new DataGridViewTextBoxColumn();
            colNumber = new DataGridViewTextBoxColumn();
            colFaculty = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            grpDetails = new GroupBox();
            txtDetails = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            lblMode = new Label();
            lblStatus = new Label();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpStep1.SuspendLayout();
            grpStep2.SuspendLayout();
            grpStep3.SuspendLayout();
            grpStep4.SuspendLayout();
            grpStep5.SuspendLayout();
            grpComments.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            grpDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(picLogo);
            pnlForm.Controls.Add(lblPolicy);
            pnlForm.Controls.Add(lblFormTitle);
            pnlForm.Controls.Add(lblOsa);
            pnlForm.Controls.Add(txtOsa);
            pnlForm.Controls.Add(lblAddress);
            pnlForm.Controls.Add(lblIntro);
            pnlForm.Controls.Add(grpStep1);
            pnlForm.Controls.Add(grpStep2);
            pnlForm.Controls.Add(grpStep3);
            pnlForm.Controls.Add(grpStep4);
            pnlForm.Controls.Add(grpStep5);
            pnlForm.Controls.Add(grpComments);
            pnlForm.Location = new Point(9, 11);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(992, 1045);
            pnlForm.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = SystemColors.ControlLight;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(9, 11);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(171, 85);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblPolicy
            // 
            lblPolicy.AutoSize = true;
            lblPolicy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPolicy.Location = new Point(194, 13);
            lblPolicy.Name = "lblPolicy";
            lblPolicy.Size = new Size(275, 20);
            lblPolicy.TabIndex = 1;
            lblPolicy.Text = "ACADEMIC INTEGRITY POLICY ED 5-0";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFormTitle.Location = new Point(194, 40);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(405, 30);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "Case Report Form: On Campus Course";
            // 
            // lblOsa
            // 
            lblOsa.AutoSize = true;
            lblOsa.Location = new Point(640, 11);
            lblOsa.Name = "lblOsa";
            lblOsa.Size = new Size(208, 20);
            lblOsa.TabIndex = 3;
            lblOsa.Text = "This space is for OSA use only.";
            // 
            // txtOsa
            // 
            txtOsa.Location = new Point(640, 35);
            txtOsa.Margin = new Padding(3, 4, 3, 4);
            txtOsa.Name = "txtOsa";
            txtOsa.Size = new Size(299, 27);
            txtOsa.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(640, 72);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(299, 53);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "805 TRU Way, Kamloops, BC, Canada V2C 0C8\r\ntru.ca/aic";
            // 
            // lblIntro
            // 
            lblIntro.Location = new Point(9, 104);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(617, 43);
            lblIntro.TabIndex = 6;
            lblIntro.Text = "This form can be completed by using a printed copy, or using the latest version of Adobe Reader or Adobe Acrobat electronically.";
            // 
            // grpStep1
            // 
            grpStep1.Controls.Add(lblStep1Instr);
            grpStep1.Controls.Add(lblStudentName);
            grpStep1.Controls.Add(txtStudentName);
            grpStep1.Controls.Add(lblStudentNumber);
            grpStep1.Controls.Add(txtStudentNumber);
            grpStep1.Controls.Add(lblStudentEmail);
            grpStep1.Controls.Add(txtStudentEmail);
            grpStep1.Controls.Add(lblFacultyName);
            grpStep1.Controls.Add(txtFacultyName);
            grpStep1.Controls.Add(lblCaseDate);
            grpStep1.Controls.Add(txtCaseDate);
            grpStep1.Controls.Add(lblCourse);
            grpStep1.Controls.Add(txtCourse);
            grpStep1.Controls.Add(lblAssignment);
            grpStep1.Controls.Add(txtAssignment);
            grpStep1.Controls.Add(lblDepartment);
            grpStep1.Controls.Add(txtDepartment);
            grpStep1.Controls.Add(lblTerm);
            grpStep1.Controls.Add(txtTerm);
            grpStep1.Controls.Add(lblViolation);
            grpStep1.Controls.Add(txtViolation);
            grpStep1.Controls.Add(lblSanctions);
            grpStep1.Controls.Add(lblAdvise);
            grpStep1.Controls.Add(chkAdvised1);
            grpStep1.Controls.Add(chkAdvised2);
            grpStep1.Controls.Add(lblStep1Sig);
            grpStep1.Controls.Add(txtStep1Sig);
            grpStep1.Controls.Add(lblStep1Name);
            grpStep1.Controls.Add(txtStep1Name);
            grpStep1.Controls.Add(lblStep1Date);
            grpStep1.Controls.Add(txtStep1Date);
            grpStep1.Location = new Point(9, 149);
            grpStep1.Margin = new Padding(3, 4, 3, 4);
            grpStep1.Name = "grpStep1";
            grpStep1.Padding = new Padding(3, 4, 3, 4);
            grpStep1.Size = new Size(939, 981);
            grpStep1.TabIndex = 7;
            grpStep1.TabStop = false;
            grpStep1.Text = "Step One - To be completed by Faculty Member";
            // 
            // lblStep1Instr
            // 
            lblStep1Instr.Location = new Point(11, 29);
            lblStep1Instr.Name = "lblStep1Instr";
            lblStep1Instr.Size = new Size(914, 232);
            lblStep1Instr.TabIndex = 0;
            lblStep1Instr.Text = resources.GetString("lblStep1Instr.Text");
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(11, 272);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(114, 20);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name *";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(11, 296);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(297, 27);
            txtStudentName.TabIndex = 2;
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.Location = new Point(320, 272);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new Size(128, 20);
            lblStudentNumber.TabIndex = 3;
            lblStudentNumber.Text = "Student Number *";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(320, 296);
            txtStudentNumber.Margin = new Padding(3, 4, 3, 4);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(251, 27);
            txtStudentNumber.TabIndex = 4;
            // 
            // lblStudentEmail
            // 
            lblStudentEmail.AutoSize = true;
            lblStudentEmail.Location = new Point(583, 272);
            lblStudentEmail.Name = "lblStudentEmail";
            lblStudentEmail.Size = new Size(111, 20);
            lblStudentEmail.TabIndex = 5;
            lblStudentEmail.Text = "Student Email *";
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(583, 296);
            txtStudentEmail.Margin = new Padding(3, 4, 3, 4);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(342, 27);
            txtStudentEmail.TabIndex = 6;
            // 
            // lblFacultyName
            // 
            lblFacultyName.AutoSize = true;
            lblFacultyName.Location = new Point(11, 347);
            lblFacultyName.Name = "lblFacultyName";
            lblFacultyName.Size = new Size(168, 20);
            lblFacultyName.TabIndex = 7;
            lblFacultyName.Text = "Faculty Member Name *";
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(11, 371);
            txtFacultyName.Margin = new Padding(3, 4, 3, 4);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(297, 27);
            txtFacultyName.TabIndex = 8;
            // 
            // lblCaseDate
            // 
            lblCaseDate.AutoSize = true;
            lblCaseDate.Location = new Point(320, 347);
            lblCaseDate.Name = "lblCaseDate";
            lblCaseDate.Size = new Size(149, 20);
            lblCaseDate.TabIndex = 9;
            lblCaseDate.Text = "Date (yyyy-mm-dd) *";
            // 
            // txtCaseDate
            // 
            txtCaseDate.Location = new Point(320, 371);
            txtCaseDate.Margin = new Padding(3, 4, 3, 4);
            txtCaseDate.Name = "txtCaseDate";
            txtCaseDate.PlaceholderText = "yyyy-mm-dd";
            txtCaseDate.Size = new Size(251, 27);
            txtCaseDate.TabIndex = 10;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(583, 347);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(195, 20);
            lblCourse.TabIndex = 11;
            lblCourse.Text = "Course Name and Number *";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(583, 371);
            txtCourse.Margin = new Padding(3, 4, 3, 4);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(342, 27);
            txtCourse.TabIndex = 12;
            // 
            // lblAssignment
            // 
            lblAssignment.AutoSize = true;
            lblAssignment.Location = new Point(11, 421);
            lblAssignment.Name = "lblAssignment";
            lblAssignment.Size = new Size(212, 20);
            lblAssignment.TabIndex = 13;
            lblAssignment.Text = "Assignment Number or Exam *";
            // 
            // txtAssignment
            // 
            txtAssignment.Location = new Point(11, 445);
            txtAssignment.Margin = new Padding(3, 4, 3, 4);
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Size = new Size(297, 27);
            txtAssignment.TabIndex = 14;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(320, 421);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(99, 20);
            lblDepartment.TabIndex = 15;
            lblDepartment.Text = "Department *";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(320, 445);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(251, 27);
            txtDepartment.TabIndex = 16;
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(583, 421);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(135, 20);
            lblTerm.TabIndex = 17;
            lblTerm.Text = "Term or Semester *";
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(583, 445);
            txtTerm.Margin = new Padding(3, 4, 3, 4);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(342, 27);
            txtTerm.TabIndex = 18;
            // 
            // lblViolation
            // 
            lblViolation.AutoSize = true;
            lblViolation.Location = new Point(11, 496);
            lblViolation.Name = "lblViolation";
            lblViolation.Size = new Size(1024, 20);
            lblViolation.TabIndex = 19;
            lblViolation.Text = "Description of Violation of Academic Integrity Policy ED 5-0 with respect to a particular assignment or exam (please use Page 4 if you need more room): *";
            // 
            // txtViolation
            // 
            txtViolation.Location = new Point(11, 520);
            txtViolation.Margin = new Padding(3, 4, 3, 4);
            txtViolation.Multiline = true;
            txtViolation.Name = "txtViolation";
            txtViolation.ScrollBars = ScrollBars.Vertical;
            txtViolation.Size = new Size(914, 132);
            txtViolation.TabIndex = 20;
            // 
            // lblSanctions
            // 
            lblSanctions.Location = new Point(11, 667);
            lblSanctions.Name = "lblSanctions";
            lblSanctions.Size = new Size(914, 88);
            lblSanctions.TabIndex = 21;
            lblSanctions.Text = resources.GetString("lblSanctions.Text");
            // 
            // lblAdvise
            // 
            lblAdvise.Location = new Point(11, 760);
            lblAdvise.Name = "lblAdvise";
            lblAdvise.Size = new Size(914, 45);
            lblAdvise.TabIndex = 22;
            lblAdvise.Text = "When contacting the student to arrange a meeting to discuss this alleged violation, please ensure the student is advised of the following: (please check these boxes when completed).";
            // 
            // chkAdvised1
            // 
            chkAdvised1.Location = new Point(11, 808);
            chkAdvised1.Margin = new Padding(3, 4, 3, 4);
            chkAdvised1.Name = "chkAdvised1";
            chkAdvised1.Size = new Size(914, 48);
            chkAdvised1.TabIndex = 23;
            chkAdvised1.Text = resources.GetString("chkAdvised1.Text");
            chkAdvised1.UseVisualStyleBackColor = true;
            // 
            // chkAdvised2
            // 
            chkAdvised2.Location = new Point(11, 861);
            chkAdvised2.Margin = new Padding(3, 4, 3, 4);
            chkAdvised2.Name = "chkAdvised2";
            chkAdvised2.Size = new Size(914, 29);
            chkAdvised2.TabIndex = 24;
            chkAdvised2.Text = "The student is advised that they may submit a written statement to the Academic Integrity Committee by email to aic@tru.ca.";
            chkAdvised2.UseVisualStyleBackColor = true;
            // 
            // lblStep1Sig
            // 
            lblStep1Sig.AutoSize = true;
            lblStep1Sig.Location = new Point(11, 907);
            lblStep1Sig.Name = "lblStep1Sig";
            lblStep1Sig.Size = new Size(199, 20);
            lblStep1Sig.TabIndex = 25;
            lblStep1Sig.Text = "Signature of Faculty Member";
            // 
            // txtStep1Sig
            // 
            txtStep1Sig.Location = new Point(11, 931);
            txtStep1Sig.Margin = new Padding(3, 4, 3, 4);
            txtStep1Sig.Name = "txtStep1Sig";
            txtStep1Sig.Size = new Size(297, 27);
            txtStep1Sig.TabIndex = 26;
            // 
            // lblStep1Name
            // 
            lblStep1Name.AutoSize = true;
            lblStep1Name.Location = new Point(320, 907);
            lblStep1Name.Name = "lblStep1Name";
            lblStep1Name.Size = new Size(176, 20);
            lblStep1Name.TabIndex = 27;
            lblStep1Name.Text = "Name of Faculty Member";
            // 
            // txtStep1Name
            // 
            txtStep1Name.Location = new Point(320, 931);
            txtStep1Name.Margin = new Padding(3, 4, 3, 4);
            txtStep1Name.Name = "txtStep1Name";
            txtStep1Name.Size = new Size(251, 27);
            txtStep1Name.TabIndex = 28;
            // 
            // lblStep1Date
            // 
            lblStep1Date.AutoSize = true;
            lblStep1Date.Location = new Point(583, 907);
            lblStep1Date.Name = "lblStep1Date";
            lblStep1Date.Size = new Size(139, 20);
            lblStep1Date.TabIndex = 29;
            lblStep1Date.Text = "Date (yyyy-mm-dd)";
            // 
            // txtStep1Date
            // 
            txtStep1Date.Location = new Point(583, 931);
            txtStep1Date.Margin = new Padding(3, 4, 3, 4);
            txtStep1Date.Name = "txtStep1Date";
            txtStep1Date.PlaceholderText = "yyyy-mm-dd";
            txtStep1Date.Size = new Size(342, 27);
            txtStep1Date.TabIndex = 30;
            // 
            // grpStep2
            // 
            grpStep2.Controls.Add(lblStep2Instr);
            grpStep2.Controls.Add(lblStudentName2);
            grpStep2.Controls.Add(txtStudentName2);
            grpStep2.Controls.Add(lblStep2Statement);
            grpStep2.Controls.Add(lblReviewed);
            grpStep2.Controls.Add(rdoReviewedYes);
            grpStep2.Controls.Add(rdoReviewedNo);
            grpStep2.Controls.Add(lblFurther);
            grpStep2.Controls.Add(lblMyTruEmail);
            grpStep2.Controls.Add(txtMyTruEmail);
            grpStep2.Controls.Add(lblCopyNote);
            grpStep2.Controls.Add(lblStep2Sig);
            grpStep2.Controls.Add(txtStep2Sig);
            grpStep2.Controls.Add(lblStep2Date);
            grpStep2.Controls.Add(txtStep2Date);
            grpStep2.Controls.Add(lblMyTruNote);
            grpStep2.Location = new Point(9, 1141);
            grpStep2.Margin = new Padding(3, 4, 3, 4);
            grpStep2.Name = "grpStep2";
            grpStep2.Padding = new Padding(3, 4, 3, 4);
            grpStep2.Size = new Size(939, 683);
            grpStep2.TabIndex = 8;
            grpStep2.TabStop = false;
            grpStep2.Text = "Step Two - To be completed by Student within seven (7) days of receipt";
            // 
            // lblStep2Instr
            // 
            lblStep2Instr.Location = new Point(11, 29);
            lblStep2Instr.Name = "lblStep2Instr";
            lblStep2Instr.Size = new Size(914, 149);
            lblStep2Instr.TabIndex = 0;
            lblStep2Instr.Text = resources.GetString("lblStep2Instr.Text");
            // 
            // lblStudentName2
            // 
            lblStudentName2.AutoSize = true;
            lblStudentName2.Location = new Point(11, 184);
            lblStudentName2.Name = "lblStudentName2";
            lblStudentName2.Size = new Size(271, 20);
            lblStudentName2.TabIndex = 1;
            lblStudentName2.Text = "I, (STUDENT NAME, TYPED or PRINTED)";
            // 
            // txtStudentName2
            // 
            txtStudentName2.Location = new Point(11, 208);
            txtStudentName2.Margin = new Padding(3, 4, 3, 4);
            txtStudentName2.Name = "txtStudentName2";
            txtStudentName2.Size = new Size(457, 27);
            txtStudentName2.TabIndex = 2;
            // 
            // lblStep2Statement
            // 
            lblStep2Statement.Location = new Point(11, 259);
            lblStep2Statement.Name = "lblStep2Statement";
            lblStep2Statement.Size = new Size(914, 152);
            lblStep2Statement.TabIndex = 3;
            lblStep2Statement.Text = resources.GetString("lblStep2Statement.Text");
            // 
            // lblReviewed
            // 
            lblReviewed.AutoSize = true;
            lblReviewed.Location = new Point(11, 424);
            lblReviewed.Name = "lblReviewed";
            lblReviewed.Size = new Size(454, 20);
            lblReviewed.TabIndex = 4;
            lblReviewed.Text = "I have reviewed the information in the form as well as the evidence:";
            // 
            // rdoReviewedYes
            // 
            rdoReviewedYes.AutoSize = true;
            rdoReviewedYes.Location = new Point(11, 451);
            rdoReviewedYes.Margin = new Padding(3, 4, 3, 4);
            rdoReviewedYes.Name = "rdoReviewedYes";
            rdoReviewedYes.Size = new Size(51, 24);
            rdoReviewedYes.TabIndex = 5;
            rdoReviewedYes.Text = "Yes";
            rdoReviewedYes.UseVisualStyleBackColor = true;
            // 
            // rdoReviewedNo
            // 
            rdoReviewedNo.AutoSize = true;
            rdoReviewedNo.Location = new Point(80, 451);
            rdoReviewedNo.Margin = new Padding(3, 4, 3, 4);
            rdoReviewedNo.Name = "rdoReviewedNo";
            rdoReviewedNo.Size = new Size(50, 24);
            rdoReviewedNo.TabIndex = 6;
            rdoReviewedNo.Text = "No";
            rdoReviewedNo.UseVisualStyleBackColor = true;
            // 
            // lblFurther
            // 
            lblFurther.AutoSize = true;
            lblFurther.Location = new Point(229, 453);
            lblFurther.Name = "lblFurther";
            lblFurther.Size = new Size(552, 20);
            lblFurther.TabIndex = 7;
            lblFurther.Text = "Further comments may be added on Page 5 of this document to explain your case.";
            // 
            // lblMyTruEmail
            // 
            lblMyTruEmail.AutoSize = true;
            lblMyTruEmail.Location = new Point(11, 496);
            lblMyTruEmail.Name = "lblMyTruEmail";
            lblMyTruEmail.Size = new Size(107, 20);
            lblMyTruEmail.TabIndex = 8;
            lblMyTruEmail.Text = "MyTRU email *";
            // 
            // txtMyTruEmail
            // 
            txtMyTruEmail.Location = new Point(11, 520);
            txtMyTruEmail.Margin = new Padding(3, 4, 3, 4);
            txtMyTruEmail.Name = "txtMyTruEmail";
            txtMyTruEmail.Size = new Size(457, 27);
            txtMyTruEmail.TabIndex = 9;
            // 
            // lblCopyNote
            // 
            lblCopyNote.Location = new Point(491, 499);
            lblCopyNote.Name = "lblCopyNote";
            lblCopyNote.Size = new Size(434, 53);
            lblCopyNote.TabIndex = 10;
            lblCopyNote.Text = "A copy of this documentation will be sent to the student by the Recording Secretary for the Academic Integrity Committee.";
            // 
            // lblStep2Sig
            // 
            lblStep2Sig.AutoSize = true;
            lblStep2Sig.Location = new Point(11, 581);
            lblStep2Sig.Name = "lblStep2Sig";
            lblStep2Sig.Size = new Size(145, 20);
            lblStep2Sig.TabIndex = 11;
            lblStep2Sig.Text = "Signature of Student";
            // 
            // txtStep2Sig
            // 
            txtStep2Sig.Location = new Point(11, 605);
            txtStep2Sig.Margin = new Padding(3, 4, 3, 4);
            txtStep2Sig.Name = "txtStep2Sig";
            txtStep2Sig.Size = new Size(457, 27);
            txtStep2Sig.TabIndex = 12;
            // 
            // lblStep2Date
            // 
            lblStep2Date.AutoSize = true;
            lblStep2Date.Location = new Point(583, 581);
            lblStep2Date.Name = "lblStep2Date";
            lblStep2Date.Size = new Size(139, 20);
            lblStep2Date.TabIndex = 13;
            lblStep2Date.Text = "Date (yyyy-mm-dd)";
            // 
            // txtStep2Date
            // 
            txtStep2Date.Location = new Point(583, 605);
            txtStep2Date.Margin = new Padding(3, 4, 3, 4);
            txtStep2Date.Name = "txtStep2Date";
            txtStep2Date.PlaceholderText = "yyyy-mm-dd";
            txtStep2Date.Size = new Size(342, 27);
            txtStep2Date.TabIndex = 14;
            // 
            // lblMyTruNote
            // 
            lblMyTruNote.AutoSize = true;
            lblMyTruNote.Location = new Point(11, 651);
            lblMyTruNote.Name = "lblMyTruNote";
            lblMyTruNote.Size = new Size(710, 20);
            lblMyTruNote.TabIndex = 15;
            lblMyTruNote.Text = "*All official correspondence from the committee will be sent to students at their @mytru.ca email address.";
            // 
            // grpStep3
            // 
            grpStep3.Controls.Add(lblStep3Instr);
            grpStep3.Controls.Add(lblStep3Sig);
            grpStep3.Controls.Add(txtStep3Sig);
            grpStep3.Controls.Add(lblStep3Name);
            grpStep3.Controls.Add(txtStep3Name);
            grpStep3.Controls.Add(lblStep3Date);
            grpStep3.Controls.Add(txtStep3Date);
            grpStep3.Location = new Point(9, 1835);
            grpStep3.Margin = new Padding(3, 4, 3, 4);
            grpStep3.Name = "grpStep3";
            grpStep3.Padding = new Padding(3, 4, 3, 4);
            grpStep3.Size = new Size(939, 325);
            grpStep3.TabIndex = 9;
            grpStep3.TabStop = false;
            grpStep3.Text = "Step Three - To be completed by Faculty Member";
            // 
            // lblStep3Instr
            // 
            lblStep3Instr.Location = new Point(11, 29);
            lblStep3Instr.Name = "lblStep3Instr";
            lblStep3Instr.Size = new Size(914, 211);
            lblStep3Instr.TabIndex = 0;
            lblStep3Instr.Text = resources.GetString("lblStep3Instr.Text");
            // 
            // lblStep3Sig
            // 
            lblStep3Sig.AutoSize = true;
            lblStep3Sig.Location = new Point(11, 251);
            lblStep3Sig.Name = "lblStep3Sig";
            lblStep3Sig.Size = new Size(199, 20);
            lblStep3Sig.TabIndex = 1;
            lblStep3Sig.Text = "Signature of Faculty Member";
            // 
            // txtStep3Sig
            // 
            txtStep3Sig.Location = new Point(11, 275);
            txtStep3Sig.Margin = new Padding(3, 4, 3, 4);
            txtStep3Sig.Name = "txtStep3Sig";
            txtStep3Sig.Size = new Size(297, 27);
            txtStep3Sig.TabIndex = 2;
            // 
            // lblStep3Name
            // 
            lblStep3Name.AutoSize = true;
            lblStep3Name.Location = new Point(320, 251);
            lblStep3Name.Name = "lblStep3Name";
            lblStep3Name.Size = new Size(176, 20);
            lblStep3Name.TabIndex = 3;
            lblStep3Name.Text = "Name of Faculty Member";
            // 
            // txtStep3Name
            // 
            txtStep3Name.Location = new Point(320, 275);
            txtStep3Name.Margin = new Padding(3, 4, 3, 4);
            txtStep3Name.Name = "txtStep3Name";
            txtStep3Name.Size = new Size(251, 27);
            txtStep3Name.TabIndex = 4;
            // 
            // lblStep3Date
            // 
            lblStep3Date.AutoSize = true;
            lblStep3Date.Location = new Point(583, 251);
            lblStep3Date.Name = "lblStep3Date";
            lblStep3Date.Size = new Size(139, 20);
            lblStep3Date.TabIndex = 5;
            lblStep3Date.Text = "Date (yyyy-mm-dd)";
            // 
            // txtStep3Date
            // 
            txtStep3Date.Location = new Point(583, 275);
            txtStep3Date.Margin = new Padding(3, 4, 3, 4);
            txtStep3Date.Name = "txtStep3Date";
            txtStep3Date.PlaceholderText = "yyyy-mm-dd";
            txtStep3Date.Size = new Size(342, 27);
            txtStep3Date.TabIndex = 6;
            // 
            // grpStep4
            // 
            grpStep4.Controls.Add(lblStep4Instr);
            grpStep4.Controls.Add(lblChairAgree);
            grpStep4.Controls.Add(rdoChairYes);
            grpStep4.Controls.Add(rdoChairNo);
            grpStep4.Controls.Add(lblChairExplain);
            grpStep4.Controls.Add(txtChairExplain);
            grpStep4.Controls.Add(lblChairComments);
            grpStep4.Controls.Add(txtChairComments);
            grpStep4.Controls.Add(lblChairSig);
            grpStep4.Controls.Add(txtChairSig);
            grpStep4.Controls.Add(lblChairName);
            grpStep4.Controls.Add(txtChairName);
            grpStep4.Controls.Add(lblChairDate);
            grpStep4.Controls.Add(txtChairDate);
            grpStep4.Location = new Point(9, 2171);
            grpStep4.Margin = new Padding(3, 4, 3, 4);
            grpStep4.Name = "grpStep4";
            grpStep4.Padding = new Padding(3, 4, 3, 4);
            grpStep4.Size = new Size(939, 640);
            grpStep4.TabIndex = 10;
            grpStep4.TabStop = false;
            grpStep4.Text = "Step Four - To be completed by the Department Chair";
            // 
            // lblStep4Instr
            // 
            lblStep4Instr.Location = new Point(11, 29);
            lblStep4Instr.Name = "lblStep4Instr";
            lblStep4Instr.Size = new Size(914, 211);
            lblStep4Instr.TabIndex = 0;
            lblStep4Instr.Text = resources.GetString("lblStep4Instr.Text");
            // 
            // lblChairAgree
            // 
            lblChairAgree.AutoSize = true;
            lblChairAgree.Location = new Point(11, 251);
            lblChairAgree.Name = "lblChairAgree";
            lblChairAgree.Size = new Size(447, 20);
            lblChairAgree.TabIndex = 1;
            lblChairAgree.Text = "I agree with the particulars of the case described in this document:";
            // 
            // rdoChairYes
            // 
            rdoChairYes.AutoSize = true;
            rdoChairYes.Location = new Point(11, 277);
            rdoChairYes.Margin = new Padding(3, 4, 3, 4);
            rdoChairYes.Name = "rdoChairYes";
            rdoChairYes.Size = new Size(51, 24);
            rdoChairYes.TabIndex = 2;
            rdoChairYes.Text = "Yes";
            rdoChairYes.UseVisualStyleBackColor = true;
            // 
            // rdoChairNo
            // 
            rdoChairNo.AutoSize = true;
            rdoChairNo.Location = new Point(80, 277);
            rdoChairNo.Margin = new Padding(3, 4, 3, 4);
            rdoChairNo.Name = "rdoChairNo";
            rdoChairNo.Size = new Size(50, 24);
            rdoChairNo.TabIndex = 3;
            rdoChairNo.Text = "No";
            rdoChairNo.UseVisualStyleBackColor = true;
            // 
            // lblChairExplain
            // 
            lblChairExplain.AutoSize = true;
            lblChairExplain.Location = new Point(11, 320);
            lblChairExplain.Name = "lblChairExplain";
            lblChairExplain.Size = new Size(277, 20);
            lblChairExplain.TabIndex = 4;
            lblChairExplain.Text = "If you have checked \"no,\" please explain.";
            // 
            // txtChairExplain
            // 
            txtChairExplain.Location = new Point(11, 344);
            txtChairExplain.Margin = new Padding(3, 4, 3, 4);
            txtChairExplain.Multiline = true;
            txtChairExplain.Name = "txtChairExplain";
            txtChairExplain.ScrollBars = ScrollBars.Vertical;
            txtChairExplain.Size = new Size(914, 79);
            txtChairExplain.TabIndex = 5;
            // 
            // lblChairComments
            // 
            lblChairComments.AutoSize = true;
            lblChairComments.Location = new Point(11, 435);
            lblChairComments.Name = "lblChairComments";
            lblChairComments.Size = new Size(80, 20);
            lblChairComments.TabIndex = 6;
            lblChairComments.Text = "Comments";
            // 
            // txtChairComments
            // 
            txtChairComments.Location = new Point(11, 459);
            txtChairComments.Margin = new Padding(3, 4, 3, 4);
            txtChairComments.Multiline = true;
            txtChairComments.Name = "txtChairComments";
            txtChairComments.ScrollBars = ScrollBars.Vertical;
            txtChairComments.Size = new Size(914, 92);
            txtChairComments.TabIndex = 7;
            // 
            // lblChairSig
            // 
            lblChairSig.AutoSize = true;
            lblChairSig.Location = new Point(11, 565);
            lblChairSig.Name = "lblChairSig";
            lblChairSig.Size = new Size(212, 20);
            lblChairSig.TabIndex = 8;
            lblChairSig.Text = "Signature of Department Chair";
            // 
            // txtChairSig
            // 
            txtChairSig.Location = new Point(11, 589);
            txtChairSig.Margin = new Padding(3, 4, 3, 4);
            txtChairSig.Name = "txtChairSig";
            txtChairSig.Size = new Size(297, 27);
            txtChairSig.TabIndex = 9;
            // 
            // lblChairName
            // 
            lblChairName.AutoSize = true;
            lblChairName.Location = new Point(320, 565);
            lblChairName.Name = "lblChairName";
            lblChairName.Size = new Size(189, 20);
            lblChairName.TabIndex = 10;
            lblChairName.Text = "Name of Department Chair";
            // 
            // txtChairName
            // 
            txtChairName.Location = new Point(320, 589);
            txtChairName.Margin = new Padding(3, 4, 3, 4);
            txtChairName.Name = "txtChairName";
            txtChairName.Size = new Size(251, 27);
            txtChairName.TabIndex = 11;
            // 
            // lblChairDate
            // 
            lblChairDate.AutoSize = true;
            lblChairDate.Location = new Point(583, 565);
            lblChairDate.Name = "lblChairDate";
            lblChairDate.Size = new Size(139, 20);
            lblChairDate.TabIndex = 12;
            lblChairDate.Text = "Date (yyyy-mm-dd)";
            // 
            // txtChairDate
            // 
            txtChairDate.Location = new Point(583, 589);
            txtChairDate.Margin = new Padding(3, 4, 3, 4);
            txtChairDate.Name = "txtChairDate";
            txtChairDate.PlaceholderText = "yyyy-mm-dd";
            txtChairDate.Size = new Size(342, 27);
            txtChairDate.TabIndex = 13;
            // 
            // grpStep5
            // 
            grpStep5.Controls.Add(lblStep5Instr);
            grpStep5.Controls.Add(lblDeanAgree);
            grpStep5.Controls.Add(rdoDeanYes);
            grpStep5.Controls.Add(rdoDeanNo);
            grpStep5.Controls.Add(lblDeanExplain);
            grpStep5.Controls.Add(txtDeanExplain);
            grpStep5.Controls.Add(lblDeanComments);
            grpStep5.Controls.Add(txtDeanComments);
            grpStep5.Controls.Add(lblDeanSig);
            grpStep5.Controls.Add(txtDeanSig);
            grpStep5.Controls.Add(lblDeanName);
            grpStep5.Controls.Add(txtDeanName);
            grpStep5.Controls.Add(lblDeanDate);
            grpStep5.Controls.Add(txtDeanDate);
            grpStep5.Location = new Point(9, 2821);
            grpStep5.Margin = new Padding(3, 4, 3, 4);
            grpStep5.Name = "grpStep5";
            grpStep5.Padding = new Padding(3, 4, 3, 4);
            grpStep5.Size = new Size(939, 675);
            grpStep5.TabIndex = 11;
            grpStep5.TabStop = false;
            grpStep5.Text = "Step Five - To be completed by the Dean";
            // 
            // lblStep5Instr
            // 
            lblStep5Instr.Location = new Point(11, 29);
            lblStep5Instr.Name = "lblStep5Instr";
            lblStep5Instr.Size = new Size(914, 245);
            lblStep5Instr.TabIndex = 0;
            lblStep5Instr.Text = resources.GetString("lblStep5Instr.Text");
            // 
            // lblDeanAgree
            // 
            lblDeanAgree.AutoSize = true;
            lblDeanAgree.Location = new Point(11, 285);
            lblDeanAgree.Name = "lblDeanAgree";
            lblDeanAgree.Size = new Size(447, 20);
            lblDeanAgree.TabIndex = 1;
            lblDeanAgree.Text = "I agree with the particulars of the case described in this document:";
            // 
            // rdoDeanYes
            // 
            rdoDeanYes.AutoSize = true;
            rdoDeanYes.Location = new Point(11, 312);
            rdoDeanYes.Margin = new Padding(3, 4, 3, 4);
            rdoDeanYes.Name = "rdoDeanYes";
            rdoDeanYes.Size = new Size(51, 24);
            rdoDeanYes.TabIndex = 2;
            rdoDeanYes.Text = "Yes";
            rdoDeanYes.UseVisualStyleBackColor = true;
            // 
            // rdoDeanNo
            // 
            rdoDeanNo.AutoSize = true;
            rdoDeanNo.Location = new Point(80, 312);
            rdoDeanNo.Margin = new Padding(3, 4, 3, 4);
            rdoDeanNo.Name = "rdoDeanNo";
            rdoDeanNo.Size = new Size(50, 24);
            rdoDeanNo.TabIndex = 3;
            rdoDeanNo.Text = "No";
            rdoDeanNo.UseVisualStyleBackColor = true;
            // 
            // lblDeanExplain
            // 
            lblDeanExplain.AutoSize = true;
            lblDeanExplain.Location = new Point(11, 355);
            lblDeanExplain.Name = "lblDeanExplain";
            lblDeanExplain.Size = new Size(277, 20);
            lblDeanExplain.TabIndex = 4;
            lblDeanExplain.Text = "If you have checked \"no,\" please explain.";
            // 
            // txtDeanExplain
            // 
            txtDeanExplain.Location = new Point(11, 379);
            txtDeanExplain.Margin = new Padding(3, 4, 3, 4);
            txtDeanExplain.Multiline = true;
            txtDeanExplain.Name = "txtDeanExplain";
            txtDeanExplain.ScrollBars = ScrollBars.Vertical;
            txtDeanExplain.Size = new Size(914, 79);
            txtDeanExplain.TabIndex = 5;
            // 
            // lblDeanComments
            // 
            lblDeanComments.AutoSize = true;
            lblDeanComments.Location = new Point(11, 469);
            lblDeanComments.Name = "lblDeanComments";
            lblDeanComments.Size = new Size(80, 20);
            lblDeanComments.TabIndex = 6;
            lblDeanComments.Text = "Comments";
            // 
            // txtDeanComments
            // 
            txtDeanComments.Location = new Point(11, 493);
            txtDeanComments.Margin = new Padding(3, 4, 3, 4);
            txtDeanComments.Multiline = true;
            txtDeanComments.Name = "txtDeanComments";
            txtDeanComments.ScrollBars = ScrollBars.Vertical;
            txtDeanComments.Size = new Size(914, 92);
            txtDeanComments.TabIndex = 7;
            // 
            // lblDeanSig
            // 
            lblDeanSig.AutoSize = true;
            lblDeanSig.Location = new Point(11, 600);
            lblDeanSig.Name = "lblDeanSig";
            lblDeanSig.Size = new Size(129, 20);
            lblDeanSig.TabIndex = 8;
            lblDeanSig.Text = "Signature of Dean";
            // 
            // txtDeanSig
            // 
            txtDeanSig.Location = new Point(11, 624);
            txtDeanSig.Margin = new Padding(3, 4, 3, 4);
            txtDeanSig.Name = "txtDeanSig";
            txtDeanSig.Size = new Size(297, 27);
            txtDeanSig.TabIndex = 9;
            // 
            // lblDeanName
            // 
            lblDeanName.AutoSize = true;
            lblDeanName.Location = new Point(320, 600);
            lblDeanName.Name = "lblDeanName";
            lblDeanName.Size = new Size(106, 20);
            lblDeanName.TabIndex = 10;
            lblDeanName.Text = "Name of Dean";
            // 
            // txtDeanName
            // 
            txtDeanName.Location = new Point(320, 624);
            txtDeanName.Margin = new Padding(3, 4, 3, 4);
            txtDeanName.Name = "txtDeanName";
            txtDeanName.Size = new Size(251, 27);
            txtDeanName.TabIndex = 11;
            // 
            // lblDeanDate
            // 
            lblDeanDate.AutoSize = true;
            lblDeanDate.Location = new Point(583, 600);
            lblDeanDate.Name = "lblDeanDate";
            lblDeanDate.Size = new Size(139, 20);
            lblDeanDate.TabIndex = 12;
            lblDeanDate.Text = "Date (yyyy-mm-dd)";
            // 
            // txtDeanDate
            // 
            txtDeanDate.Location = new Point(583, 624);
            txtDeanDate.Margin = new Padding(3, 4, 3, 4);
            txtDeanDate.Name = "txtDeanDate";
            txtDeanDate.PlaceholderText = "yyyy-mm-dd";
            txtDeanDate.Size = new Size(342, 27);
            txtDeanDate.TabIndex = 13;
            // 
            // grpComments
            // 
            grpComments.Controls.Add(lblFacultyComments);
            grpComments.Controls.Add(txtFacultyComments);
            grpComments.Controls.Add(lblStudentComments);
            grpComments.Controls.Add(txtStudentComments);
            grpComments.Location = new Point(9, 3507);
            grpComments.Margin = new Padding(3, 4, 3, 4);
            grpComments.Name = "grpComments";
            grpComments.Padding = new Padding(3, 4, 3, 4);
            grpComments.Size = new Size(939, 515);
            grpComments.TabIndex = 12;
            grpComments.TabStop = false;
            grpComments.Text = "Pages 4 and 5 - Comments";
            // 
            // lblFacultyComments
            // 
            lblFacultyComments.AutoSize = true;
            lblFacultyComments.Location = new Point(11, 29);
            lblFacultyComments.Name = "lblFacultyComments";
            lblFacultyComments.Size = new Size(247, 20);
            lblFacultyComments.TabIndex = 0;
            lblFacultyComments.Text = "Faculty Member Comments (Page 4)";
            // 
            // txtFacultyComments
            // 
            txtFacultyComments.Location = new Point(11, 53);
            txtFacultyComments.Margin = new Padding(3, 4, 3, 4);
            txtFacultyComments.Multiline = true;
            txtFacultyComments.Name = "txtFacultyComments";
            txtFacultyComments.ScrollBars = ScrollBars.Vertical;
            txtFacultyComments.Size = new Size(914, 199);
            txtFacultyComments.TabIndex = 1;
            // 
            // lblStudentComments
            // 
            lblStudentComments.AutoSize = true;
            lblStudentComments.Location = new Point(11, 267);
            lblStudentComments.Name = "lblStudentComments";
            lblStudentComments.Size = new Size(193, 20);
            lblStudentComments.TabIndex = 2;
            lblStudentComments.Text = "Student Comments (Page 5)";
            // 
            // txtStudentComments
            // 
            txtStudentComments.Location = new Point(11, 291);
            txtStudentComments.Margin = new Padding(3, 4, 3, 4);
            txtStudentComments.Multiline = true;
            txtStudentComments.Name = "txtStudentComments";
            txtStudentComments.ScrollBars = ScrollBars.Vertical;
            txtStudentComments.Size = new Size(914, 199);
            txtStudentComments.TabIndex = 3;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(lblSearchBy);
            grpSearch.Controls.Add(cmbSearchBy);
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(btnShowAll);
            grpSearch.Location = new Point(1013, 11);
            grpSearch.Margin = new Padding(3, 4, 3, 4);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(3, 4, 3, 4);
            grpSearch.Size = new Size(555, 93);
            grpSearch.TabIndex = 1;
            grpSearch.TabStop = false;
            grpSearch.Text = "Find records";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.Location = new Point(11, 43);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(73, 20);
            lblSearchBy.TabIndex = 0;
            lblSearchBy.Text = "Search by";
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "Any", "Record ID", "Student Name", "Student Number", "Faculty Name" });
            cmbSearchBy.Location = new Point(82, 37);
            cmbSearchBy.Margin = new Padding(3, 4, 3, 4);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(118, 28);
            cmbSearchBy.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(208, 37);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type to search...";
            txtSearch.Size = new Size(148, 27);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(366, 36);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(457, 36);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(87, 35);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AllowUserToResizeRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BackgroundColor = SystemColors.Window;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colRecordId, colStudent, colNumber, colFaculty, colCourse, colDate });
            dgvRecords.Location = new Point(1013, 115);
            dgvRecords.Margin = new Padding(3, 4, 3, 4);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(555, 360);
            dgvRecords.TabIndex = 2;
            dgvRecords.CellDoubleClick += dgvRecords_CellDoubleClick;
            dgvRecords.SelectionChanged += dgvRecords_SelectionChanged;
            // 
            // colRecordId
            // 
            colRecordId.FillWeight = 60F;
            colRecordId.HeaderText = "Record ID";
            colRecordId.MinimumWidth = 6;
            colRecordId.Name = "colRecordId";
            colRecordId.ReadOnly = true;
            // 
            // colStudent
            // 
            colStudent.HeaderText = "Student Name";
            colStudent.MinimumWidth = 6;
            colStudent.Name = "colStudent";
            colStudent.ReadOnly = true;
            // 
            // colNumber
            // 
            colNumber.FillWeight = 90F;
            colNumber.HeaderText = "Student No.";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colFaculty
            // 
            colFaculty.HeaderText = "Faculty Member";
            colFaculty.MinimumWidth = 6;
            colFaculty.Name = "colFaculty";
            colFaculty.ReadOnly = true;
            // 
            // colCourse
            // 
            colCourse.FillWeight = 90F;
            colCourse.HeaderText = "Course";
            colCourse.MinimumWidth = 6;
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 75F;
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(txtDetails);
            grpDetails.Location = new Point(1013, 485);
            grpDetails.Margin = new Padding(3, 4, 3, 4);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(3, 4, 3, 4);
            grpDetails.Size = new Size(555, 307);
            grpDetails.TabIndex = 3;
            grpDetails.TabStop = false;
            grpDetails.Text = "Selected record - details";
            // 
            // txtDetails
            // 
            txtDetails.BackColor = SystemColors.Window;
            txtDetails.Dock = DockStyle.Fill;
            txtDetails.Location = new Point(3, 24);
            txtDetails.Margin = new Padding(3, 4, 3, 4);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(549, 279);
            txtDetails.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1013, 805);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 53);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save New Record";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1170, 805);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 53);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear / New";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(1282, 805);
            btnModify.Margin = new Padding(3, 4, 3, 4);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(137, 53);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modify Selected";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1429, 805);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 53);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMode.Location = new Point(1013, 875);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(90, 20);
            lblMode.TabIndex = 8;
            lblMode.Text = "New record";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(1013, 912);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 1055);
            Controls.Add(pnlForm);
            Controls.Add(grpSearch);
            Controls.Add(dgvRecords);
            Controls.Add(grpDetails);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(lblMode);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TRU Academic Integrity - Case Report Form (ED 5-0)";
            Load += Form1_Load;
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpStep1.ResumeLayout(false);
            grpStep1.PerformLayout();
            grpStep2.ResumeLayout(false);
            grpStep2.PerformLayout();
            grpStep3.ResumeLayout(false);
            grpStep3.PerformLayout();
            grpStep4.ResumeLayout(false);
            grpStep4.PerformLayout();
            grpStep5.ResumeLayout(false);
            grpStep5.PerformLayout();
            grpComments.ResumeLayout(false);
            grpComments.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private PictureBox picLogo;
        private Label lblPolicy;
        private Label lblFormTitle;
        private Label lblOsa;
        private TextBox txtOsa;
        private Label lblAddress;
        private Label lblIntro;
        private GroupBox grpStep1;
        private Label lblStep1Instr;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblStudentNumber;
        private TextBox txtStudentNumber;
        private Label lblStudentEmail;
        private TextBox txtStudentEmail;
        private Label lblFacultyName;
        private TextBox txtFacultyName;
        private Label lblCaseDate;
        private TextBox txtCaseDate;
        private Label lblCourse;
        private TextBox txtCourse;
        private Label lblAssignment;
        private TextBox txtAssignment;
        private Label lblDepartment;
        private TextBox txtDepartment;
        private Label lblTerm;
        private TextBox txtTerm;
        private Label lblViolation;
        private TextBox txtViolation;
        private Label lblSanctions;
        private Label lblAdvise;
        private CheckBox chkAdvised1;
        private CheckBox chkAdvised2;
        private Label lblStep1Sig;
        private TextBox txtStep1Sig;
        private Label lblStep1Name;
        private TextBox txtStep1Name;
        private Label lblStep1Date;
        private TextBox txtStep1Date;
        private GroupBox grpStep2;
        private Label lblStep2Instr;
        private Label lblStudentName2;
        private TextBox txtStudentName2;
        private Label lblStep2Statement;
        private Label lblReviewed;
        private RadioButton rdoReviewedYes;
        private RadioButton rdoReviewedNo;
        private Label lblFurther;
        private Label lblMyTruEmail;
        private TextBox txtMyTruEmail;
        private Label lblCopyNote;
        private Label lblStep2Sig;
        private TextBox txtStep2Sig;
        private Label lblStep2Date;
        private TextBox txtStep2Date;
        private Label lblMyTruNote;
        private GroupBox grpStep3;
        private Label lblStep3Instr;
        private Label lblStep3Sig;
        private TextBox txtStep3Sig;
        private Label lblStep3Name;
        private TextBox txtStep3Name;
        private Label lblStep3Date;
        private TextBox txtStep3Date;
        private GroupBox grpStep4;
        private Label lblStep4Instr;
        private Label lblChairAgree;
        private RadioButton rdoChairYes;
        private RadioButton rdoChairNo;
        private Label lblChairExplain;
        private TextBox txtChairExplain;
        private Label lblChairComments;
        private TextBox txtChairComments;
        private Label lblChairSig;
        private TextBox txtChairSig;
        private Label lblChairName;
        private TextBox txtChairName;
        private Label lblChairDate;
        private TextBox txtChairDate;
        private GroupBox grpStep5;
        private Label lblStep5Instr;
        private Label lblDeanAgree;
        private RadioButton rdoDeanYes;
        private RadioButton rdoDeanNo;
        private Label lblDeanExplain;
        private TextBox txtDeanExplain;
        private Label lblDeanComments;
        private TextBox txtDeanComments;
        private Label lblDeanSig;
        private TextBox txtDeanSig;
        private Label lblDeanName;
        private TextBox txtDeanName;
        private Label lblDeanDate;
        private TextBox txtDeanDate;
        private GroupBox grpComments;
        private Label lblFacultyComments;
        private TextBox txtFacultyComments;
        private Label lblStudentComments;
        private TextBox txtStudentComments;
        private GroupBox grpSearch;
        private Label lblSearchBy;
        private ComboBox cmbSearchBy;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dgvRecords;
        private GroupBox grpDetails;
        private TextBox txtDetails;
        private Button btnSave;
        private Button btnClear;
        private Button btnModify;
        private Button btnDelete;
        private Label lblMode;
        private Label lblStatus;
        private DataGridViewTextBoxColumn colRecordId;
        private DataGridViewTextBoxColumn colStudent;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colFaculty;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colDate;
    }
}
