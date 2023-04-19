using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Domain
{
    public class InventoryItem
    {
        /// <summary>
        /// Primary key, specifying the ID of the inventory, ie the place in the inventory 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Foreign key, references the id of the specific Item 
        /// </summary>
        public int ItemID { get; set; }

        /// <summary>
        /// The amount of the specific Item, the size of the stack 
        /// </summary>
        public int Amount { get; set; }
    }
}
