using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using Utilities;

namespace Models
{
    public enum DatabaseType
    {
        SQLite,
        SQLExpress
    }

    public enum AuthenticationType
    {
        WindowsAuthentication,
        SqlAuthentication
    }

    public class clConnection
    {
        private static DatabaseType _currentDbType;
        private static AuthenticationType _currentAuthType;
        private static string _connectionString;

        public static DatabaseType CurrentDatabaseType => _currentDbType;
        public static AuthenticationType CurrentAuthenticationType => _currentAuthType;
        public static string CurrentConnectionString => _connectionString;

        public static void SaveConnectionSettings(
            DatabaseType dbType,
            AuthenticationType authType,
            string connectionString)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Remove existing settings
                config.AppSettings.Settings.Remove("DatabaseType");
                config.AppSettings.Settings.Remove("AuthenticationType");
                config.AppSettings.Settings.Remove("ConnectionString");

                // Add new settings
                config.AppSettings.Settings.Add("DatabaseType", dbType.ToString());
                config.AppSettings.Settings.Add("AuthenticationType", authType.ToString());
                config.AppSettings.Settings.Add("ConnectionString", connectionString);

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                // Update static variables
                _currentDbType = dbType;
                _currentAuthType = authType;
                _connectionString = connectionString;
            }
            catch (Exception ex)
            {
                clDialog.msgBox($"Error saving connection settings: {ex.Message}", "E");
            }
        }

        public static bool LoadConnectionSettings()
        {
            try
            {
                var dbTypeString = ConfigurationManager.AppSettings["DatabaseType"];
                var authTypeString = ConfigurationManager.AppSettings["AuthenticationType"];
                _connectionString = ConfigurationManager.AppSettings["ConnectionString"];

                if (!string.IsNullOrEmpty(dbTypeString) &&
                    Enum.TryParse(dbTypeString, out DatabaseType parsedDbType) &&
                    !string.IsNullOrEmpty(authTypeString) &&
                    Enum.TryParse(authTypeString, out AuthenticationType parsedAuthType))
                {
                    _currentDbType = parsedDbType;
                    _currentAuthType = parsedAuthType;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static IDbConnection GetConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection not configured");
            }

            switch (_currentDbType)
            {
                case DatabaseType.SQLite:
                    return new SQLiteConnection(_connectionString);
                case DatabaseType.SQLExpress:
                    return new SqlConnection(_connectionString);
                default:
                    throw new NotSupportedException("Unsupported database type");
            }
        }

        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Additional validation for SQL Server
                    if (_currentDbType == DatabaseType.SQLExpress)
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "SELECT 1";
                            command.ExecuteScalar();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Connection Test Failed:\n Error: {ex.Message}\n" , "E");
                return false;
            }
        }

        public static string[] DetectSqlInstances()
        {
            HashSet<string> instances = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                // WMI detection
                try
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                        "SELECT * FROM Win32_Service WHERE (Name LIKE 'MSSQL$%' OR Name = 'MSSQLSERVER')");

                    foreach (ManagementObject service in searcher.Get())
                    {
                        string serviceName = service["Name"].ToString();
                        string instanceName = serviceName == "MSSQLSERVER"
                            ? "MSSQLSERVER"
                            : serviceName.Substring(6);  // Strip 'MSSQL$' prefix

                        string formattedInstance = $@"localhost\{instanceName}";
                        instances.Add(formattedInstance);
                        instances.Add($@".\{instanceName}");
                    }
                }
                catch (Exception wmiEx)
                {
                    Console.WriteLine($"WMI-based instance detection failed: {wmiEx.Message}");
                }

                // Add some default instances
                instances.UnionWith(new[]
                {
                    @".\SQLEXPRESS",
                    @"(localdb)\MSSQLLocalDB",
                    @"localhost\SQLEXPRESS",
                    @"MSSQLSERVER"
                });

                return instances.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Comprehensive SQL instance detection failed: {ex.Message}");
                return Array.Empty<string>();
            }
        }
    }
}