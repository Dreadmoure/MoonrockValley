using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// class for SQLiteDatabaseProvider which handles the path to the database
    /// </summary>
    public class SQLiteDatabaseProvider
    {
        private readonly string connectionString;

        /// <summary>
        /// Constructor for the provider which takes a string
        /// </summary>
        /// <param name="connectionString">the path to the database</param>
        public SQLiteDatabaseProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Method for returning a connection based on the string
        /// </summary>
        /// <returns>IDbConnection</returns>
        public IDbConnection CreateConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
