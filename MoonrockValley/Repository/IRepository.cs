using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// Interface to be implemented in repositories
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Used to open a connection to the database
        /// </summary>
        void Open();

        /// <summary>
        /// Used to close the connection from a database
        /// </summary>
        void Close();
    }
}
