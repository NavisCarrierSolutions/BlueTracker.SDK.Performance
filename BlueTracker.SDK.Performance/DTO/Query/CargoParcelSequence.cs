using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Describes a sequence of cargo movements.
    /// </summary>
    public class CargoParcelSequence
    {
        /// <summary>
        /// Unique identifier of voyage.
        /// </summary>
        public int VoyageId { get; set; }

        /// <summary>
        /// Name of voyage.
        /// </summary>
        public string VoyageName { get; set; }

        /// <summary>
        /// IMO number of vessel.
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of vessel.
        /// </summary>
        public string VesselName { get; set; }

        /// <summary>
        /// Collection of cargo parcels.
        /// </summary>
        public List<CargoParcel> CargoParcels { get; set; }
    }
}
