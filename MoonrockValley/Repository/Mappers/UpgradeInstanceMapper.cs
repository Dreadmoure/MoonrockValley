using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    public class UpgradeInstanceMapper
    {
        /// <summary>
        /// Read the database table for UpdateInstance
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>A list of all UpdateInstances in the database</returns>
        public List<UpgradeInstance> MapItemInstancesFromReader(SQLiteDataReader reader)
        {
            // make a list for the result 
            var result = new List<UpgradeInstance>();

            // read all data from the database table for UpdateInstance
            while (reader.Read())
            {
                var itemId = reader.GetInt32(0);
                var isPlaced = reader.GetBoolean(1);

                // add the new UpdateInstance, with its data, to the result list 
                result.Add(new UpgradeInstance() { ItemID = itemId, IsPlaced = isPlaced });
            }

            // return list of all the UpdateInstances in the game 
            return result;
        }
    }
}
