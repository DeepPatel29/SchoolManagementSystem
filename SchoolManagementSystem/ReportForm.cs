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
    public partial class ReportForm: Form
    {
        private readonly string _userType;

        private string mode;
        public ReportForm(string type)
        {
            InitializeComponent();
            mode = type;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                if (mode == "student")
                {
                    var studentList = context.Students
                        .Select(s => new
                        {
                            s.StudentID,
                            FullName = s.FirstName + " " + s.LastName
                        }).ToList();

                    //MessageBox.Show($"Found {studentList.Count} student(s).");

                    if (studentList.Count > 0)
                    {
                        cmbList.DataSource = studentList;
                        cmbList.DisplayMember = "FullName";
                        cmbList.ValueMember = "StudentID";
                    }
                    else
                    {
                        MessageBox.Show("No students found in the database.");
                        cmbList.DataSource = null;
                    }
                }
                else
                {
                    var courseList = context.Courses
                        .Select(c => new { c.CourseID, c.CourseName })
                        .ToList();

                    //MessageBox.Show($"Found {courseList.Count} course(s).");

                    if (courseList.Count > 0)
                    {
                        cmbList.DataSource = courseList;
                        cmbList.DisplayMember = "CourseName";
                        cmbList.ValueMember = "CourseID";
                    }
                    else
                    {
                        MessageBox.Show("No courses found in the database.");
                        cmbList.DataSource = null;
                    }
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbList.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid option before generating the PDF.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(cmbList.SelectedValue);

            if (mode == "student")
                PDFReport.GenerateStudentReport(id);
            else
                PDFReport.GenerateCourseReport(id);
        }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Navigation button events with error handling
        private void btnHome_Click_1(object sender, EventArgs e)
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

        private void btnMngStudents_Click_1(object sender, EventArgs e)
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
                
        private void btnMngInstructors_Click_1(object sender, EventArgs e)
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

        private void btnMngCourses_Click_1(object sender, EventArgs e)
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

        private void btnMngGradings_Click_1(object sender, EventArgs e)
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
                // Access buttons through panelLeft (not direct form.Controls)
                if (panelLeft.Controls["btnMngStudents"] is Button btnStudents)
                {
                    btnStudents.Enabled = false;
                }
                if (panelLeft.Controls["btnMngInstructors"] is Button btnInstructors)
                {
                    btnInstructors.Enabled = false;
                }
                if (panelLeft.Controls["btnMngCourses"] is Button btnCourses)
                {
                    btnCourses.Enabled = false;
                }
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
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
    }
}
