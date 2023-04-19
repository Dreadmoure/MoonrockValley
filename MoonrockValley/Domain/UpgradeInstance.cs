using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonrockValley.Domain
{
    public class UpgradeInstance
    {
        /// <summary>
        /// Foreign key, referencing which Item the upgrade is 
        /// </summary>
        public int ItemID { get; set; }

        /// <summary>
        /// A bool specifying whether the upgrade is placed or not 
        /// </summary>
        public bool IsPlaced { get; set; }
    }
}
