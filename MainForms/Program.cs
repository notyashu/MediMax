using System;
using System.Windows.Forms;
using Models;

namespace MainForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if connection settings exist
            if (!clConnection.LoadConnectionSettings())
            {
                // Open configuration wizard if no settings found
                using (var dbSetupForm = new frmDbSetup())
                {
                    if (dbSetupForm.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }

            // Proceed to main application or login
            Application.Run(new frmAddFirm());
        }
    }
}

