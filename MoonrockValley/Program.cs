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
    public enum ItemType
    {
        Food,
        Material,
        Equipment,
        Upgrade
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

            //adding works
            //itemRepo.AddItem("Apple", ItemType.Food, 50);
            //itemRepo.AddItem("Hat", ItemType.Equipment, 300);
            //itemRepo.AddItem("Wood", ItemType.Material, 25);

            //deleting works
            //itemRepo.DeleteItem(3);

            //update works with overloads
            //itemRepo.UpdateItem(4, "Stone", ItemType.Material, 100);
            //itemRepo.UpdateItem(4, "Clay");
            //itemRepo.UpdateItem(5, ItemType.Equipment);
            //itemRepo.UpdateItem(6, 50);

            Console.WriteLine("Items");

            //GetAllItem works
            itemResult = itemRepo.GetAllItems();

            Console.WriteLine("ID, Name, Type, Value");

            foreach(Item item in itemResult)
            {
                Console.WriteLine($"{item.ID}, {item.Name}, {item.Type} ,{item.Value}");
            }


            itemRepo.Close();


            List<InventoryItem> inventoryItemResult;
            var inventoryRepo = new InventoryItemRepository(provider, inventoryItemMapper);
            inventoryRepo.Open();

            //adding works
            //inventoryRepo.AddItem(2, 3, 50);

            //update with overloads works
            //inventoryRepo.UpdateItem(2, 2, 25);
            //inventoryRepo.UpdateItem(5, 3);
            //inventoryRepo.UpdateItemAmount(5, 100);
            //inventoryRepo.UpdateItemPosition(4, 5);

            //delete works
            //inventoryRepo.DeleteItem(2);

            Console.WriteLine("\nInventoryItems");

            Console.WriteLine("ID, ItemID, Amount");

            //GetAllItems works
            inventoryItemResult = inventoryRepo.GetAllItems();

            foreach (InventoryItem inventoryItem in inventoryItemResult)
            {
                Console.WriteLine($"{inventoryItem.ID}, {inventoryItem.ItemID}, {inventoryItem.Amount}");
            }

            inventoryRepo.Close();

            Console.ReadKey(); 
        }
    }
}
