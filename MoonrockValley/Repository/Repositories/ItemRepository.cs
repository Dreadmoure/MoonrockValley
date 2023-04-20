using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// Class for the itemrepository which holds "blueprints" for the specific item
    /// </summary>
    public class ItemRepository : Repository
    {
        private readonly ItemMapper mapper;

        public ItemRepository(IDatabaseProvider provider, ItemMapper mapper)
        {
            Provider = provider;
            this.mapper = mapper;
        }

        /// <summary>
        /// Create the database if it does not exist
        /// </summary>
        protected override void CreateDatabaseTables()
        {
            var cmd = new SQLiteCommand($"CREATE TABLE IF NOT EXISTS Item (Id INTEGER PRIMARY KEY, Name VARCHAR(50), Type INTEGER, Value INTEGER)", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Used to add an item to the ItemRepository
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="ItemType">Item type</param>
        /// <param name="value">The value of the item</param>
        public void AddItem(string name, ItemType type, int value)
        {
            Item foundItem = FindItem(name);

            if(foundItem.Name != name)
            {
                var cmd = new SQLiteCommand($"INSERT INTO Item (Name, Type, Value) VALUES ('{name}','{(int)type}','{value}')", (SQLiteConnection)Connection);
                cmd.ExecuteNonQuery();
            }
            
        }

        /// <summary>
        /// Method for returning a list of all the items in the ItemRepository
        /// </summary>
        /// <returns>List of Items</returns>
        public List<Item> GetAllItems()
        {
            var cmd = new SQLiteCommand("SELECT * from Item", (SQLiteConnection)Connection);
            var reader = cmd.ExecuteReader();

            var result = mapper.MapItemsFromReader(reader);

            return result;
        }

        /// <summary>
        /// method for updating the item based on its ID
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="name">name of the item</param>
        /// <param name="type">type of the item</param>
        /// <param name="value">value of the item</param>
        public void UpdateItem(int id, string name, ItemType type, int value)
        {
            var cmd = new SQLiteCommand($"UPDATE Item set Name = '{name}', Type = {(int)type}, Value = {value} WHERE Id = {id}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// overload method for updating the items name based on its ID
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="name">name of the item</param>
        public void UpdateItem(int id, string name)
        {
            var cmd = new SQLiteCommand($"UPDATE Item set Name = '{name}' WHERE Id = {id}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// overload method for updating the items type based on its ID
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="type">type of the item</param>
        public void UpdateItem(int id, ItemType type)
        {
            var cmd = new SQLiteCommand($"UPDATE Item set Type = {(int)type} WHERE Id = {id}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// method for updating the item based on its ID
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="value">value of the item</param>
        public void UpdateItem(int id, int value)
        {
            var cmd = new SQLiteCommand($"UPDATE Item set Value = {value} WHERE Id = {id}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// method used for deleting an item based on its ID
        /// </summary>
        /// <param name="id">The ID of the Item</param>
        public void DeleteItem(int id)
        {
            var cmd = new SQLiteCommand($"DELETE from Item WHERE Id = {id}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Finds item based on its name, used to make sure no two items with the same name can exist
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <returns>Item</returns>
        private Item FindItem(string name)
        {
            var cmd = new SQLiteCommand($"SELECT * from Item WHERE name = '{name}'", (SQLiteConnection)Connection);
            var reader = cmd.ExecuteReader();

            var result = mapper.MapItemsFromReader(reader).First();

            return result;
        }

    }
}
