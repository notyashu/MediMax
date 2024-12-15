using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using BasicControls;
using Models;
using Utilities;

namespace MainForms
{
    public partial class frmDbSetup : frm
    {
        public frmDbSetup()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            PopulateSqlInstances();
            rbSQLite.Checked = true;
            rbWindowsAuth.Checked = true;
        }

        private void PopulateSqlInstances()
        {
            string[] instances = clConnection.DetectSqlInstances();
            cboSqlInstances.Items.Clear();
            cboSqlInstances.Items.AddRange(instances);

            if (instances.Length > 0)
                cboSqlInstances.SelectedIndex = 0;
        }

        private void rbSQLite_CheckedChanged(object sender, EventArgs e)
        {
            pnlSQLExpress.Enabled = !rbSQLite.Checked;
            if (rbSQLite.Checked)
            {
                txtSQLitePath.Text = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "MediMax", "medimaxdb.sqlite");
            }
        }
        private void rbSQLExpress_CheckedChanged(object sender, EventArgs e)
        {
            pnlSQLExpress.Enabled = rbSQLExpress.Checked;
        }

        private void rbSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = rbSqlAuth.Checked;
            txtPassword.Enabled = rbSqlAuth.Checked;
        }
        private void rbWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = !rbWindowsAuth.Checked;
            txtPassword.Enabled = !rbWindowsAuth.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "SQLite Database Files (*.sqlite)|*.sqlite";
                saveFileDialog.Title = "Select SQLite Database Location";
                saveFileDialog.FileName = "medimaxdb.sqlite";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSQLitePath.Text = saveFileDialog.FileName;
                }
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString;
            DatabaseType dbType;
            AuthenticationType authType;

            if (rbSQLite.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSQLitePath.Text))
                {
                    clDialog.msgBox("Please select a SQLite database path.", "E");
                    return;
                }

                // Ensure directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(txtSQLitePath.Text));

                connectionString = $"Data Source={txtSQLitePath.Text};Version=3;";
                dbType = DatabaseType.SQLite;
                authType = AuthenticationType.WindowsAuthentication; // Not applicable for SQLite
            }
            else
            {
                if (string.IsNullOrWhiteSpace(cboSqlInstances.Text))
                {
                    clDialog.msgBox("Please select SQL instance.", "E");
                    return;
                }

                // Determine authentication type
                if (rbWindowsAuth.Checked)
                {
                    connectionString = new SqlConnectionStringBuilder
                    {
                        DataSource = cboSqlInstances.Text,
                        InitialCatalog = "master",
                        IntegratedSecurity = true
                    }.ConnectionString;

                    authType = AuthenticationType.WindowsAuthentication;
                }
                else // SQL Authentication
                {
                    if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                        string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        clDialog.msgBox("Please enter SQL authentication credentials.", "E");
                        return;
                    }

                    connectionString = new SqlConnectionStringBuilder
                    {
                        DataSource = cboSqlInstances.Text,
                        InitialCatalog = "master",
                        UserID = txtUsername.Text,
                        Password = txtPassword.Text,
                        IntegratedSecurity = false
                    }.ConnectionString;

                    authType = AuthenticationType.SqlAuthentication;
                }

                dbType = DatabaseType.SQLExpress;
            }

            try
            {
                // Save connection settings
                clConnection.SaveConnectionSettings(dbType, authType, connectionString);

                // Test connection
                if (clConnection.TestConnection())
                {
                    // Initialize database (ensure this method exists and is appropriate)
                    clInteractDb.InitializeDatabase();

                    clDialog.msgBox("Connection successful and database initialized!", "I");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    clDialog.msgBox("Connection test failed. Please check your connection details.", "E");
                }
            }
            catch (Exception ex)
            {
                clDialog.msgBox($"Detailed Error: {ex.Message}\n{ex.StackTrace}", "E");
            }
        }

    }
}