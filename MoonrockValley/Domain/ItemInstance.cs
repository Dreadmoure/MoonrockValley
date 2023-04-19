using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Domain
{
    public class ItemInstance
    {
        /// <summary>
        /// Foreign key, referencing which Item the ItemInstance is 
        /// </summary>
        public int ItemID { get; set; }

        /// <summary>
        /// Foreign key, referencing where the item is in the Inventory 
        /// </summary>
        public int InventoryID { get; set; }
    }
}
