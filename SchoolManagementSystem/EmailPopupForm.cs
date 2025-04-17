using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem
{
    public partial class EmailPopupForm: Form
    {
        private readonly string _userType;
        public EmailPopupForm()
        {
            InitializeComponent();
        }

        private void EmailPopupForm_Load(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                cmbStudent.DataSource = context.Students
                    .Select(s => new
                    {
                        s.StudentID,
                        FullName = s.FirstName + " " + s.LastName
                    })
                    .ToList();

                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "StudentID";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            int studentId = Convert.ToInt32(cmbStudent.SelectedValue);

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter the recipient's email.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string pdfPath = PDFReport.GenerateStudentReport(studentId, false);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("schoolmanagement487@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Your Grade Report";
                mail.Body = "Please find your grade report attached.";
                mail.Attachments.Add(new Attachment(pdfPath));

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("schoolmanagement487@gmail.com", "ywtjqlkbldrvxmjf");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPdfPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

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

