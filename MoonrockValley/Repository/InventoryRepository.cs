using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// class for the InventoryRepository, this is the players inventory that holds the items the player has
    /// </summary>
    public class InventoryRepository : Repository
    {
        /// <summary>
        /// method used for adding an item to the InventoryRepository
        /// </summary>
        /// <param name="itemId">the itemID of the item</param>
        /// <param name="inventoryId">the ID in the inventory</param>
        /// <param name="amount">the amount of the item</param>
        public void AddItem(int itemId, int inventoryId, int amount)
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
        /// method for updating the itemInstance based on its id in the inventory and the amount
        /// </summary>
        /// <param name="inventoryId">the id in the inventory</param>
        /// <param name="amount">the amount you want to update it to</param>
        public void UpdateItem(int inventoryId, int amount)
        {

        }

        /// <summary>
        /// method for Deleting the itemInstance from the inventory based on its inventoryId
        /// </summary>
        /// <param name="inventoryId">the id in the inventory</param>
        public void DeleteItem(int inventoryId)
        {

        }
    }
}
