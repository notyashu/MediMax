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

            string createUsersTable = clDatatypes.ConvertQuery(@"
            CREATE TABLE IF NOT EXISTS Users (
                UserId _SI_ PRIMARY KEY,
                Username _V_[20] UNIQUE,
                Password _V_[20],
                IsAdmin _B_
            );");

            string createConfigsTable = clDatatypes.ConvertQuery(@"
            CREATE TABLE IF NOT EXISTS Configs (
                Id _I_ PRIMARY KEY,
                nVal _N_,
                cVal _V_,
                sVal _V_,
                dVal _D_,
                dtVal _DT_,
                bVal _B_
            );");

            string createFirmsTable = clDatatypes.ConvertQuery(@"
            CREATE TABLE IF NOT EXISTS Firms (
                FirmId _SI_ PRIMARY KEY,
                FirmType _SI_,
                Name _V_[100],
                CP _V_[50],
                AddA _V_[100],
                AddB _V_[100],
                City _V_[50],
                StateId _V_[2],
                Pin _V_[10],
                Std _SI_,
                LandLineA _SI_,
                LandLineB _SI_,
                MobNoA _SI_,
                MobNoB _SI_,
                Email _V_[50],
                Website _V_[100],
                Bank _V_[50],
                IFSC _V_[20],
                AcNo _V_[20],
                GSTIN _V_[20],
                RegType _V_[1],
                PAN _V_[20],
                TAN _V_[20],
                CIN _V_[20],
                WeightM _V_[50],
                WMExp _D_,
                Labour _V_[50],
                LabExp _D_,
                DLNoA _V_[50],
                DLExpA _D_,
                DLNoB _V_[50],
                DLExpB _D_,
                WarnDays _SI_
            );");

            string createPeriodTable = clDatatypes.ConvertQuery(@"
            CREATE TABLE IF NOT EXISTS Period (
                FirmId _SI_,
                FromDate _D_,
                ToDate _D_,
                FOREIGN KEY (FirmId) REFERENCES Firms(FirmId)
            );");

            string createStatesTable = clDatatypes.ConvertQuery(@"
            CREATE TABLE IF NOT EXISTS States (
                StateId _V_[2] PRIMARY KEY,
                State _V_[50] UNIQUE
            );");

            string insertAdminQuery = @"
            INSERT OR REPLACE INTO Users (UserId, Username, Password, IsAdmin)
            VALUES (1, 'a', '000', 1);";

            string insertStateQuery = @"
            INSERT OR IGNORE INTO States (StateId, State)
            VALUES
                ('01', 'Jammu and Kashmir'),
                ('02', 'Himachal Pradesh'),
                ('03', 'Punjab'),
                ('04', 'Chandigarh'),
                ('05', 'Uttarakhand'),
                ('06', 'Haryana'),
                ('07', 'Delhi'),
                ('08', 'Rajasthan'),
                ('09', 'Uttar Pradesh'),
                ('10', 'Bihar'),
                ('11', 'Sikkim'),
                ('12', 'Arunachal Pradesh'),
                ('13', 'Nagaland'),
                ('14', 'Manipur'),
                ('15', 'Mizoram'),
                ('16', 'Tripura'),
                ('17', 'Meghalaya'),
                ('18', 'Assam'),
                ('19', 'West Bengal'),
                ('20', 'Jharkhand'),
                ('21', 'Orissa'),
                ('22', 'Chhattisgarh'),
                ('23', 'Madhya Pradesh'),
                ('24', 'Gujarat'),
                ('25', 'Daman and Diu'),
                ('26', 'Dadra and Nagar Haveli'),
                ('27', 'Maharashtra'),
                ('28', 'Andhra Pradesh (Old)'),
                ('29', 'Karnataka'),
                ('30', 'Goa'),
                ('31', 'Lakshadweep'),
                ('32', 'Kerala'),
                ('33', 'Tamil Nadu'),
                ('34', 'Puducherry'),
                ('35', 'Andaman and Nicobar'),
                ('36', 'Telengana'),
                ('37', 'Andhra Pradesh (New)');";

            ExecuteSQLiteCommand(connection, enableForeignKeys);
            ExecuteSQLiteCommand(connection, createUsersTable);
            ExecuteSQLiteCommand(connection, createConfigsTable);
            ExecuteSQLiteCommand(connection, createFirmsTable);
            ExecuteSQLiteCommand(connection, createPeriodTable);
            ExecuteSQLiteCommand(connection, createStatesTable);
            ExecuteSQLiteCommand(connection, insertAdminQuery);
            ExecuteSQLiteCommand(connection, insertStateQuery);
        }

        private static void InitializeSQLExpressDatabase(IDbConnection connection)
        {
            string createDatabaseQuery = @"
            IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'MediMaxDb')
            CREATE DATABASE MediMaxDb;";

            string createUsersTable = clDatatypes.ConvertQuery(@"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
            CREATE TABLE Users (
                UserId _SI_ PRIMARY KEY,
                Username _V_[20] UNIQUE,
                Password _V_[20],
                IsAdmin _B_
            );");

            string changeDatabase = "USE MediMaxDb;";

            string createConfigsTable = clDatatypes.ConvertQuery(@"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Configs' AND xtype='U')
            CREATE TABLE Configs (
                Id _I_ PRIMARY KEY,
                nVal _N_[18?2],
                cVal _V_[1],
                sVal _V_[100],
                dVal _D_,
                dtVal _DT_,
                bVal _B_
            );");

            string createFirmsTable = clDatatypes.ConvertQuery(@"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Firms' AND xtype='U')
            CREATE TABLE Firms (
                FirmId _SI_ PRIMARY KEY,
                FirmType _SI_,
                Name _V_[100],
                CP _V_[50],
                AddA _V_[100],
                AddB _V_[100],
                City _V_[50],
                StateId _V_[2],
                Pin _V_[10],
                Std _SI_,
                LandLineA _SI_,
                LandLineB _SI_,
                MobNoA _SI_,
                MobNoB _SI_,
                Email _V_[50],
                Website _V_[100],
                Bank _V_[50],
                IFSC _V_[20],
                AcNo _V_[20],
                GSTIN _V_[20],
                RegType _V_[1],
                PAN _V_[20],
                TAN _V_[20],
                CIN _V_[20],
                WeightM _V_[50],
                WMExp _D_,
                Labour _V_[50],
                LabExp _D_,
                DLNoA _V_[50],
                DLExpA _D_,
                DLNoB _V_[50],
                DLExpB _D_,
                WarnDays _SI_
            );");

            string createPeriodTable = clDatatypes.ConvertQuery(@"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Period' AND xtype='U')
            CREATE TABLE Period (
                FirmId _SI_,
                FromDate _D_,
                ToDate _D_,
                FOREIGN KEY (FirmId) REFERENCES Firms(FirmId)
            );");

            string createStatesTable = clDatatypes.ConvertQuery(@"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='States' AND xtype='U')
            CREATE TABLE States (
                StateId _V_[2] PRIMARY KEY,
                State _V_[50]
            );");

            string insertAdminQuery = @"
            IF NOT EXISTS (SELECT 1 FROM Users WHERE UserName = 'a')
            INSERT INTO Users (UserId, Username, Password, IsAdmin)
            VALUES (1, 'a', '000', 1);";

            string insertStateQuery = @"
            INSERT INTO States (StateId, State)
            SELECT Source.StateId, Source.State
            FROM (
                VALUES
                    ('01', 'Jammu and Kashmir'),
                    ('02', 'Himachal Pradesh'),
                    ('03', 'Punjab'),
                    ('04', 'Chandigarh'),
                    ('05', 'Uttarakhand'),
                    ('06', 'Haryana'),
                    ('07', 'Delhi'),
                    ('08', 'Rajasthan'),
                    ('09', 'Uttar Pradesh'),
                    ('10', 'Bihar'),
                    ('11', 'Sikkim'),
                    ('12', 'Arunachal Pradesh'),
                    ('13', 'Nagaland'),
                    ('14', 'Manipur'),
                    ('15', 'Mizoram'),
                    ('16', 'Tripura'),
                    ('17', 'Meghalaya'),
                    ('18', 'Assam'),
                    ('19', 'West Bengal'),
                    ('20', 'Jharkhand'),
                    ('21', 'Orissa'),
                    ('22', 'Chhattisgarh'),
                    ('23', 'Madhya Pradesh'),
                    ('24', 'Gujarat'),
                    ('25', 'Daman and Diu'),
                    ('26', 'Dadra and Nagar Haveli'),
                    ('27', 'Maharashtra'),
                    ('28', 'Andhra Pradesh (Old)'),
                    ('29', 'Karnataka'),
                    ('30', 'Goa'),
                    ('31', 'Lakshadweep'),
                    ('32', 'Kerala'),
                    ('33', 'Tamil Nadu'),
                    ('34', 'Puducherry'),
                    ('35', 'Andaman and Nicobar'),
                    ('36', 'Telengana'),
                    ('37', 'Andhra Pradesh (New)')
            ) AS Source (StateId, State)
            WHERE NOT EXISTS (
                SELECT 1
                FROM States
                WHERE States.StateId = Source.StateId
            );";

            ExecuteSQLExpressCommand(connection, createDatabaseQuery);
            ExecuteSQLExpressCommand(connection, changeDatabase);
            ExecuteSQLExpressCommand(connection, createUsersTable);
            ExecuteSQLExpressCommand(connection, createConfigsTable);
            ExecuteSQLExpressCommand(connection, createFirmsTable);
            ExecuteSQLExpressCommand(connection, createPeriodTable);
            ExecuteSQLExpressCommand(connection, createStatesTable);
            ExecuteSQLExpressCommand(connection, insertAdminQuery);
            ExecuteSQLExpressCommand(connection, insertStateQuery);



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
