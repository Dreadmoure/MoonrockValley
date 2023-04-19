using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    public interface IDatabaseProvider
    {
        /// <summary>
        /// for implementation 
        /// </summary>
        /// <returns></returns>
        IDbConnection CreateConnection(); 
    }
}
