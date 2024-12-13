using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Models
{
    public class clInteractDb
    {
        public static void InitializeDatabase()
        {
            try
            {
                using (var connection = clConnection.GetConnection())
                {
                    connection.Open();

                    if (clConnection.CurrentDatabaseType == DatabaseType.SQLite)
                    {
                        InitializeSQLiteDatabase(connection);
                    }
                    else if (clConnection.CurrentDatabaseType == DatabaseType.SQLExpress)
                    {
                        InitializeSQLExpressDatabase(connection);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Initialization Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void InitializeSQLiteDatabase(IDbConnection connection)
        {
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Users (
                UserId INTEGER PRIMARY KEY,
                UserName TEXT NOT NULL UNIQUE,
                Pass TEXT NOT NULL,
                IsAdmin BOOL NOT NULL
            );";

            string insertAdminQuery = @"
            INSERT OR IGNORE INTO Users (UserName, Pass, IsAdmin)
            VALUES ('a', '000', 1);";

            using (var command = new SQLiteCommand(createTableQuery, (SQLiteConnection)connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new SQLiteCommand(insertAdminQuery, (SQLiteConnection)connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void InitializeSQLExpressDatabase(IDbConnection connection)
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
            CREATE TABLE Users (
                UserId INT IDENTITY(1,1) PRIMARY KEY,
                UserName NVARCHAR(50) NOT NULL UNIQUE,
                Pass NVARCHAR(50) NOT NULL,
                IsAdmin BIT NOT NULL
            );";

            string insertAdminQuery = @"
            IF NOT EXISTS (SELECT 1 FROM Users WHERE UserName = 'a')
            INSERT INTO Users (UserName, Pass, IsAdmin)
            VALUES ('a', '000', 1);";

            using (var command = new SqlCommand(createTableQuery, (SqlConnection)connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new SqlCommand(insertAdminQuery, (SqlConnection)connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}