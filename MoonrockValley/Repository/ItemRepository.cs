using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Used to add an item to the ItemRepository
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="ItemType">Item type</param>
        /// <param name="value">The value of the item</param>
        public void AddItem(string name, type ItemType, int value)
        {

        }

        /// <summary>
        /// Method for returning a list of all the items in the ItemRepository
        /// </summary>
        /// <returns>List of Items</returns>
        public List<Item> GetAllItems()
        {
            //return something
        }

        /// <summary>
        /// method for updating the item based on its ID
        /// </summary>
        /// <param name="Id">The ID of the Item</param>
        public void UpdateItem(int id)
        {

        }

        /// <summary>
        /// method used for deleting an item based on its ID
        /// </summary>
        /// <param name="id">The ID of the Item</param>
        public void DeleteItem(int id)
        {

        }

    }
}
