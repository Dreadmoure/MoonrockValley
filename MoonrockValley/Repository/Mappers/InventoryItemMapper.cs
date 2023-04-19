using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    public class InventoryItemMapper
    {
        /// <summary>
        /// Read the database table for Inventory
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>A list of the Inventory in the database</returns>
        public List<InventoryItem> MapInventoryFromReader(SQLiteDataReader reader)
        {
            // make a list for the result 
            var result = new List<InventoryItem>();

            // read all data from the database table for Inventory
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var itemId = reader.GetInt32(1);
                var amount = reader.GetInt32(2); 

                // add the new Item, with its data, to the result list 
                result.Add(new InventoryItem() { ID = id, ItemID = itemId, Amount = amount });
            }

            // return list of all the Items in the game 
            return result;
        }
    }
}
