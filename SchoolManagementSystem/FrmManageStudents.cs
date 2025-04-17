using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class FrmManageStudents : Form
    {
        private readonly string _userType;

        public FrmManageStudents(string userType)
        {
            InitializeComponent();
            _userType = userType;
            LoadStudents();
            SetupAccessControls();

            // Attach event handlers
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnSearch.Click += btnSearch_Click;

            this.FormClosing += FrmManageStudents_FormClosing;
        }
    

        private void LoadStudents()
        {
            try
            {
                string query = @"
                    SELECT StudentID, StudentNumber, FirstName, LastName, DateOfBirth, Gender,
                           Address, Email, Phone, EnrollmentDate
                    FROM Students";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Improve display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchStudent.Text.Trim();
                string query = @"
                    SELECT StudentID, StudentNumber, FirstName, LastName, DateOfBirth, Gender,
                           Address, Email, Phone, EnrollmentDate
                    FROM Students
                    WHERE StudentNumber LIKE @SearchTerm
                       OR FirstName LIKE @SearchTerm
                       OR LastName LIKE @SearchTerm
                       OR Email LIKE @SearchTerm";

                SqlParameter parameter = new SqlParameter("@SearchTerm", "%" + searchTerm + "%");
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameter);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAdd;
            ClearAddForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Student Number, First Name, Last Name).",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
            INSERT INTO Students (StudentNumber, FirstName, LastName, DateOfBirth, Gender, Address, Email, Phone, EnrollmentDate)
            VALUES (@StudentNumber, @FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Email, @Phone, @EnrollmentDate)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@StudentNumber", txtStudentNumber.Text),
            new SqlParameter("@FirstName", txtFirstName.Text),
            new SqlParameter("@LastName", txtLastName.Text),
            new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value),
            new SqlParameter("@Gender", cmbGender.SelectedItem?.ToString() ?? (object)DBNull.Value),
            new SqlParameter("@Address", txtAddress.Text ?? (object)DBNull.Value),
            new SqlParameter("@Email", txtEmail.Text ?? (object)DBNull.Value),
            new SqlParameter("@Phone", txtPhone.Text ?? (object)DBNull.Value),
            new SqlParameter("@EnrollmentDate", DateTime.Now)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters); // Void return, no rowsAffected check

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudents();
                tabControl1.SelectedTab = tabPageSearch;
                ClearAddForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                    PopulateFormFromSelectedRow(row);
                    tabControl1.SelectedTab = tabPageAdd;

                    btnSave.Click -= btnSave_Click;
                    btnSave.Click += (s, ev) =>
                    {
                        try
                        {
                            string query = @"
                        UPDATE Students
                        SET StudentNumber = @StudentNumber, FirstName = @FirstName, LastName = @LastName,
                            DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, Email = @Email,
                            Phone = @Phone
                        WHERE StudentID = @StudentID";

                            SqlParameter[] parameters = new SqlParameter[]
                            {
                        new SqlParameter("@StudentNumber", txtStudentNumber.Text),
                        new SqlParameter("@FirstName", txtFirstName.Text),
                        new SqlParameter("@LastName", txtLastName.Text),
                        new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value),
                        new SqlParameter("@Gender", cmbGender.SelectedItem?.ToString() ?? (object)DBNull.Value),
                        new SqlParameter("@Address", txtAddress.Text ?? (object)DBNull.Value),
                        new SqlParameter("@Email", txtEmail.Text ?? (object)DBNull.Value),
                        new SqlParameter("@Phone", txtPhone.Text ?? (object)DBNull.Value),
                        new SqlParameter("@StudentID", studentId)
                            };

                            DatabaseHelper.ExecuteNonQuery(query, parameters); // Void return, no rowsAffected check

                            MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudents();
                            tabControl1.SelectedTab = tabPageSearch;
                            ClearAddForm();

                            btnSave.Click -= btnSave_Click;
                            btnSave.Click += btnSave_Click;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error preparing update: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                        string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                        SqlParameter parameter = new SqlParameter("@StudentID", studentId);
                        DatabaseHelper.ExecuteNonQuery(query, parameter); // Void return, no rowsAffected check

                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAddForm();
            tabControl1.SelectedTab = tabPageSearch;
            btnSave.Click -= btnSave_Click; // Ensure correct handler is restored
            btnSave.Click += btnSave_Click;
        }

        private void ClearAddForm()
        {
            txtStudentNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void PopulateFormFromSelectedRow(DataGridViewRow row)
        {
            txtStudentNumber.Text = row.Cells["StudentNumber"].Value?.ToString();
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            dtpDateOfBirth.Value = row.Cells["DateOfBirth"].Value != null ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value) : DateTime.Now;
            cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmDashBoard(_userType));
        }

        private void btnMngStudents_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmManageStudents(_userType));
        }

        private void btnMngInstructors_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmManageInstructors(_userType));
        }

        private void btnMngCourses_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmManageCourse(_userType));
        }

        private void btnMngGradings_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmManageGrading(_userType));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void FrmManageStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NavigateToForm(Form form)
        {
            try
            {
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating to form: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void SetupAccessControls()
        {
            if (_userType == "Teacher")
            {
                btnMngStudents.Enabled = false;
                btnMngInstructors.Enabled = false;
                btnMngCourses.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
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