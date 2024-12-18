namespace Models
{
    public static class clDatatypes
    {
        public static string ConvertQuery(string query)
        {
            if (clConnection.CurrentDatabaseType == DatabaseType.SQLite)
            {
                query = query.Replace("_V_", "TEXT NOT NULL");
                query = query.Replace("_D_", "DATE NOT NULL");
                query = query.Replace("_DT_", "DATETIME NOT NULL");
                query = query.Replace("_B_", "BOOLEAN NOT NULL");
                query = query.Replace("_SI_", "INTEGER NOT NULL");
                query = query.Replace("_I_", "INTEGER NOT NULL");
                query = query.Replace("_N_", "REAL NOT NULL");
                query = query.Replace("[", "");
                query = query.Replace("]", "");
                query = query.Replace("?", "");
                query = query.Replace("0", "");
                query = query.Replace("1", "");
                query = query.Replace("2", "");
                query = query.Replace("3", "");
                query = query.Replace("4", "");
                query = query.Replace("5", "");
                query = query.Replace("6", "");
                query = query.Replace("7", "");
                query = query.Replace("8", "");
                query = query.Replace("9", "");
            }
            else if (clConnection.CurrentDatabaseType == DatabaseType.SQLExpress)
            {
                query = query.Replace("_V_", "VARCHAR");
                query = query.Replace("_D_", "DATE NOT NULL");
                query = query.Replace("_DT_", "DATETIME NOT NULL");
                query = query.Replace("_B_", "BIT NOT NULL");
                query = query.Replace("_SI_", "SMALLINT NOT NULL");
                query = query.Replace("_I_", "INT NOT NULL");
                query = query.Replace("_N_", "DECIMAL");
                query = query.Replace("?", ",");
                query = query.Replace("[", "(");
                query = query.Replace("]", ") NOT NULL");

            }
            return query;
        }
    }
}
