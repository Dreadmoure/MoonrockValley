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
            var inventoryTtemMapper = new InventoryItemMapper();
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

            //GetAllItem works
            //itemResult = itemRepo.GetAllItems();

            //foreach(Item item in itemResult)
            //{
            //    Console.WriteLine($"{item.ID}, {item.Name}, {item.Type} ,{item.Value}");
            //}

            //update works with overloads
            //itemRepo.UpdateItem(4, "Stone", ItemType.Material, 100);
            //itemRepo.UpdateItem(4, "Clay");
            //itemRepo.UpdateItem(5, ItemType.Equipment);
            //itemRepo.UpdateItem(6, 50);


            itemRepo.Close();


            List<InventoryItem> inventoryItemResult;


            Console.WriteLine("Hello Moonrock Valley");

            Console.ReadKey(); 
        }
    }
}
