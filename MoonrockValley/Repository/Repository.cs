using System;
using System.Collections.Generic;
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
        /// Method used for opening a connection to a database
        /// </summary>
        public void Open()
        {
            if(connection == null)
            {
                connection = provider.CreateConnection();
            }
            connection.Open();
            CreateDatabaseTables();
        }

        /// <summary>
        /// Method used to close a connection to a database
        /// </summary>
        public void Close()
        {
            connection.Close();
        }
    }
}
