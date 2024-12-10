using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicControls;

namespace MediMax
{
    public partial class frmLogin : frm
    {
        public frmLogin()
        {
            InitializeComponent();
            // Initialize the database
            Models.clConnection.InitializeDatabase();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtBox1.Text.Trim();
            string password = txtBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check credentials
            using (var connection = Models.clConnection.GetConnection())
            {
                string query = "SELECT UserName FROM Users WHERE UserName = @username AND Pass = @password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // User is authenticated
                        string loggedInUser = result.ToString();

                        MessageBox.Show($"Hello {loggedInUser}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        //Navigate to the main form
                        var MainForm = new frmMain();
                        MainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
