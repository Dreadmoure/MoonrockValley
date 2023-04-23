using MoonrockValley.Domain;
using MoonrockValley.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MoonrockValley
{
    /// <summary>
    /// enum for defining the type of an item 
    /// </summary>
    public enum ItemType
    {
        Food,
        Material,
        Equipment
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var itemMapper = new ItemMapper();
            var inventoryItemMapper = new InventoryItemMapper();
            var provider = new SQLiteDatabaseProvider("Data Source=inventory.db;Version=3;new=true");

            List<Item> itemResult;
            var itemRepo = new ItemRepository(provider, itemMapper);
            itemRepo.Open();

            //Uncomment these to add item
            //itemRepo.AddItem("Apple", ItemType.Food, 50);
            //itemRepo.AddItem("Hat", ItemType.Equipment, 300);
            //itemRepo.AddItem("Wood", ItemType.Material, 25);
            AddItems(itemRepo);

            //Uncomment this to delete an item
            //itemRepo.DeleteItem(3);

            //Uncomment this to update an item, below are overloads
            //itemRepo.UpdateItem(4, "Stone", ItemType.Material, 100);
            //itemRepo.UpdateItem(4, "Clay");
            //itemRepo.UpdateItem(5, ItemType.Equipment);
            //itemRepo.UpdateItem(6, 50);

            //prints out the Item list
            Console.WriteLine("Items");

            //GetAllItems
            itemResult = itemRepo.GetAllItems();

            Console.WriteLine("ID, Name, Type, Value");

            foreach(Item item in itemResult)
            {
                Console.WriteLine($"{item.ID}, {item.Name}, {item.Type}, {item.Value}");
            }

            itemRepo.Close();

            List<InventoryItem> inventoryItemResult;
            var inventoryRepo = new InventoryItemRepository(provider, inventoryItemMapper);
            inventoryRepo.Open();

            //Uncomment to add item to inventory
            //inventoryRepo.AddItem(2, 3, 50);
            //inventoryRepo.AddItem(7, 2, 1000);
            AddInventoryItems(inventoryRepo); 

            //Uncomment to update and item in the inventory, below are overloads and related
            //inventoryRepo.UpdateItem(2, 2, 25);
            //inventoryRepo.UpdateItem(5, 3);
            //inventoryRepo.UpdateItemAmount(5, 100);
            //inventoryRepo.UpdateItemPosition(4, 5);

            //Uncomment to Delete an item from the inventory
            //inventoryRepo.DeleteItem(2);

            //prints out all the items in the inventory
            Console.WriteLine("\nInventoryItems");

            Console.WriteLine("ID, ItemID, Amount");

            //GetAllItems
            inventoryItemResult = inventoryRepo.GetAllItems();

            foreach (InventoryItem inventoryItem in inventoryItemResult)
            {
                Console.WriteLine($"{inventoryItem.ID}, {inventoryItem.ItemID}, {inventoryItem.Amount}");
            }

            // Prints out all the items in the inventory CheckInventory so the user understands what is in it
            inventoryRepo.CheckInventory();

            inventoryRepo.Close();

            Console.ReadKey(); 
        }

        /// <summary>
        /// dummy method for adding items 
        /// </summary>
        /// <param name="itemRepo">repository for items</param>
        private static void AddItems(ItemRepository itemRepo)
        {
            itemRepo.AddItem("Apple", ItemType.Food, 50);
            itemRepo.AddItem("Hat", ItemType.Equipment, 300);
            itemRepo.AddItem("Wood", ItemType.Material, 25);
        }

        /// <summary>
        /// dummy method for adding invneotryItems
        /// </summary>
        /// <param name="inventoryRepo">repository for inventoryItems</param>
        private static void AddInventoryItems(InventoryItemRepository inventoryRepo)
        {
            inventoryRepo.AddItem(2, 3, 50);
            inventoryRepo.AddItem(7, 2, 1000);
            inventoryRepo.AddItem(1, 7, 1000);
        }
    }
}
