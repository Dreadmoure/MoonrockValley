using MoonrockValley.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// Class for the ItemInstanceRepository
    /// </summary>
    public class ItemInstanceRepository : Repository
    {
        /// <summary>
        /// method used for adding an item to the ItemInstanceRepository
        /// </summary>
        /// <param name="itemId">The item ID of the item you want to add</param>
        /// <param name="inventoryId">The inventory ID you want to add it to</param>
        public void AddItem(int itemId, int inventoryId)
        {

        }

        /// <summary>
        /// method used for returning a list of all the ItemInstances
        /// </summary>
        /// <returns>List of ItemInstance</returns>
        public List<ItemInstance> GetAllItems()
        {
            //return something
        }



        /// <summary>
        /// method for updating the itemInstance based on its itemID and inventoryId
        /// </summary>
        /// <param name="itemId">the items ID</param>
        /// <param name="inventoryId">the ID in the inventory</param>
        public void UpdateItem(int itemId, int inventoryId)
        {

        }

        /// <summary>
        /// method for Deleting the itemInstance based on its itemID and inventoryId
        /// </summary>
        /// <param name="itemId">the items ID</param>
        /// <param name="inventoryId">the ID in the inventory</param>
        public void DeleteItem(int itemId, int inventoryId)
        {

        }
    }
}
