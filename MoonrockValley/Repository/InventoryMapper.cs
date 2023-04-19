using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    public class InventoryMapper
    {
        /// <summary>
        /// Read the database table for Inventory
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>A list of the Inventory in the database</returns>
        public List<Inventory> MapInventoryFromReader(SQLiteDataReader reader)
        {
            // make a list for the result 
            var result = new List<Inventory>();

            // read all data from the database table for Inventory
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var inventoryId = reader.GetInt32(1);

                // add the new Item, with its data, to the result list 
                result.Add(new Inventory() { ID = id, ItemID = itemId });
            }

            // return list of all the Items in the game 
            return result;
        }
    }
}
