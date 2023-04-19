using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    public class ItemMapper
    {
        /// <summary>
        /// Read the database table for Item 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>A list of all Items in the database</returns>
        public List<Item> MapItemsFromReader(SQLiteDataReader reader)
        {
            // make a list for the result 
            var result = new List<Item>();

            // read all data from the database table for Item 
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var type = reader.GetInt32(2);
                var value = reader.GetInt32(3); 

                // add the new Item, with its data, to the result list 
                result.Add(new Item() { ID = id, Name = name, Type = (ItemType)type, Value = value});
            }

            // return list of all the Items in the game 
            return result;
        }
    }
}
