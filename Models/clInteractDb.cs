using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using Utilities;

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
                clDialog.msgBox($"Database Initialization Error: {ex.Message}", "E");
            }
        }

        private static void InitializeSQLiteDatabase(IDbConnection connection)
        {
            string enableForeignKeys = "PRAGMA foreign_keys = ON;";

            string createUsersTable = @"
            CREATE TABLE IF NOT EXISTS Users (
                UserId INTEGER PRIMARY KEY,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                IsAdmin BOOLEAN NOT NULL
            );";

            string createConfigsTable = @"
            CREATE TABLE IF NOT EXISTS Configs (
                Id INTEGER PRIMARY KEY,
                nVal REAL,
                cVal TEXT,
                sVal TEXT,
                dVal DATE,
                dtVal DATETIME,
                bVal BOOLEAN
            );";

            string createFirmsTable = @"
            CREATE TABLE IF NOT EXISTS Firms (
                FirmId INTEGER PRIMARY KEY,
                FirmType INTEGER,
                Name TEXT,
                CP TEXT,
                Add1 TEXT,
                Add2 TEXT,
                City TEXT,
                StateId INTEGER,
                Pin TEXT,
                Std INTEGER,
                LandLine1 INTEGER,
                LandLine2 INTEGER,
                MobNo1 INTEGER,
                MobNo2 INTEGER,
                Email TEXT,
                Website TEXT,
                Bank TEXT,
                IFSC TEXT,
                AcNo TEXT,
                GSTIN TEXT,
                RegType TEXT,
                PAN TEXT,
                TAN TEXT,
                CIN TEXT,
                WeightM TEXT,
                WMExp DATE,
                Labour TEXT,
                LabExp DATE,
                DLNo1 TEXT,
                DLExp1 DATE,
                DLNo2 TEXT,
                DLExp2 DATE,
                WarnDays INTEGER
            );";

            string createPeriodTable = @"
            CREATE TABLE IF NOT EXISTS Period (
                FirmId INTEGER,
                FromDate DATE,
                ToDate DATE,
                FOREIGN KEY (FirmId) REFERENCES Firms(FirmId)
            );";

            string insertAdminQuery = @"
            INSERT OR IGNORE INTO Users (UserId, Username, Password, IsAdmin)
            VALUES (1, 'a', '000', 1);";

            ExecuteSQLiteCommand(connection, enableForeignKeys);
            ExecuteSQLiteCommand(connection, createUsersTable);
            ExecuteSQLiteCommand(connection, createConfigsTable);
            ExecuteSQLiteCommand(connection, createFirmsTable);
            ExecuteSQLiteCommand(connection, createPeriodTable);
            ExecuteSQLiteCommand(connection, insertAdminQuery);
        }

        private static void InitializeSQLExpressDatabase(IDbConnection connection)
        {
            string createDatabaseQuery = @"
            IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'MediMaxDb')
            CREATE DATABASE MediMaxDb;";

            string createUsersTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
            CREATE TABLE Users (
                UserId PRIMARY KEY,
                Username VARCHAR(20) NOT NULL UNIQUE,
                Password VARCHAR(20) NOT NULL,
                IsAdmin BIT NOT NULL
            );";

            string changeDatabase = "USE MediMaxDb;";

            string createConfigsTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Configs' AND xtype='U')
            CREATE TABLE Configs (
                Id INT PRIMARY KEY,
                nVal DECIMAL(18,2),
                cVal VARCHAR(1),
                sVal VARCHAR(100),
                dVal DATE,
                dtVal DATETIME,
                bVal BIT
            );";

            string createFirmsTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Firms' AND xtype='U')
            CREATE TABLE Firms (
                FirmId INT PRIMARY KEY,
                FirmType SMALLINT NOT NULL,
                Name VARCHAR(100) NOT NULL,
                CP VARCHAR(50) NOT NULL,
                Add1 VARCHAR(100) NOT NULL,
                Add2 VARCHAR(100),
                City VARCHAR(50) NOT NULL,
                StateId SMALLINT NOT NULL,
                Pin VARCHAR(10) NOT NULL,
                Std SMALLINT NOT NULL,
                LandLine1 SMALLINT NOT NULL,
                LandLine2 SMALLINT,
                MobNo1 SMALLINT NOT NULL,
                MobNo2 SMALLINT,
                Email VARCHAR(50) NOT NULL,
                Website VARCHAR(100),
                Bank VARCHAR(50) NOT NULL,
                IFSC VARCHAR(20) NOT NULL,
                AcNo VARCHAR(20) NOT NULL,
                GSTIN VARCHAR(20) NOT NULL,
                RegType VARCHAR(1) NOT NULL,
                PAN VARCHAR(20) NOT NULL,
                TAN VARCHAR(20) NOT NULL,
                CIN VARCHAR(20) NOT NULL,
                WeightM VARCHAR(50) NOT NULL,
                WMExp DATE NOT NULL,
                Labour VARCHAR(50) NOT NULL,
                LabExp DATE NOT NULL,
                DLNo1 VARCHAR(50) NOT NULL,
                DLExp1 DATE NOT NULL,
                DLNo2 VARCHAR(50) NOT NULL,
                DLExp2 DATE NOT NULL,
                WarnDays SMALLINT NOT NULL
            );";

            string createPeriodTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Period' AND xtype='U')
            CREATE TABLE Period (
                FirmId INT,
                FromDate DATE,
                ToDate DATE,
                FOREIGN KEY (FirmId) REFERENCES Firms(FirmId)
            );";

            string insertAdminQuery = @"
            IF NOT EXISTS (SELECT 1 FROM Users WHERE UserName = 'a')
            INSERT INTO Users (UserId, Username, Password, IsAdmin)
            VALUES (1, 'a', '000', 1);";

            ExecuteSQLExpressCommand(connection, createDatabaseQuery);
            ExecuteSQLExpressCommand(connection, changeDatabase);
            ExecuteSQLExpressCommand(connection, createUsersTable);
            ExecuteSQLExpressCommand(connection, createConfigsTable);
            ExecuteSQLExpressCommand(connection, createFirmsTable);
            ExecuteSQLExpressCommand(connection, createPeriodTable);
            ExecuteSQLExpressCommand(connection, insertAdminQuery);

        }

        private static void ExecuteSQLiteCommand(IDbConnection connection, string query)
        {
            using (var command = new SQLiteCommand(query, (SQLiteConnection)connection))
                command.ExecuteNonQuery();
        }

        private static void ExecuteSQLExpressCommand(IDbConnection connection, string query)
        {
            using (var command = new SqlCommand(query, (SqlConnection)connection))
                command.ExecuteNonQuery();
        }
    }
}
