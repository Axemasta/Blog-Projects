using System;
using System.IO;

using SQLite;

namespace DataPersistence.Sqlite.Database.Private
{
    /// <summary>
    /// DatabaseAccess - Accesses the SQLite Database
    /// </summary>
    public class DatabaseAccess : IDatabaseAccess
    {
        #region ISQLite Implementation

        /// <summary>
        /// Returns a connection to the sqlite database
        /// </summary>
        /// <returns></returns>
        public SQLiteConnection GetConnection()
        {
            var filename = SQLiteConstants.DatabaseName;
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, filename);

            var connection = new SQLiteConnection(path, true);

            return connection;
        }

        #endregion ISQLite Implementation
    }
}