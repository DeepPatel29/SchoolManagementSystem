using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class FrmManageCourse : Form
    {
        private readonly string _userType; // Add this field

        // Modified constructor to accept userType
        public FrmManageCourse(string userType)
        {
            InitializeComponent();
            _userType = userType; // Store user type
            LoadInstructors();
            LoadCourses();
            LoadCoursesForEnrollment();
            cmbSelectCourse.SelectedIndexChanged += cmbSelectCourse_SelectedIndexChanged;
            SetupAccessControls(); // Call access control setup

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnSearch.Click += btnSearch_Click;
            btnAssignStudent.Click += btnAssignStudent_Click;
            btnRemoveStudent.Click += btnRemoveStudent_Click;

        }

        private void LoadInstructors()
        {
            try
            {
                string query = "SELECT InstructorID, FirstName + ' ' + LastName AS InstructorName FROM Instructors";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbInstructors.DataSource = dt;
                cmbInstructors.DisplayMember = "InstructorName";
                cmbInstructors.ValueMember = "InstructorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message);
            }
        }

        // Load all courses into the DataGridView on the Search tab
        private void LoadCourses()
        {
            try
            {
                string query = @"
                    SELECT c.CourseID, c.CourseName, c.Description, c.CreditHours, c.MaxStudents, c.RoomNumber,
                           c.Schedule, i.FirstName + ' ' + i.LastName AS InstructorName
                    FROM Courses c
                    LEFT JOIN Instructors i ON c.InstructorID = i.InstructorID";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        // Load courses into the enrollment ComboBox
        private void LoadCoursesForEnrollment()
        {
            try
            {
                string query = "SELECT CourseID, CourseName FROM Courses";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbSelectCourse.DataSource = dt;
                cmbSelectCourse.DisplayMember = "CourseName";
                cmbSelectCourse.ValueMember = "CourseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses for enrollment: " + ex.Message);
            }
        }

        // Search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchStudent.Text.Trim();
                string query = @"
                    SELECT c.CourseID, c.CourseName, c.Description, c.CreditHours, c.MaxStudents, c.RoomNumber,
                           c.Schedule, i.FirstName + ' ' + i.LastName AS InstructorName
                    FROM Courses c
                    LEFT JOIN Instructors i ON c.InstructorID = i.InstructorID
                    WHERE c.CourseName LIKE @SearchTerm OR c.Description LIKE @SearchTerm";

                SqlParameter parameter = new SqlParameter("@SearchTerm", "%" + searchTerm + "%");
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameter);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching courses: " + ex.Message);
            }
        }

        // Add button click event (opens Add tab)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabCourses.SelectedTab = tabPageAdd;
            ClearAddForm();
        }

        // Save button click event (adds a new course)
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(txtCourseName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Course Name, Description).");
                    return;
                }

                string query = @"
                    INSERT INTO Courses (CourseName, Description, CreditHours, MaxStudents, RoomNumber, InstructorID, Schedule)
                    VALUES (@CourseName, @Description, @CreditHours, @MaxStudents, @RoomNumber, @InstructorID, @Schedule)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CourseName", txtCourseName.Text),
                    new SqlParameter("@Description", txtDescription.Text),
                    new SqlParameter("@CreditHours", numericUpDown1.Value),
                    new SqlParameter("@MaxStudents", numMaxStudents.Value),
                    new SqlParameter("@RoomNumber", txtRoomNumber.Text),
                    new SqlParameter("@InstructorID", cmbInstructors.SelectedValue ?? (object)DBNull.Value),
                    new SqlParameter("@Schedule", txtSchedule.Text)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Course added successfully!");
                LoadCourses(); // Refresh the course list
                tabCourses.SelectedTab = tabPageSearch; // Return to Search tab
                ClearAddForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        // Update button click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);
                    string query = @"
                        UPDATE Courses
                        SET CourseName = @CourseName, Description = @Description, CreditHours = @CreditHours,
                            MaxStudents = @MaxStudents, RoomNumber = @RoomNumber, InstructorID = @InstructorID,
                            Schedule = @Schedule
                        WHERE CourseID = @CourseID";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@CourseName", txtCourseName.Text),
                        new SqlParameter("@Description", txtDescription.Text),
                        new SqlParameter("@CreditHours", numericUpDown1.Value),
                        new SqlParameter("@MaxStudents", numMaxStudents.Value),
                        new SqlParameter("@RoomNumber", txtRoomNumber.Text),
                        new SqlParameter("@InstructorID", cmbInstructors.SelectedValue ?? (object)DBNull.Value),
                        new SqlParameter("@Schedule", txtSchedule.Text),
                        new SqlParameter("@CourseID", courseId)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Course updated successfully!");
                    LoadCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating course: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.");
            }
        }

        // Delete button click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);
                        string query = "DELETE FROM Courses WHERE CourseID = @CourseID";

                        SqlParameter parameter = new SqlParameter("@CourseID", courseId);
                        DatabaseHelper.ExecuteNonQuery(query, parameter);

                        MessageBox.Show("Course deleted successfully!");
                        LoadCourses();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting course: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        // Cancel button click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAddForm();
            tabCourses.SelectedTab = tabPageSearch;
        }

        // Clear the Add Course form
        private void ClearAddForm()
        {
            txtCourseName.Clear();
            txtDescription.Clear();
            numericUpDown1.Value = 1;
            numMaxStudents.Value = 1;
            txtRoomNumber.Clear();
            cmbInstructors.SelectedIndex = -1;
        }

        // Load students when a course is selected in the enrollment tab
        private void cmbSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectCourse.SelectedValue != null)
            {
                LoadAvailableStudents();
                LoadEnrolledStudents();
            }
        }

        // Load available students (not enrolled in the selected course)
        private void LoadAvailableStudents()
        {
            try
            {
                int courseId = Convert.ToInt32(cmbSelectCourse.SelectedValue);
                string query = @"
                    SELECT s.StudentID, s.StudentNumber, s.FirstName + ' ' + s.LastName AS StudentName
                    FROM Students s
                    WHERE s.StudentID NOT IN (
                        SELECT sc.StudentID
                        FROM StudentCourses sc
                        WHERE sc.CourseID = @CourseID
                    )";

                SqlParameter parameter = new SqlParameter("@CourseID", courseId);
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameter);
                dgvAvailableStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available students: " + ex.Message);
            }
        }

        // Load enrolled students for the selected course
        private void LoadEnrolledStudents()
        {
            try
            {
                int courseId = Convert.ToInt32(cmbSelectCourse.SelectedValue);
                string query = @"
                    SELECT s.StudentID, s.StudentNumber, s.FirstName + ' ' + s.LastName AS StudentName
                    FROM Students s
                    INNER JOIN StudentCourses sc ON s.StudentID = sc.StudentID
                    WHERE sc.CourseID = @CourseID";

                SqlParameter parameter = new SqlParameter("@CourseID", courseId);
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameter);
                dgvEnrolledStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading enrolled students: " + ex.Message);
            }
        }

        // Assign student to course
        private void btnAssignStudent_Click(object sender, EventArgs e)
        {
            if (dgvAvailableStudents.SelectedRows.Count > 0)
            {
                try
                {
                    int studentId = Convert.ToInt32(dgvAvailableStudents.SelectedRows[0].Cells["StudentID"].Value);
                    int courseId = Convert.ToInt32(cmbSelectCourse.SelectedValue);
                    string query = "INSERT INTO StudentCourses (StudentID, CourseID) VALUES (@StudentID, @CourseID)";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentID", studentId),
                        new SqlParameter("@CourseID", courseId)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Student assigned successfully!");
                    LoadAvailableStudents();
                    LoadEnrolledStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error assigning student: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to assign.");
            }
        }

        // Remove student from course
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dgvEnrolledStudents.SelectedRows.Count > 0)
            {
                try
                {
                    int studentId = Convert.ToInt32(dgvEnrolledStudents.SelectedRows[0].Cells["StudentID"].Value);
                    int courseId = Convert.ToInt32(cmbSelectCourse.SelectedValue);
                    string query = "DELETE FROM StudentCourses WHERE StudentID = @StudentID AND CourseID = @CourseID";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentID", studentId),
                        new SqlParameter("@CourseID", courseId)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Student removed successfully!");
                    LoadAvailableStudents();
                    LoadEnrolledStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing student: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
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

        private void SetupAccessControls()
        {
            if (_userType == "Teacher")
            {
                // Disable navigation buttons
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

                // Disable editing buttons (Add, Update, Delete)
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAssignStudent.Enabled = false;
                btnRemoveStudent.Enabled = false;
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
    }
}
