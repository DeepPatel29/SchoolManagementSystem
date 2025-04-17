//using System;
//using System.Data;
//using System.Security.Cryptography;
//using System.Text;
//using System.Windows.Forms;
//using Microsoft.Data.SqlClient;
//using SchoolManagementSystem.Models;
//using SchoolManagementSystem;
//using System.Linq;

//namespace SchoolManagementSystem
//{
//    public partial class frmLogIn : Form
//    {
//        public frmLogIn()
//        {
//            InitializeComponent();
//        }

//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text.Trim();
//            string password = txtPassword.Text.Trim();

//            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
//            {
//                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            string hashedPassword = HashPassword(password);

//            using (var context = new SchoolContext())
//            {
//                var user = context.Users
//                    .FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);

//                if (user != null)
//                {
//                    user.LastLogin = DateTime.Now;
//                    context.SaveChanges();

//                    LogUserLogin(user.UserID);

//                    //DashboardForm dashboard = new DashboardForm(user);
//                    //dashboard.Show();
//                    //this.Hide();
//                }
//                else
//                {
//                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }

//            //string query = "SELECT UserID, UserType FROM Users WHERE Username = @Username AND Password = @Password";
//            //SqlParameter[] parameters = new SqlParameter[]
//            //{
//            //    new SqlParameter("@Username", username),
//            //    new SqlParameter("@Password", hashedPassword)
//            //};

//            //DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

//            //if (dt.Rows.Count > 0)
//            //{
//            //    string userType = dt.Rows[0]["UserType"].ToString();
//            //    int userId = Convert.ToInt32(dt.Rows[0]["UserID"]);

//            //    LogUserLogin(userId);

//            //    this.Hide();
//            //    FrmDashBoard dashboard = new FrmDashBoard(userType);
//            //    dashboard.Show();
//            //}
//            //else
//            //{
//            //    MessageBox.Show("Invalid username or password.");
//            //}
//        }

//        // SHA256 Hashing Utility
//        public static string HashPassword(string password)
//        {
//            using (SHA256 sha = SHA256.Create())
//            {
//                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
//                return BitConverter.ToString(hash).Replace("-", "").ToLower();
//            }
//        }

//        //  Log Login Event
//        private void LogUserLogin(int userId)
//        {
//            string query = "INSERT INTO UserLogs (UserID, Action) VALUES (@UserID, 'Login')";
//            SqlParameter param = new SqlParameter("@UserID", userId);
//            DatabaseHelper.ExecuteNonQuery(query, param);
//        }

//        private void txtUsername_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void txtPassword_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void btnLogIn_Click(object sender, EventArgs e)
//        {

//        }

//        private void frmLogIn_Load(object sender, EventArgs e)
//        {

//        }

//    }
//}

using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                var user = context.Users
                    .FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    user.LastLogin = DateTime.Now;
                    context.SaveChanges();

                    FrmDashBoard dashboard = new FrmDashBoard(user.UserType);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

    }
}
