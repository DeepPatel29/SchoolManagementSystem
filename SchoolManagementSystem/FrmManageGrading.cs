using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class FrmManageGrading : Form
    {
        private readonly string _userType; // Add this field

        // Modified constructor to accept userType
        public FrmManageGrading(string userType)
        {
            InitializeComponent();
            _userType = userType;
            LoadCourses();
            LoadStudents();
            LoadReportCourses();
            LoadReportStudents();
            SetupAccessControls();

            // Attach all missing handlers
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnGenerateReportStudents.Click += btnGenerateReportStudents_Click;
            btnGenerateStudentReport.Click += btnGenerateStudentReport_Click;

            this.FormClosing += FrmManageGrading_FormClosing;
        }

        private void LoadCourses()
        {
            try
            {
                string query = "SELECT CourseID, CourseName FROM Courses";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbCourses.DataSource = dt;
                cmbCourses.DisplayMember = "CourseName";
                cmbCourses.ValueMember = "CourseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                string query = "SELECT StudentID, FirstName + ' ' + LastName AS StudentName FROM Students";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbStudents.DataSource = dt;
                cmbStudents.DisplayMember = "StudentName";
                cmbStudents.ValueMember = "StudentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReportCourses()
        {
            try
            {
                string query = "SELECT CourseID, CourseName FROM Courses";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbReportCourse.DataSource = dt;
                cmbReportCourse.DisplayMember = "CourseName";
                cmbReportCourse.ValueMember = "CourseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReportStudents()
        {
            try
            {
                string query = "SELECT StudentID, FirstName + ' ' + LastName AS StudentName FROM Students";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbStudentReport.DataSource = dt;
                cmbStudentReport.DisplayMember = "StudentName";
                cmbStudentReport.ValueMember = "StudentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (cmbCourses.SelectedValue == null || cmbStudents.SelectedValue == null || numericUpDown2.Value < 0)
                {
                    MessageBox.Show("Please select a course, student, and enter a valid grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the student is already enrolled in the course
                int studentCourseId;
                int studentId = Convert.ToInt32(cmbStudents.SelectedValue);
                int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

                string checkQuery = @"
                    SELECT StudentCourseID
                    FROM StudentCourses
                    WHERE StudentID = @StudentID AND CourseID = @CourseID";

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@CourseID", courseId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        studentCourseId = (int)result;
                    }
                    else
                    {
                        // If not enrolled, insert into StudentCourses
                        string insertStudentCourseQuery = @"
                            INSERT INTO StudentCourses (StudentID, CourseID, EnrollmentDate)
                            OUTPUT INSERTED.StudentCourseID
                            VALUES (@StudentID, @CourseID, @EnrollmentDate)";

                        using (SqlCommand insertCmd = new SqlCommand(insertStudentCourseQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@StudentID", studentId);
                            insertCmd.Parameters.AddWithValue("@CourseID", courseId);
                            insertCmd.Parameters.AddWithValue("@EnrollmentDate", DateTime.Now);
                            studentCourseId = (int)insertCmd.ExecuteScalar();
                        }
                    }
                }

                // Insert into Grades using the StudentCourseID
                string insertGradeQuery = @"
                    INSERT INTO Grades (StudentCourseID, GradeValue, GradeDate, Notes)
                    VALUES (@StudentCourseID, @GradeValue, @GradeDate, @Notes)";

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                using (SqlCommand cmd = new SqlCommand(insertGradeQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentCourseID", studentCourseId);
                    cmd.Parameters.AddWithValue("@GradeValue", numericUpDown2.Value);
                    cmd.Parameters.AddWithValue("@GradeDate", dtpGradeDate.Value);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text ?? (object)DBNull.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Grade added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddGradeForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding grade: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearAddGradeForm();
        }

        private void btnGenerateStudentReport_Click(object sender, EventArgs e)
        {
            if (cmbReportCourse.SelectedValue != null)
            {
                try
                {
                    int courseId = Convert.ToInt32(cmbReportCourse.SelectedValue);
                    string query = @"
                        SELECT
                            s.StudentID,
                            s.StudentNumber,
                            s.FirstName + ' ' + s.LastName AS StudentName,
                            c.CourseName,
                            g.GradeValue,
                            g.GradeDate,
                            g.Notes
                        FROM Students s
                        JOIN StudentCourses sc ON s.StudentID = sc.StudentID
                        JOIN Grades g ON sc.StudentCourseID = g.StudentCourseID
                        JOIN Courses c ON sc.CourseID = c.CourseID
                        WHERE sc.CourseID = @CourseID";

                    using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", courseId);
                        conn.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgvCourseReport.DataSource = dt;
                        dgvCourseReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating course report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a course to generate the report.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateReportStudents_Click(object sender, EventArgs e)
        {
            if (cmbStudentReport.SelectedValue != null)
            {
                try
                {
                    int studentId = Convert.ToInt32(cmbStudentReport.SelectedValue);
                    string query = @"
                        SELECT
                            s.StudentID,
                            s.StudentNumber,
                            s.FirstName + ' ' + s.LastName AS StudentName,
                            c.CourseName,
                            g.GradeValue,
                            g.GradeDate,
                            g.Notes
                        FROM Students s
                        JOIN StudentCourses sc ON s.StudentID = sc.StudentID
                        JOIN Grades g ON sc.StudentCourseID = g.StudentCourseID
                        JOIN Courses c ON sc.CourseID = c.CourseID
                        WHERE s.StudentID = @StudentID";

                    using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        conn.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgvStudentReport.DataSource = dt;
                        dgvStudentReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating student report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to generate the report.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearAddGradeForm()
        {
            cmbCourses.SelectedIndex = -1;
            cmbStudents.SelectedIndex = -1;
            numericUpDown2.Value = 0;
            dtpGradeDate.Value = DateTime.Now;
            txtNotes.Clear();
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
                MessageBox.Show("Error returning to dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
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
                MessageBox.Show("Error opening Manage Students form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
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
                MessageBox.Show("Error opening Manage Instructors form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error opening Manage Courses form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void btnMngGradings_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCourses();
                LoadStudents();
                LoadReportCourses();
                LoadReportStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing Manage Grading form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmManageGrading_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

                // Disable grade editing buttons
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
            // Add missing event handlers
        private void label1_Click(object sender, EventArgs e)
        {
            cmbStudentReport.Focus();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void lblManageCourses_Click(object sender, EventArgs e)
        {

        }

        private void tabCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabCourses.SelectedIndex)
            {
                case 0: // Add Grade tab
                    LoadCourses();
                    LoadStudents();
                    break;
                case 1: // Generate Report By Course tab
                    LoadReportCourses();
                    break;
                case 2: // Generate Report By Student tab
                    LoadReportStudents();
                    break;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            txtNotes.Focus();
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
    }
}

