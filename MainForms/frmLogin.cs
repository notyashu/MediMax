using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using BasicControls;
using Models;
using Utilities;

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
                clDialog.msgBox("Please enter both Username and Password.", "E");
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
                        ? "SELECT Username FROM Users WHERE Username = @username AND Password = @password"
                        : "USE MediMaxDb; SELECT Username FROM Users WHERE Username = @username AND Password = @password";

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
                        clDialog.msgBox("Invalid username or password.", "E");
                    }
                }
            }
            catch (Exception ex)
            {
                clDialog.msgBox($"Login Error: {ex.Message}", "E");
            }
        }
    }
}