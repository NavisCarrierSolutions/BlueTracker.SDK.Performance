using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Enums
{
    /// <summary>
    /// Provides different levels of ship deletion.
    /// </summary>
    [Flags]
    public enum ShipDeletionLevels
    {
        /// <summary>
        /// Nothing will be deleted.
        /// </summary>
        None = 0,

        /// <summary>
        /// Will delete all ship data that does not belong to any other category (e.g. Licenses, Ship Tags)
        /// </summary>
        ShipData = 1,

        /// <summary>
        /// Will delete all operational data (e.g. Reports, Events, Legs, Voyages)
        /// </summary>
        OperationalData = 2,

        /// <summary>
        /// Will delete all hull related data (e.g. Hull Events) 
        /// </summary>
        HullEventData = 4,

        /// <summary>
        /// Will delete all charter related data (e.g. Charter Curve Histories)
        /// </summary>
        CharterData = 8,

        /// <summary>
        /// Will delete the ship completely.
        /// </summary>
        All = ShipData | OperationalData | HullEventData | CharterData
    }
}
