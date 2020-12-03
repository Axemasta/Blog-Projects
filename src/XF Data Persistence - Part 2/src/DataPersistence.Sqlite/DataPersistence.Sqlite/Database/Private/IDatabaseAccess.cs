using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace DataPersistence.Sqlite.Database.Private
{
    public interface IDatabaseAccess
    {
        /// <summary>
        /// Returns a connection to the sqlite database
        /// </summary>
        /// <returns></returns>
        SQLiteConnection GetConnection();
    }
}
