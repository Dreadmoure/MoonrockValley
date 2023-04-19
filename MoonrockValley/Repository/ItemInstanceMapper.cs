using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    public class ItemInstanceMapper
    {
        /// <summary>
        /// Read the database table for ItemInstance
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>A list of all ItemInstances in the database</returns>
        public List<ItemInstance> MapItemInstancesFromReader(SQLiteDataReader reader)
        {
            // make a list for the result 
            var result = new List<ItemInstance>();

            // read all data from the database table for ItemInstance
            while (reader.Read())
            {
                var itemId = reader.GetInt32(0);
                var inventoryId = reader.GetInt32(1);

                // add the new ItemInstance, with its data, to the result list 
                result.Add(new ItemInstance() { ItemID = itemId, InventoryID = inventoryId });
            }

            // return list of all the ItemInstances in the game 
            return result;
        }
    }
}
