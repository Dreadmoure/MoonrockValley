using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// class for the InventoryRepository, this is the players inventory that holds the items the player has
    /// </summary>
    public class InventoryItemRepository : Repository
    {
        private readonly InventoryItemMapper mapper;

        /// <summary>
        /// Constructor for the InventoryItemRepository
        /// </summary>
        /// <param name="provider">the database provider</param>
        /// <param name="mapper">the inventory item mapper</param>
        public InventoryItemRepository(IDatabaseProvider provider, InventoryItemMapper mapper)
        {
            Provider = provider;
            this.mapper = mapper;
        }

        /// <summary>
        /// Create the database if it does not exist
        /// </summary>
        protected override void CreateDatabaseTables()
        {
            var cmd = new SQLiteCommand($"CREATE TABLE IF NOT EXISTS InventoryItem (Id INTEGER PRIMARY KEY, ItemId INTEGER, Amount INTEGER)", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// method used for adding an item to the InventoryRepository
        /// </summary>
        /// <param name="itemId">the itemID of the item</param>
        /// <param name="inventoryId">the ID in the inventory</param>
        /// <param name="amount">the amount of the item</param>
        public void AddItem(int inventoryId, int itemId, int amount)
        {
            var cmd = new SQLiteCommand($"SELECT * from InventoryItem WHERE Id = '{inventoryId}'", (SQLiteConnection)Connection);
            var reader = cmd.ExecuteReader();

            var result = mapper.MapInventoryItemFromReader(reader).FirstOrDefault();

            if(result == null)
            {
                cmd = new SQLiteCommand($"INSERT INTO InventoryItem (Id, ItemId, Amount) VALUES ('{inventoryId}','{itemId}','{amount}')", (SQLiteConnection)Connection);
                cmd.ExecuteNonQuery();
            }         
        }

        /// <summary>
        /// method used for returning a list of all the InventoryItems
        /// </summary>
        /// <returns>List of InventoryItem</returns>
        public List<InventoryItem> GetAllItems()
        {
            var cmd = new SQLiteCommand("SELECT * from InventoryItem", (SQLiteConnection)Connection);
            var reader = cmd.ExecuteReader();

            var result = mapper.MapInventoryItemFromReader(reader);

            return result;
        }



        /// <summary>
        /// method for updating the InventoryItem based on its id in the inventory, the itemId and the amount
        /// </summary>
        /// <param name="inventoryId"></param>
        /// <param name="itemId"></param>
        /// <param name="amount"></param>
        public void UpdateItem(int inventoryId, int itemId, int amount)
        {
            var cmd = new SQLiteCommand($"UPDATE InventoryItem set Id = '{inventoryId}', ItemId = {itemId}, Amount = {amount} WHERE Id = {inventoryId}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
            
        }
                
        /// <summary>
        /// method for updating the itemId of theInventoryItem based on its id in the inventory
        /// </summary>
        /// <param name="inventoryId"></param>
        /// <param name="itemId"></param>
        public void UpdateItem(int inventoryId, int itemId)
        {
            var cmd = new SQLiteCommand($"UPDATE InventoryItem set ItemId = {itemId} WHERE Id = {inventoryId}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// method for updating the amount of the InventoryItem based on its id in the inventory
        /// </summary>
        /// <param name="inventoryId"></param>
        /// <param name="amount"></param>
        public void UpdateItemAmount(int inventoryId, int amount)
        {
            var cmd = new SQLiteCommand($"UPDATE InventoryItem set Amount = {amount} WHERE Id = {inventoryId}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// method for updating the inventoryID of theInventoryItem based on its id in the inventory
        /// </summary>
        /// <param name="to">the id we want to move it to</param>
        /// <param name="from">the id the item is at</param>
        public void UpdateItemPosition(int to, int from)
        {
            var cmd = new SQLiteCommand($"SELECT * from InventoryItem WHERE Id = '{to}'", (SQLiteConnection)Connection);
            var reader = cmd.ExecuteReader();

            var result = mapper.MapInventoryItemFromReader(reader).FirstOrDefault();

            if (result == null)
            {
                cmd = new SQLiteCommand($"UPDATE InventoryItem set Id = '{to}' WHERE Id = {from}", (SQLiteConnection)Connection);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// method for Deleting the itemInstance from the inventory based on its inventoryId
        /// </summary>
        /// <param name="inventoryId">the id in the inventory</param>
        public void DeleteItem(int inventoryId)
        {
            var cmd = new SQLiteCommand($"DELETE from InventoryItem WHERE Id = {inventoryId}", (SQLiteConnection)Connection);
            cmd.ExecuteNonQuery();
        }

        public void CheckInventory()
        {
            var cmd = new SQLiteCommand("SELECT InventoryItem.Id, Item.Name, Item.Type, InventoryItem.Amount, Item.Value*InventoryItem.Amount FROM Item JOIN InventoryItem WHERE Item.Id = InventoryItem.ItemId", (SQLiteConnection)Connection);
            var reader = cmd.ExecuteReader();

            var results = new List<string>();

            // read all data from the database table for Inventory
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var type = reader.GetInt32(2);
                var amount = reader.GetInt32(3);
                var value = reader.GetInt32(4); 

                // add the new Item, with its data, to the result list 
                results.Add($"{id}, {name}, {(ItemType)type}, {amount}, {value}");
            }

            Console.WriteLine("\nCheck inventory");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
