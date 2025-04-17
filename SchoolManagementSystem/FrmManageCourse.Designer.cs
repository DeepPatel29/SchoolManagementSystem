namespace SchoolManagementSystem
{
    partial class FrmManageCourse
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.cmbInstructors = new System.Windows.Forms.ComboBox();
            this.txtSchedule = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.lblMaxStudents = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblNumCreditHours = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblManageCourses = new System.Windows.Forms.Label();
            this.tabCourses = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.numMaxStudents = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPageEnrollStudents = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAssignStudent = new System.Windows.Forms.Button();
            this.dgvAvailableStudents = new System.Windows.Forms.DataGridView();
            this.dgvEnrolledStudents = new System.Windows.Forms.DataGridView();
            this.lblCourseSelection = new System.Windows.Forms.Label();
            this.cmbSelectCourse = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMngGradings = new System.Windows.Forms.Button();
            this.btnMngCourses = new System.Windows.Forms.Button();
            this.btnMngInstructors = new System.Windows.Forms.Button();
            this.btnMngStudents = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnGradingReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCourses.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPageEnrollStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledStudents)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(660, 605);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(575, 508);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(455, 30);
            this.txtRoomNumber.TabIndex = 14;
            // 
            // cmbInstructors
            // 
            this.cmbInstructors.FormattingEnabled = true;
            this.cmbInstructors.Location = new System.Drawing.Point(575, 391);
            this.cmbInstructors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbInstructors.Name = "cmbInstructors";
            this.cmbInstructors.Size = new System.Drawing.Size(455, 33);
            this.cmbInstructors.TabIndex = 12;
            // 
            // txtSchedule
            // 
            this.txtSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchedule.Location = new System.Drawing.Point(575, 330);
            this.txtSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(455, 30);
            this.txtSchedule.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(575, 118);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(455, 110);
            this.txtDescription.TabIndex = 9;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(575, 47);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(455, 30);
            this.txtCourseName.TabIndex = 8;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.ForeColor = System.Drawing.Color.Black;
            this.lblRoomNum.Location = new System.Drawing.Point(257, 513);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(143, 25);
            this.lblRoomNum.TabIndex = 6;
            this.lblRoomNum.Text = "Room Number:";
            // 
            // lblMaxStudents
            // 
            this.lblMaxStudents.AutoSize = true;
            this.lblMaxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxStudents.ForeColor = System.Drawing.Color.Black;
            this.lblMaxStudents.Location = new System.Drawing.Point(257, 452);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new System.Drawing.Size(281, 25);
            this.lblMaxStudents.TabIndex = 5;
            this.lblMaxStudents.Text = "Maximum Number of Students:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.ForeColor = System.Drawing.Color.Black;
            this.lblInstructor.Location = new System.Drawing.Point(257, 394);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(98, 25);
            this.lblInstructor.TabIndex = 4;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.ForeColor = System.Drawing.Color.Black;
            this.lblDoB.Location = new System.Drawing.Point(257, 334);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(124, 25);
            this.lblDoB.TabIndex = 3;
            this.lblDoB.Text = "Date of Birth:";
            // 
            // lblNumCreditHours
            // 
            this.lblNumCreditHours.AutoSize = true;
            this.lblNumCreditHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCreditHours.ForeColor = System.Drawing.Color.Black;
            this.lblNumCreditHours.Location = new System.Drawing.Point(257, 268);
            this.lblNumCreditHours.Name = "lblNumCreditHours";
            this.lblNumCreditHours.Size = new System.Drawing.Size(222, 25);
            this.lblNumCreditHours.TabIndex = 2;
            this.lblNumCreditHours.Text = "Number of Credit Hours:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(251, 156);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.Black;
            this.lblCourseName.Location = new System.Drawing.Point(254, 47);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(139, 25);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblManageCourses
            // 
            this.lblManageCourses.AutoSize = true;
            this.lblManageCourses.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.lblManageCourses.Location = new System.Drawing.Point(882, 23);
            this.lblManageCourses.Name = "lblManageCourses";
            this.lblManageCourses.Size = new System.Drawing.Size(177, 25);
            this.lblManageCourses.TabIndex = 12;
            this.lblManageCourses.Text = "Manage Courses";
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.tabPageSearch);
            this.tabCourses.Controls.Add(this.tabPageAdd);
            this.tabCourses.Controls.Add(this.tabPageEnrollStudents);
            this.tabCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCourses.Location = new System.Drawing.Point(324, 72);
            this.tabCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.SelectedIndex = 0;
            this.tabCourses.Size = new System.Drawing.Size(1251, 746);
            this.tabCourses.TabIndex = 11;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.btnDelete);
            this.tabPageSearch.Controls.Add(this.btnUpdate);
            this.tabPageSearch.Controls.Add(this.btnAdd);
            this.tabPageSearch.Controls.Add(this.dataGridView1);
            this.tabPageSearch.Controls.Add(this.txtSearchStudent);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.ForeColor = System.Drawing.Color.Black;
            this.tabPageSearch.Location = new System.Drawing.Point(4, 34);
            this.tabPageSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSearch.Size = new System.Drawing.Size(1243, 708);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search Course";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(802, 659);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(571, 659);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 37);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(329, 659);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 542);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(100, 40);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(744, 30);
            this.txtSearchStudent.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(864, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 37);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.numMaxStudents);
            this.tabPageAdd.Controls.Add(this.numericUpDown1);
            this.tabPageAdd.Controls.Add(this.btnCancel);
            this.tabPageAdd.Controls.Add(this.btnSave);
            this.tabPageAdd.Controls.Add(this.txtRoomNumber);
            this.tabPageAdd.Controls.Add(this.cmbInstructors);
            this.tabPageAdd.Controls.Add(this.txtSchedule);
            this.tabPageAdd.Controls.Add(this.txtDescription);
            this.tabPageAdd.Controls.Add(this.txtCourseName);
            this.tabPageAdd.Controls.Add(this.lblRoomNum);
            this.tabPageAdd.Controls.Add(this.lblMaxStudents);
            this.tabPageAdd.Controls.Add(this.lblInstructor);
            this.tabPageAdd.Controls.Add(this.lblDoB);
            this.tabPageAdd.Controls.Add(this.lblNumCreditHours);
            this.tabPageAdd.Controls.Add(this.lblDescription);
            this.tabPageAdd.Controls.Add(this.lblCourseName);
            this.tabPageAdd.ForeColor = System.Drawing.Color.Black;
            this.tabPageAdd.Location = new System.Drawing.Point(4, 34);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Size = new System.Drawing.Size(1243, 708);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add Course";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // numMaxStudents
            // 
            this.numMaxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxStudents.Location = new System.Drawing.Point(575, 452);
            this.numMaxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMaxStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxStudents.Name = "numMaxStudents";
            this.numMaxStudents.Size = new System.Drawing.Size(454, 30);
            this.numMaxStudents.TabIndex = 19;
            this.numMaxStudents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(575, 268);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(454, 30);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(466, 605);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tabPageEnrollStudents
            // 
            this.tabPageEnrollStudents.Controls.Add(this.label2);
            this.tabPageEnrollStudents.Controls.Add(this.label1);
            this.tabPageEnrollStudents.Controls.Add(this.btnRemoveStudent);
            this.tabPageEnrollStudents.Controls.Add(this.btnAssignStudent);
            this.tabPageEnrollStudents.Controls.Add(this.dgvAvailableStudents);
            this.tabPageEnrollStudents.Controls.Add(this.dgvEnrolledStudents);
            this.tabPageEnrollStudents.Controls.Add(this.lblCourseSelection);
            this.tabPageEnrollStudents.Controls.Add(this.cmbSelectCourse);
            this.tabPageEnrollStudents.Location = new System.Drawing.Point(4, 34);
            this.tabPageEnrollStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEnrollStudents.Name = "tabPageEnrollStudents";
            this.tabPageEnrollStudents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEnrollStudents.Size = new System.Drawing.Size(1243, 708);
            this.tabPageEnrollStudents.TabIndex = 2;
            this.tabPageEnrollStudents.Text = "Enroll Student In Course";
            this.tabPageEnrollStudents.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(864, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enrolled Students";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Students";
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStudent.Location = new System.Drawing.Point(821, 653);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(239, 38);
            this.btnRemoveStudent.TabIndex = 5;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            // 
            // btnAssignStudent
            // 
            this.btnAssignStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnAssignStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignStudent.ForeColor = System.Drawing.Color.White;
            this.btnAssignStudent.Location = new System.Drawing.Point(164, 653);
            this.btnAssignStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignStudent.Name = "btnAssignStudent";
            this.btnAssignStudent.Size = new System.Drawing.Size(239, 38);
            this.btnAssignStudent.TabIndex = 4;
            this.btnAssignStudent.Text = "Assign Student";
            this.btnAssignStudent.UseVisualStyleBackColor = false;
            // 
            // dgvAvailableStudents
            // 
            this.dgvAvailableStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableStudents.Location = new System.Drawing.Point(54, 139);
            this.dgvAvailableStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAvailableStudents.Name = "dgvAvailableStudents";
            this.dgvAvailableStudents.RowHeadersWidth = 62;
            this.dgvAvailableStudents.RowTemplate.Height = 28;
            this.dgvAvailableStudents.Size = new System.Drawing.Size(529, 482);
            this.dgvAvailableStudents.TabIndex = 3;
            // 
            // dgvEnrolledStudents
            // 
            this.dgvEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolledStudents.Location = new System.Drawing.Point(675, 139);
            this.dgvEnrolledStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEnrolledStudents.Name = "dgvEnrolledStudents";
            this.dgvEnrolledStudents.RowHeadersWidth = 62;
            this.dgvEnrolledStudents.RowTemplate.Height = 28;
            this.dgvEnrolledStudents.Size = new System.Drawing.Size(529, 482);
            this.dgvEnrolledStudents.TabIndex = 2;
            // 
            // lblCourseSelection
            // 
            this.lblCourseSelection.AutoSize = true;
            this.lblCourseSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSelection.ForeColor = System.Drawing.Color.Black;
            this.lblCourseSelection.Location = new System.Drawing.Point(50, 30);
            this.lblCourseSelection.Name = "lblCourseSelection";
            this.lblCourseSelection.Size = new System.Drawing.Size(147, 25);
            this.lblCourseSelection.TabIndex = 1;
            this.lblCourseSelection.Text = "Select Course: ";
            // 
            // cmbSelectCourse
            // 
            this.cmbSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCourse.FormattingEnabled = true;
            this.cmbSelectCourse.Location = new System.Drawing.Point(220, 30);
            this.cmbSelectCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSelectCourse.Name = "cmbSelectCourse";
            this.cmbSelectCourse.Size = new System.Drawing.Size(389, 33);
            this.cmbSelectCourse.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(22, 757);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(279, 41);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMngGradings
            // 
            this.btnMngGradings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngGradings.Location = new System.Drawing.Point(33, 487);
            this.btnMngGradings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngGradings.Name = "btnMngGradings";
            this.btnMngGradings.Size = new System.Drawing.Size(257, 41);
            this.btnMngGradings.TabIndex = 5;
            this.btnMngGradings.Text = "Manage Grading";
            this.btnMngGradings.UseVisualStyleBackColor = true;
            this.btnMngGradings.Click += new System.EventHandler(this.btnMngGradings_Click);
            // 
            // btnMngCourses
            // 
            this.btnMngCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngCourses.Location = new System.Drawing.Point(33, 429);
            this.btnMngCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngCourses.Name = "btnMngCourses";
            this.btnMngCourses.Size = new System.Drawing.Size(257, 41);
            this.btnMngCourses.TabIndex = 4;
            this.btnMngCourses.Text = "Manage Courses";
            this.btnMngCourses.UseVisualStyleBackColor = true;
            this.btnMngCourses.Click += new System.EventHandler(this.btnMngCourses_Click);
            // 
            // btnMngInstructors
            // 
            this.btnMngInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngInstructors.Location = new System.Drawing.Point(33, 374);
            this.btnMngInstructors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngInstructors.Name = "btnMngInstructors";
            this.btnMngInstructors.Size = new System.Drawing.Size(257, 41);
            this.btnMngInstructors.TabIndex = 3;
            this.btnMngInstructors.Text = "Manage Instructors";
            this.btnMngInstructors.UseVisualStyleBackColor = true;
            this.btnMngInstructors.Click += new System.EventHandler(this.btnMngInstructors_Click);
            // 
            // btnMngStudents
            // 
            this.btnMngStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngStudents.Location = new System.Drawing.Point(33, 311);
            this.btnMngStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngStudents.Name = "btnMngStudents";
            this.btnMngStudents.Size = new System.Drawing.Size(257, 41);
            this.btnMngStudents.TabIndex = 2;
            this.btnMngStudents.Text = "Manage Students";
            this.btnMngStudents.UseVisualStyleBackColor = true;
            this.btnMngStudents.Click += new System.EventHandler(this.btnMngStudents_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(11, 200);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(257, 26);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Controls.Add(this.btnGradingReports);
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnMngGradings);
            this.panelLeft.Controls.Add(this.btnMngCourses);
            this.panelLeft.Controls.Add(this.btnMngInstructors);
            this.panelLeft.Controls.Add(this.btnMngStudents);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Location = new System.Drawing.Point(5, -1);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(314, 822);
            this.panelLeft.TabIndex = 10;
            // 
            // btnGradingReports
            // 
            this.btnGradingReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradingReports.Location = new System.Drawing.Point(33, 547);
            this.btnGradingReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGradingReports.Name = "btnGradingReports";
            this.btnGradingReports.Size = new System.Drawing.Size(257, 41);
            this.btnGradingReports.TabIndex = 8;
            this.btnGradingReports.Text = "Grading Reports";
            this.btnGradingReports.UseVisualStyleBackColor = true;
            this.btnGradingReports.Click += new System.EventHandler(this.btnGradingReports_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.School_Management_Syste__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 819);
            this.Controls.Add(this.lblManageCourses);
            this.Controls.Add(this.tabCourses);
            this.Controls.Add(this.panelLeft);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManageCourse";
            this.Text = "Manage Course";
            this.tabCourses.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPageEnrollStudents.ResumeLayout(false);
            this.tabPageEnrollStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledStudents)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.ComboBox cmbInstructors;
        private System.Windows.Forms.DateTimePicker txtSchedule;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label lblMaxStudents;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblNumCreditHours;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblManageCourses;
        private System.Windows.Forms.TabControl tabCourses;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMngGradings;
        private System.Windows.Forms.Button btnMngCourses;
        private System.Windows.Forms.Button btnMngInstructors;
        private System.Windows.Forms.Button btnMngStudents;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numMaxStudents;
        private System.Windows.Forms.TabPage tabPageEnrollStudents;
        private System.Windows.Forms.Label lblCourseSelection;
        private System.Windows.Forms.ComboBox cmbSelectCourse;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAssignStudent;
        private System.Windows.Forms.DataGridView dgvAvailableStudents;
        private System.Windows.Forms.DataGridView dgvEnrolledStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGradingReports;
    }
}