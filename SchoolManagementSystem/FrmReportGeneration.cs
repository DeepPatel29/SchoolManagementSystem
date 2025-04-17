using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem
{
    public partial class FrmReportGeneration: Form
    {
        private readonly string _userType;
        public FrmReportGeneration(string userType)
        {
            InitializeComponent();
        }

        private void FrmReportGeneration_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm("student");
            reportForm.ShowDialog();
        }

        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm("course");
            reportForm.ShowDialog();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            EmailPopupForm emailPopup = new EmailPopupForm();
            emailPopup.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmDashBoard(_userType).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing dashboard: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMngStudents_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmManageStudents(_userType).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Manage Students form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show(); // Show the dashboard again if the new form fails to open
            }
        }

        private void btnMngInstructors_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmManageInstructors(_userType).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Manage Instructors form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void btnMngCourses_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmManageCourse(_userType).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Manage Courses form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void btnMngGradings_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmManageGrading(_userType).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Manage Grading form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGradingReports_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FrmReportGeneration(_userType).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Report Generation form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void SetupAccessControls()
        {
            if (_userType == "Teacher")
            {
                // Disable navigation buttons (located in panelLeft)
                if (Controls.Find("btnMngStudents", true).FirstOrDefault() is Button btnStudents)
                {
                    btnStudents.Enabled = false;
                }
                if (Controls.Find("btnMngInstructors", true).FirstOrDefault() is Button btnInstructors)
                {
                    btnInstructors.Enabled = false;
                }
                if (Controls.Find("btnMngCourses", true).FirstOrDefault() is Button btnCourses)
                {
                    btnCourses.Enabled = false;
                }
            }
        }
    }
}
