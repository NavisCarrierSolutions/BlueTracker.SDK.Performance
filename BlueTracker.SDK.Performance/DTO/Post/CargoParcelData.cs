using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// Describes a cargo parcel movement.
    /// </summary>
    public class CargoParcelData
    {
        /// <summary>
        /// Unique identifier of cargo parcel used by customer.
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Name of cargo.
        /// </summary>
        public string CargoName { get; set; }

        /// <summary>
        /// Contracting partner (charterer) for the cargo parcel.
        /// </summary>
        public string CounterPartyName { get; set; }

        /// <summary>
        /// Cargo parcel weight.
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// UNLOCODE for port of loading.
        /// </summary>
        public string PolUnloc { get; set; }

        /// <summary>
        /// Datetime of the departure event for the POL (port of loading).
        /// </summary>
        public DateTimeOffset PolTimeStamp { get; set; }

        /// <summary>
        /// UNLOCODE for the port of discharge.
        /// </summary>
        public string PodUnloc { get; set; }

        /// <summary>
        /// Datetime of the arrival event for the POD (port of discharge).
        /// </summary>
        public DateTimeOffset PodTimeStamp { get; set; }
    }
}
