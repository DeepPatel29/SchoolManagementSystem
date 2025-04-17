namespace SchoolManagementSystem
{
    partial class FrmDashBoard
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
            this.panelStudents = new System.Windows.Forms.Panel();
            this.txtStudentsCount = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTStudents = new System.Windows.Forms.Label();
            this.panelTeachers = new System.Windows.Forms.Panel();
            this.txtInstructors = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTInstructors = new System.Windows.Forms.Label();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.txtCoursesCount = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTCourses = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnGradingReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMngGradings = new System.Windows.Forms.Button();
            this.btnMngCourses = new System.Windows.Forms.Button();
            this.btnMngInstructors = new System.Windows.Forms.Button();
            this.btnMngStudents = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvTopStudents = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStudents
            // 
            this.panelStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelStudents.Controls.Add(this.txtStudentsCount);
            this.panelStudents.Controls.Add(this.pictureBox2);
            this.panelStudents.Controls.Add(this.lblTStudents);
            this.panelStudents.Location = new System.Drawing.Point(353, 13);
            this.panelStudents.Margin = new System.Windows.Forms.Padding(4);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(345, 125);
            this.panelStudents.TabIndex = 1;
            this.panelStudents.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStudents_Paint);
            // 
            // txtStudentsCount
            // 
            this.txtStudentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentsCount.Location = new System.Drawing.Point(85, 49);
            this.txtStudentsCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentsCount.Name = "txtStudentsCount";
            this.txtStudentsCount.ReadOnly = true;
            this.txtStudentsCount.Size = new System.Drawing.Size(132, 37);
            this.txtStudentsCount.TabIndex = 2;
            this.txtStudentsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblTStudents
            // 
            this.lblTStudents.AutoSize = true;
            this.lblTStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTStudents.Location = new System.Drawing.Point(13, 12);
            this.lblTStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTStudents.Name = "lblTStudents";
            this.lblTStudents.Size = new System.Drawing.Size(139, 25);
            this.lblTStudents.TabIndex = 0;
            this.lblTStudents.Text = "Total Students";
            // 
            // panelTeachers
            // 
            this.panelTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTeachers.Controls.Add(this.txtInstructors);
            this.panelTeachers.Controls.Add(this.pictureBox3);
            this.panelTeachers.Controls.Add(this.lblTInstructors);
            this.panelTeachers.Location = new System.Drawing.Point(775, 13);
            this.panelTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeachers.Name = "panelTeachers";
            this.panelTeachers.Size = new System.Drawing.Size(345, 125);
            this.panelTeachers.TabIndex = 2;
            // 
            // txtInstructors
            // 
            this.txtInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructors.Location = new System.Drawing.Point(89, 49);
            this.txtInstructors.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstructors.Name = "txtInstructors";
            this.txtInstructors.ReadOnly = true;
            this.txtInstructors.Size = new System.Drawing.Size(132, 37);
            this.txtInstructors.TabIndex = 2;
            this.txtInstructors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInstructors.TextChanged += new System.EventHandler(this.txtTotalNumInstructors_TextChanged_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(22, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 49);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblTInstructors
            // 
            this.lblTInstructors.AutoSize = true;
            this.lblTInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTInstructors.Location = new System.Drawing.Point(13, 12);
            this.lblTInstructors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTInstructors.Name = "lblTInstructors";
            this.lblTInstructors.Size = new System.Drawing.Size(151, 25);
            this.lblTInstructors.TabIndex = 0;
            this.lblTInstructors.Text = "Total Instructors";
            // 
            // panelCourses
            // 
            this.panelCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelCourses.Controls.Add(this.txtCoursesCount);
            this.panelCourses.Controls.Add(this.pictureBox4);
            this.panelCourses.Controls.Add(this.lblTCourses);
            this.panelCourses.Location = new System.Drawing.Point(1189, 13);
            this.panelCourses.Margin = new System.Windows.Forms.Padding(4);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(345, 125);
            this.panelCourses.TabIndex = 3;
            this.panelCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCourses_Paint);
            // 
            // txtCoursesCount
            // 
            this.txtCoursesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoursesCount.Location = new System.Drawing.Point(95, 49);
            this.txtCoursesCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoursesCount.Name = "txtCoursesCount";
            this.txtCoursesCount.ReadOnly = true;
            this.txtCoursesCount.Size = new System.Drawing.Size(132, 37);
            this.txtCoursesCount.TabIndex = 2;
            this.txtCoursesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(28, 49);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 49);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lblTCourses
            // 
            this.lblTCourses.AutoSize = true;
            this.lblTCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCourses.Location = new System.Drawing.Point(13, 12);
            this.lblTCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTCourses.Name = "lblTCourses";
            this.lblTCourses.Size = new System.Drawing.Size(135, 25);
            this.lblTCourses.TabIndex = 0;
            this.lblTCourses.Text = "Total Courses";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Controls.Add(this.lblWelcome);
            this.panelLeft.Controls.Add(this.btnGradingReports);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnMngGradings);
            this.panelLeft.Controls.Add(this.btnMngCourses);
            this.panelLeft.Controls.Add(this.btnMngInstructors);
            this.panelLeft.Controls.Add(this.btnMngStudents);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 1);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(314, 822);
            this.panelLeft.TabIndex = 11;
            // 
            // btnGradingReports
            // 
            this.btnGradingReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradingReports.Location = new System.Drawing.Point(12, 598);
            this.btnGradingReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGradingReports.Name = "btnGradingReports";
            this.btnGradingReports.Size = new System.Drawing.Size(289, 33);
            this.btnGradingReports.TabIndex = 8;
            this.btnGradingReports.Text = "Grading Reports";
            this.btnGradingReports.UseVisualStyleBackColor = true;
            this.btnGradingReports.Click += new System.EventHandler(this.btnGradingReports_Click);
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
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 772);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(289, 33);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMngGradings
            // 
            this.btnMngGradings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngGradings.Location = new System.Drawing.Point(12, 535);
            this.btnMngGradings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngGradings.Name = "btnMngGradings";
            this.btnMngGradings.Size = new System.Drawing.Size(289, 33);
            this.btnMngGradings.TabIndex = 5;
            this.btnMngGradings.Text = "Manage Grading";
            this.btnMngGradings.UseVisualStyleBackColor = true;
            this.btnMngGradings.Click += new System.EventHandler(this.btnMngGradings_Click);
            // 
            // btnMngCourses
            // 
            this.btnMngCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngCourses.Location = new System.Drawing.Point(12, 463);
            this.btnMngCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngCourses.Name = "btnMngCourses";
            this.btnMngCourses.Size = new System.Drawing.Size(289, 33);
            this.btnMngCourses.TabIndex = 4;
            this.btnMngCourses.Text = "Manage Courses";
            this.btnMngCourses.UseVisualStyleBackColor = true;
            this.btnMngCourses.Click += new System.EventHandler(this.btnMngCourses_Click);
            // 
            // btnMngInstructors
            // 
            this.btnMngInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngInstructors.Location = new System.Drawing.Point(12, 394);
            this.btnMngInstructors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngInstructors.Name = "btnMngInstructors";
            this.btnMngInstructors.Size = new System.Drawing.Size(289, 33);
            this.btnMngInstructors.TabIndex = 3;
            this.btnMngInstructors.Text = "Manage Instructors";
            this.btnMngInstructors.UseVisualStyleBackColor = true;
            this.btnMngInstructors.Click += new System.EventHandler(this.btnMngInstructors_Click);
            // 
            // btnMngStudents
            // 
            this.btnMngStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngStudents.Location = new System.Drawing.Point(12, 315);
            this.btnMngStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMngStudents.Name = "btnMngStudents";
            this.btnMngStudents.Size = new System.Drawing.Size(289, 33);
            this.btnMngStudents.TabIndex = 2;
            this.btnMngStudents.Text = "Manage Students";
            this.btnMngStudents.UseVisualStyleBackColor = true;
            this.btnMngStudents.Click += new System.EventHandler(this.btnMngStudents_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 250);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(289, 33);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvTopStudents
            // 
            this.dgvTopStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopStudents.Location = new System.Drawing.Point(331, 160);
            this.dgvTopStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTopStudents.Name = "dgvTopStudents";
            this.dgvTopStudents.RowHeadersWidth = 51;
            this.dgvTopStudents.Size = new System.Drawing.Size(1236, 646);
            this.dgvTopStudents.TabIndex = 4;
            this.dgvTopStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(70, 706);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            this.lblWelcome.TabIndex = 9;
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 819);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.dgvTopStudents);
            this.Controls.Add(this.panelCourses);
            this.Controls.Add(this.panelTeachers);
            this.Controls.Add(this.panelStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System - Dashboard";
            this.panelStudents.ResumeLayout(false);
            this.panelStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTeachers.ResumeLayout(false);
            this.panelTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelCourses.ResumeLayout(false);
            this.panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Label lblTStudents;
        private System.Windows.Forms.Panel panelTeachers;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.Label lblTInstructors;
        private System.Windows.Forms.TextBox txtStudentsCount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtInstructors;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtCoursesCount;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTCourses;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMngGradings;
        private System.Windows.Forms.Button btnMngCourses;
        private System.Windows.Forms.Button btnMngInstructors;
        private System.Windows.Forms.Button btnMngStudents;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvTopStudents;
        private System.Windows.Forms.Button btnGradingReports;
        private System.Windows.Forms.Label lblWelcome;
    }
}