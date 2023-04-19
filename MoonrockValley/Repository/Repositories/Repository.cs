using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// class used to inheriting functionality
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Gets the database provider 
        /// </summary>
        protected IDatabaseProvider Provider { get; }

        /// <summary>
        /// Gets and sets database connection 
        /// </summary>
        protected IDbConnection Connection { get; set; }

        /// <summary>
        /// Method used for opening a connection to a database
        /// </summary>
        public void Open()
        {
            if(Connection == null)
            {
                Connection = Provider.CreateConnection();
            }
            Connection.Open();
            CreateDatabaseTables();
        }

        /// <summary>
        /// Implemented in the specific repository 
        /// </summary>
        protected virtual void CreateDatabaseTables()
        {

        }

        /// <summary>
        /// Method used to close a connection to a database
        /// </summary>
        public void Close()
        {
            Connection.Close();
        }
    }
}
