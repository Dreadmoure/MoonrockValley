using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Hello Moonrock Valley");

            Console.ReadKey(); 
        }
    }
}
