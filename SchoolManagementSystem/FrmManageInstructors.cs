using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class FrmManageInstructors : Form
    {
        private readonly string _userType; // Add this field

        // Modified constructor to accept userType
        public FrmManageInstructors(string userType)
        {
            InitializeComponent();
            _userType = userType;
            LoadInstructors();
            SetupAccessControls();

            // Attach event handlers
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnSearch.Click += btnSearch_Click;
        }

        // Load all instructors into the DataGridView on the Search tab
        private void LoadInstructors()
        {
            try
            {
                string query = @"
                    SELECT InstructorID, FirstName, LastName, Email, Phone, HireDate, Specialization
                    FROM Instructors";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message);
            }
        }

        // Search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchInstructors.Text.Trim();
                string query = @"
                    SELECT InstructorID, FirstName, LastName, Email, Phone, HireDate, Specialization
                    FROM Instructors
                    WHERE FirstName LIKE @SearchTerm
                       OR LastName LIKE @SearchTerm
                       OR Email LIKE @SearchTerm
                       OR Specialization LIKE @SearchTerm";

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    conn.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching instructors: " + ex.Message);
            }
        }

        // Add button click event (opens Add tab)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabInstructors.SelectedTab = tabPageAdd;
            ClearAddForm();
        }

        // Save button click event (adds a new instructor)
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please fill in all required fields (First Name, Last Name).");
                    return;
                }

                string query = @"
                    INSERT INTO Instructors (FirstName, LastName, Email, Phone, HireDate, Specialization)
                    VALUES (@FirstName, @LastName, @Email, @Phone, @HireDate, @Specialization)";

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@HireDate", dtpHireDate.Value);
                    cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text ?? (object)DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Instructor added successfully!");
                LoadInstructors(); // Refresh the instructor list
                tabInstructors.SelectedTab = tabPageSearch; // Return to Search tab
                ClearAddForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding instructor: " + ex.Message);
            }
        }

        // Update button click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Populate form with selected instructor's data
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int instructorId = Convert.ToInt32(row.Cells["InstructorID"].Value);
                    PopulateFormFromSelectedRow(row);

                    // Switch to Add tab for editing
                    tabInstructors.SelectedTab = tabPageAdd;

                    // Save updates when Save button is clicked (temporary event handler swap)
                    btnSave.Click -= btnSave_Click; // Remove add handler
                    btnSave.Click += (s, ev) =>
                    {
                        try
                        {
                            string query = @"
                                UPDATE Instructors
                                SET FirstName = @FirstName, LastName = @LastName, Email = @Email,
                                    Phone = @Phone, HireDate = @HireDate, Specialization = @Specialization
                                WHERE InstructorID = @InstructorID";

                            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@HireDate", dtpHireDate.Value);
                                cmd.Parameters.AddWithValue("@Specialization", txtSpecialization.Text ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@InstructorID", instructorId);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Instructor updated successfully!");
                            LoadInstructors();
                            tabInstructors.SelectedTab = tabPageSearch;
                            ClearAddForm();
                            btnSave.Click -= btnSave_Click; // Remove temporary update handler
                            btnSave.Click += btnSave_Click; // Restore add handler
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating instructor: " + ex.Message);
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error preparing update: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an instructor to update.");
            }
        }

        // Delete button click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this instructor?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int instructorId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["InstructorID"].Value);
                        string query = "DELETE FROM Instructors WHERE InstructorID = @InstructorID";

                        using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@InstructorID", instructorId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Instructor deleted successfully!");
                        LoadInstructors();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting instructor: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an instructor to delete.");
            }
        }

        // Cancel button click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAddForm();
            tabInstructors.SelectedTab = tabPageSearch;
            btnSave.Click -= btnSave_Click; // Ensure correct handler is restored
            btnSave.Click += btnSave_Click;
        }

        // Clear the Add Instructor form
        private void ClearAddForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            dtpHireDate.Value = DateTime.Now;
            txtSpecialization.Clear();
        }

        // Populate form fields from selected DataGridView row
        private void PopulateFormFromSelectedRow(DataGridViewRow row)
        {
            txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
            txtLastName.Text = row.Cells["LastName"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            dtpHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
            txtSpecialization.Text = row.Cells["Specialization"].Value?.ToString();
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

                // Disable editing buttons (Add, Update, Delete)
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            // Handle the click event for lblAddress if needed
        }

        private void lblHireDate_Click(object sender, EventArgs e)
        {
            // Handle the click event for lblHireDate if needed
        }

        private void tabInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected tab changes in tabInstructors
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
