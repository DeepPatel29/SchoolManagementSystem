namespace SchoolManagementSystem
{
    partial class FrmManageGrading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMngGradings = new System.Windows.Forms.Button();
            this.btnMngCourses = new System.Windows.Forms.Button();
            this.btnMngInstructors = new System.Windows.Forms.Button();
            this.btnMngStudents = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageGenerateStudentReport = new System.Windows.Forms.TabPage();
            this.dgvStudentReport = new System.Windows.Forms.DataGridView();
            this.cmbStudentReport = new System.Windows.Forms.ComboBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnGenerateReportStudents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnGradingReports = new System.Windows.Forms.Button();
            this.btnGenerateStudentReport = new System.Windows.Forms.Button();
            this.lblManageCourses = new System.Windows.Forms.Label();
            this.tabCourses = new System.Windows.Forms.TabControl();
            this.tabPageAddGrade = new System.Windows.Forms.TabPage();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpGradeDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.tabGenerateCourseReport = new System.Windows.Forms.TabPage();
            this.dgvCourseReport = new System.Windows.Forms.DataGridView();
            this.cmbReportCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageGenerateStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentReport)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.tabCourses.SuspendLayout();
            this.tabPageAddGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabGenerateCourseReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(22, 760);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(279, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(739, 578);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "CANCEL";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(388, 578);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnMngGradings
            // 
            this.btnMngGradings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngGradings.Location = new System.Drawing.Point(22, 505);
            this.btnMngGradings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngGradings.Name = "btnMngGradings";
            this.btnMngGradings.Size = new System.Drawing.Size(257, 35);
            this.btnMngGradings.TabIndex = 5;
            this.btnMngGradings.Text = "Manage Grading";
            this.btnMngGradings.UseVisualStyleBackColor = true;
            this.btnMngGradings.Click += new System.EventHandler(this.btnMngGradings_Click);
            // 
            // btnMngCourses
            // 
            this.btnMngCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngCourses.Location = new System.Drawing.Point(22, 447);
            this.btnMngCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngCourses.Name = "btnMngCourses";
            this.btnMngCourses.Size = new System.Drawing.Size(257, 35);
            this.btnMngCourses.TabIndex = 4;
            this.btnMngCourses.Text = "Manage Courses";
            this.btnMngCourses.UseVisualStyleBackColor = true;
            this.btnMngCourses.Click += new System.EventHandler(this.btnMngCourses_Click);
            // 
            // btnMngInstructors
            // 
            this.btnMngInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngInstructors.Location = new System.Drawing.Point(22, 392);
            this.btnMngInstructors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngInstructors.Name = "btnMngInstructors";
            this.btnMngInstructors.Size = new System.Drawing.Size(257, 35);
            this.btnMngInstructors.TabIndex = 3;
            this.btnMngInstructors.Text = "Manage Instructors";
            this.btnMngInstructors.UseVisualStyleBackColor = true;
            this.btnMngInstructors.Click += new System.EventHandler(this.btnMngInstructors_Click);
            // 
            // btnMngStudents
            // 
            this.btnMngStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngStudents.Location = new System.Drawing.Point(22, 329);
            this.btnMngStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngStudents.Name = "btnMngStudents";
            this.btnMngStudents.Size = new System.Drawing.Size(257, 35);
            this.btnMngStudents.TabIndex = 2;
            this.btnMngStudents.Text = "Manage Students";
            this.btnMngStudents.UseVisualStyleBackColor = true;
            this.btnMngStudents.Click += new System.EventHandler(this.btnMngStudents_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(22, 277);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(257, 35);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.School_Management_Syste__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageGenerateStudentReport
            // 
            this.tabPageGenerateStudentReport.Controls.Add(this.dgvStudentReport);
            this.tabPageGenerateStudentReport.Controls.Add(this.cmbStudentReport);
            this.tabPageGenerateStudentReport.Controls.Add(this.lblStudents);
            this.tabPageGenerateStudentReport.Controls.Add(this.btnGenerateReportStudents);
            this.tabPageGenerateStudentReport.Controls.Add(this.label2);
            this.tabPageGenerateStudentReport.Location = new System.Drawing.Point(4, 34);
            this.tabPageGenerateStudentReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGenerateStudentReport.Name = "tabPageGenerateStudentReport";
            this.tabPageGenerateStudentReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGenerateStudentReport.Size = new System.Drawing.Size(1243, 708);
            this.tabPageGenerateStudentReport.TabIndex = 2;
            this.tabPageGenerateStudentReport.Text = "Generate Report By Student";
            this.tabPageGenerateStudentReport.UseVisualStyleBackColor = true;
            // 
            // dgvStudentReport
            // 
            this.dgvStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentReport.Location = new System.Drawing.Point(33, 103);
            this.dgvStudentReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudentReport.Name = "dgvStudentReport";
            this.dgvStudentReport.RowHeadersWidth = 62;
            this.dgvStudentReport.RowTemplate.Height = 28;
            this.dgvStudentReport.Size = new System.Drawing.Size(1181, 519);
            this.dgvStudentReport.TabIndex = 23;
            // 
            // cmbStudentReport
            // 
            this.cmbStudentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentReport.FormattingEnabled = true;
            this.cmbStudentReport.Location = new System.Drawing.Point(143, 33);
            this.cmbStudentReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudentReport.Name = "cmbStudentReport";
            this.cmbStudentReport.Size = new System.Drawing.Size(422, 33);
            this.cmbStudentReport.TabIndex = 22;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(28, 33);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(80, 25);
            this.lblStudents.TabIndex = 21;
            this.lblStudents.Text = "Student";
            this.lblStudents.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerateReportStudents
            // 
            this.btnGenerateReportStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnGenerateReportStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReportStudents.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReportStudents.Location = new System.Drawing.Point(435, 645);
            this.btnGenerateReportStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReportStudents.Name = "btnGenerateReportStudents";
            this.btnGenerateReportStudents.Size = new System.Drawing.Size(325, 35);
            this.btnGenerateReportStudents.TabIndex = 20;
            this.btnGenerateReportStudents.Text = "Generate Report By Student";
            this.btnGenerateReportStudents.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(864, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 7;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Controls.Add(this.btnGradingReports);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnMngGradings);
            this.panelLeft.Controls.Add(this.btnMngCourses);
            this.panelLeft.Controls.Add(this.btnMngInstructors);
            this.panelLeft.Controls.Add(this.btnMngStudents);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Location = new System.Drawing.Point(5, -1);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(314, 822);
            this.panelLeft.TabIndex = 13;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // btnGradingReports
            // 
            this.btnGradingReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradingReports.Location = new System.Drawing.Point(22, 563);
            this.btnGradingReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGradingReports.Name = "btnGradingReports";
            this.btnGradingReports.Size = new System.Drawing.Size(257, 35);
            this.btnGradingReports.TabIndex = 9;
            this.btnGradingReports.Text = "Grading Reports";
            this.btnGradingReports.UseVisualStyleBackColor = true;
            this.btnGradingReports.Click += new System.EventHandler(this.btnGradingReports_Click);
            // 
            // btnGenerateStudentReport
            // 
            this.btnGenerateStudentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnGenerateStudentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStudentReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateStudentReport.Location = new System.Drawing.Point(443, 644);
            this.btnGenerateStudentReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateStudentReport.Name = "btnGenerateStudentReport";
            this.btnGenerateStudentReport.Size = new System.Drawing.Size(325, 35);
            this.btnGenerateStudentReport.TabIndex = 16;
            this.btnGenerateStudentReport.Text = "Generate Report By Course";
            this.btnGenerateStudentReport.UseVisualStyleBackColor = false;
            // 
            // lblManageCourses
            // 
            this.lblManageCourses.AutoSize = true;
            this.lblManageCourses.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.lblManageCourses.Location = new System.Drawing.Point(882, 23);
            this.lblManageCourses.Name = "lblManageCourses";
            this.lblManageCourses.Size = new System.Drawing.Size(183, 25);
            this.lblManageCourses.TabIndex = 15;
            this.lblManageCourses.Text = "Manage Gradings";
            this.lblManageCourses.Click += new System.EventHandler(this.lblManageCourses_Click);
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.tabPageAddGrade);
            this.tabCourses.Controls.Add(this.tabGenerateCourseReport);
            this.tabCourses.Controls.Add(this.tabPageGenerateStudentReport);
            this.tabCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCourses.Location = new System.Drawing.Point(324, 72);
            this.tabCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.SelectedIndex = 0;
            this.tabCourses.Size = new System.Drawing.Size(1251, 746);
            this.tabCourses.TabIndex = 14;
            this.tabCourses.SelectedIndexChanged += new System.EventHandler(this.tabCourses_SelectedIndexChanged);
            // 
            // tabPageAddGrade
            // 
            this.tabPageAddGrade.Controls.Add(this.txtNotes);
            this.tabPageAddGrade.Controls.Add(this.lblNotes);
            this.tabPageAddGrade.Controls.Add(this.dtpGradeDate);
            this.tabPageAddGrade.Controls.Add(this.label3);
            this.tabPageAddGrade.Controls.Add(this.numericUpDown2);
            this.tabPageAddGrade.Controls.Add(this.lblGrade);
            this.tabPageAddGrade.Controls.Add(this.lblStudent);
            this.tabPageAddGrade.Controls.Add(this.cmbStudents);
            this.tabPageAddGrade.Controls.Add(this.cmbCourses);
            this.tabPageAddGrade.Controls.Add(this.lblCourse);
            this.tabPageAddGrade.Controls.Add(this.btnDelete);
            this.tabPageAddGrade.Controls.Add(this.btnAdd);
            this.tabPageAddGrade.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddGrade.Name = "tabPageAddGrade";
            this.tabPageAddGrade.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddGrade.Size = new System.Drawing.Size(1243, 708);
            this.tabPageAddGrade.TabIndex = 0;
            this.tabPageAddGrade.Text = "Add Grade";
            this.tabPageAddGrade.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(519, 370);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(354, 106);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(384, 413);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(74, 25);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes: ";
            this.lblNotes.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // dtpGradeDate
            // 
            this.dtpGradeDate.Location = new System.Drawing.Point(519, 294);
            this.dtpGradeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpGradeDate.Name = "dtpGradeDate";
            this.dtpGradeDate.Size = new System.Drawing.Size(354, 30);
            this.dtpGradeDate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grade Date: ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(519, 226);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(354, 30);
            this.numericUpDown2.TabIndex = 11;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(384, 226);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(77, 25);
            this.lblGrade.TabIndex = 10;
            this.lblGrade.Text = "Grade: ";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(384, 150);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(91, 25);
            this.lblStudent.TabIndex = 9;
            this.lblStudent.Text = "Student: ";
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(519, 150);
            this.cmbStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(354, 33);
            this.cmbStudents.TabIndex = 8;
            // 
            // cmbCourses
            // 
            this.cmbCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(519, 80);
            this.cmbCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(354, 33);
            this.cmbCourses.TabIndex = 7;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(384, 82);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(87, 25);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course: ";
            // 
            // tabGenerateCourseReport
            // 
            this.tabGenerateCourseReport.Controls.Add(this.dgvCourseReport);
            this.tabGenerateCourseReport.Controls.Add(this.cmbReportCourse);
            this.tabGenerateCourseReport.Controls.Add(this.label4);
            this.tabGenerateCourseReport.Controls.Add(this.btnGenerateStudentReport);
            this.tabGenerateCourseReport.Location = new System.Drawing.Point(4, 34);
            this.tabGenerateCourseReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenerateCourseReport.Name = "tabGenerateCourseReport";
            this.tabGenerateCourseReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGenerateCourseReport.Size = new System.Drawing.Size(1243, 708);
            this.tabGenerateCourseReport.TabIndex = 1;
            this.tabGenerateCourseReport.Text = "Generate Report By Course";
            this.tabGenerateCourseReport.UseVisualStyleBackColor = true;
            // 
            // dgvCourseReport
            // 
            this.dgvCourseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseReport.Location = new System.Drawing.Point(41, 102);
            this.dgvCourseReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCourseReport.Name = "dgvCourseReport";
            this.dgvCourseReport.RowHeadersWidth = 62;
            this.dgvCourseReport.RowTemplate.Height = 28;
            this.dgvCourseReport.Size = new System.Drawing.Size(1181, 519);
            this.dgvCourseReport.TabIndex = 19;
            // 
            // cmbReportCourse
            // 
            this.cmbReportCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportCourse.FormattingEnabled = true;
            this.cmbReportCourse.Location = new System.Drawing.Point(151, 32);
            this.cmbReportCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbReportCourse.Name = "cmbReportCourse";
            this.cmbReportCourse.Size = new System.Drawing.Size(422, 33);
            this.cmbReportCourse.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course";
            // 
            // FrmManageGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 819);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblManageCourses);
            this.Controls.Add(this.tabCourses);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManageGrading";
            this.Text = "Manage Grading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageGenerateStudentReport.ResumeLayout(false);
            this.tabPageGenerateStudentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentReport)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            this.tabPageAddGrade.ResumeLayout(false);
            this.tabPageAddGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabGenerateCourseReport.ResumeLayout(false);
            this.tabGenerateCourseReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMngGradings;
        private System.Windows.Forms.Button btnMngCourses;
        private System.Windows.Forms.Button btnMngInstructors;
        private System.Windows.Forms.Button btnMngStudents;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageGenerateStudentReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnGenerateStudentReport;
        private System.Windows.Forms.Label lblManageCourses;
        private System.Windows.Forms.TabControl tabCourses;
        private System.Windows.Forms.TabPage tabPageAddGrade;
        private System.Windows.Forms.TabPage tabGenerateCourseReport;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DateTimePicker dtpGradeDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DataGridView dgvCourseReport;
        private System.Windows.Forms.ComboBox cmbReportCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStudentReport;
        private System.Windows.Forms.ComboBox cmbStudentReport;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnGenerateReportStudents;
        private System.Windows.Forms.Button btnGradingReports;
    }
}