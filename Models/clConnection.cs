using System.Data.SQLite;

namespace Models
{
    public class clConnection
    {
        private static readonly string ConnectionString = "Data Source=MediMax.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                // Create Users table if it doesn't exist
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY,
                    UserName TEXT NOT NULL UNIQUE,
                    Pass TEXT NOT NULL,
                    IsAdmin BOOL NOT NULL
                );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert default admin user if not exists
                string insertAdminQuery = @"
                INSERT INTO Users (UserName, Pass, IsAdmin)
                SELECT 'a', '000', 1
                WHERE NOT EXISTS (
                    SELECT 1 FROM Users WHERE UserName = 'a'
                );";

                using (var command = new SQLiteCommand(insertAdminQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
