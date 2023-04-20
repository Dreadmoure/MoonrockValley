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

            itemRepo.AddItem("Apple", ItemType.Food, 50);
            itemRepo.AddItem("Hat", ItemType.Equipment, 300);
            itemRepo.AddItem("Wood", ItemType.Material, 25);

            itemRepo.Close();


            List<InventoryItem> inventoryItemResult;


            Console.WriteLine("Hello Moonrock Valley");

            Console.ReadKey(); 
        }
    }
}
