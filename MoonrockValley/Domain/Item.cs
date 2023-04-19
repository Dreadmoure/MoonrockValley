using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Domain
{
    public class Item
    {
        /// <summary>
        /// Primary key, specifying the Item ID 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the Item 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of Item 
        /// </summary>
        public ItemType Type { get; set; }

        /// <summary>
        /// The value or price of the Item 
        /// </summary>
        public int Value { get; set; }
    }
}
