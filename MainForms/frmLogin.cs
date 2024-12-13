using System;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BasicControls;
using Models;

namespace MainForms
{
    public partial class frmLogin : frm
    {
        public frmLogin()
        {
            InitializeComponent();
            clInteractDb.InitializeDatabase();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check credentials
            try
            {
                using (var connection = clConnection.GetConnection())
                {
                    connection.Open();

                    // Prepare query based on database type
                    string query = clConnection.CurrentDatabaseType == DatabaseType.SQLite
                        ? "SELECT UserName FROM Users WHERE UserName = @username AND Pass = @password"
                        : "SELECT UserName FROM Users WHERE UserName = @username AND Pass = @password";

                    IDbCommand cmd;
                    IDataParameter usernameParam, passwordParam;

                    if (clConnection.CurrentDatabaseType == DatabaseType.SQLite)
                    {
                        cmd = new SQLiteCommand(query, (SQLiteConnection)connection);
                        usernameParam = new SQLiteParameter("@username", username);
                        passwordParam = new SQLiteParameter("@password", password);
                    }
                    else
                    {
                        cmd = new SqlCommand(query, (SqlConnection)connection);
                        usernameParam = new SqlParameter("@username", username);
                        passwordParam = new SqlParameter("@password", password);
                    }

                    cmd.Parameters.Add(usernameParam);
                    cmd.Parameters.Add(passwordParam);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // User is authenticated
                        string loggedInUser = result.ToString();
                        this.Hide();

                        // Navigate to the main form
                        var MainForm = new frmMain();
                        MainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}