namespace SchoolManagementSystem
{
    partial class ReportForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnGradingReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMngGradings = new System.Windows.Forms.Button();
            this.btnMngCourses = new System.Windows.Forms.Button();
            this.btnMngInstructors = new System.Windows.Forms.Button();
            this.btnMngStudents = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Controls.Add(this.btnGradingReports);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnMngGradings);
            this.panelLeft.Controls.Add(this.btnMngCourses);
            this.panelLeft.Controls.Add(this.btnMngInstructors);
            this.panelLeft.Controls.Add(this.btnMngStudents);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.panelLeft.Location = new System.Drawing.Point(2, 1);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(314, 822);
            this.panelLeft.TabIndex = 15;
            // 
            // btnGradingReports
            // 
            this.btnGradingReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradingReports.Location = new System.Drawing.Point(12, 597);
            this.btnGradingReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGradingReports.Name = "btnGradingReports";
            this.btnGradingReports.Size = new System.Drawing.Size(289, 33);
            this.btnGradingReports.TabIndex = 10;
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
            this.btnLogout.Location = new System.Drawing.Point(0, 786);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(314, 33);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
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
            this.btnMngGradings.Click += new System.EventHandler(this.btnMngGradings_Click_1);
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
            this.btnMngCourses.Click += new System.EventHandler(this.btnMngCourses_Click_1);
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
            this.btnMngInstructors.Click += new System.EventHandler(this.btnMngInstructors_Click_1);
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
            this.btnMngStudents.Click += new System.EventHandler(this.btnMngStudents_Click_1);
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(789, 399);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(67, 25);
            this.lblSelect.TabIndex = 16;
            this.lblSelect.Text = "Select";
            // 
            // cmbList
            // 
            this.cmbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(913, 391);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(214, 33);
            this.cmbList.TabIndex = 17;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(857, 464);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(177, 39);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate PDF";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 819);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.panelLeft);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnGradingReports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMngGradings;
        private System.Windows.Forms.Button btnMngCourses;
        private System.Windows.Forms.Button btnMngInstructors;
        private System.Windows.Forms.Button btnMngStudents;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Button btnGenerate;
    }
}