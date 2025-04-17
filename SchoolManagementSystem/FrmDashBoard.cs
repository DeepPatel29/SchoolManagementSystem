using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem
{
    public partial class FrmDashBoard : Form
    {
        private User currentUser;
        private readonly string _userType; // Declare _userType as a private field

        // Modified constructor to accept userType
        public FrmDashBoard(string userType)
        {
            InitializeComponent();
            _userType = userType; // Store user type
            LoadDashboardData();
            SetupAccessControls(); // Call access control setup
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {currentUser.UserType}: {currentUser.Username}";
        }

        private void LoadDashboardData()
        {
            try
            {
                // Load summary counts
                txtStudentsCount.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Students")?.ToString() ?? "0";
                txtInstructors.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Instructors")?.ToString() ?? "0";
                txtCoursesCount.Text = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Courses")?.ToString() ?? "0";

                // Load top students
                string query = @"SELECT TOP 5
                                    s.StudentNumber AS ID,
                                    s.FirstName + ' ' + s.LastName AS [Student Name],
                                    c.CourseName AS [Course],
                                    AVG(g.GradeValue) AS [Average Grade]
                                FROM Grades g
                                INNER JOIN StudentCourses sc ON g.StudentCourseID = sc.StudentCourseID
                                INNER JOIN Students s ON sc.StudentID = s.StudentID
                                INNER JOIN Courses c ON sc.CourseID = c.CourseID
                                GROUP BY s.StudentNumber, s.FirstName, s.LastName, c.CourseName
                                ORDER BY [Average Grade] DESC;";

                dgvTopStudents.DataSource = DatabaseHelper.ExecuteQuery(query);
                dgvTopStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigation button events with error handling
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDashboardData();
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

        // Empty event handlers
        private void txtTotalNumStudents_TextChanged(object sender, EventArgs e) { }
        private void txtTotalNumInstructors_TextChanged(object sender, EventArgs e) { }
        private void txtTotalNumCourses_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panelStudents_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void txtTotalNumInstructors_TextChanged_1(object sender, EventArgs e) { }
        private void panelCourses_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

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
    }
}
