using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Repository
{
    /// <summary>
    /// Class for the UpgradeInstanceRepository which handles the upgrades which has been implemented
    /// </summary>
    public class UpgradeInstanceRepository : Repository
    {
        /// <summary>
        /// method used for adding an Upgrade to the UpgradeInstanceRepository
        /// </summary>
        /// <param name="itemId">the id of the item</param>
        /// <param name="isPlaced">determines if the upgrade is placed in the city</param>
        public void AddUpgrade(int itemId, bool isPlaced)
        {

        }

        /// <summary>
        /// method used for returning a list of all the UpgradeInstances
        /// </summary>
        /// <returns>List of UpgradeInstance</returns>
        public List<UpgradeInstance> GetAllUpgrades()
        {
            //return something
        }



        /// <summary>
        /// method for updating the UpgradeInstance based on its itemID and the bool isPlaced
        /// </summary>
        /// <param name="itemId">the id of the item</param>
        /// <param name="isPlaced">determines if the upgrade is placed in the city</param>
        public void UpdateItem(int itemId, bool isPlaced)
        {

        }

        /// <summary>
        /// method for Deleting the itemInstance based on its itemID as it is unique in this context, since two of the same cannot exist
        /// </summary>
        /// <param name="itemId">the id of the item</param>
        public void DeleteItem(int itemId)
        {

        }
    }
}
