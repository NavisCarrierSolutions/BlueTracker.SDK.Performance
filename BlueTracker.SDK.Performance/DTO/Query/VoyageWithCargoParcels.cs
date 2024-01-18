using Newtonsoft.Json;
using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Provides information for a voyage with cargo parcels.
    /// </summary>
    public class VoyageWithCargoParcels
    {
        /// <summary>
        /// ID of voyage.
        /// </summary>
        public int VoyageId { get; set; }

        /// <summary>
        /// Name of voyage.
        /// </summary>
        public string VoyageName { get; set; }

        /// <summary>
        /// IMO number of ship.
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// ID of ship.
        /// </summary>
        public int ShipId { get; set; }

        /// <summary>
        /// Name of the ship.
        /// </summary>
        public string ShipName { get; set; }

        [JsonIgnore]
        public DateTime? VoyageStartDate { get; set; }

        [JsonIgnore]
        public DateTime? VoyageEndDate { get; set; }

        /// <summary>
        /// UTC start date of voyage.
        /// </summary>
        public DateTimeOffset? VoyageStartDateUtc
        {
            get
            {
                if (VoyageStartDate == null)
                {
                    return null;
                }

                return new DateTimeOffset(VoyageStartDate.Value, TimeSpan.Zero);
            }
        }

        /// <summary>
        /// UTC end date of voyage.
        /// </summary>
        public DateTimeOffset? VoyageEndDateUtc
        {
            get
            {
                if (VoyageEndDate == null)
                {
                    return null;
                }

                return new DateTimeOffset(VoyageEndDate.Value, TimeSpan.Zero);
            }
        }

        /// <summary>
        /// UNLOCODE of port the voyage started from.
        /// </summary>
        public string FromUnloc { get; set; }

        /// <summary>
        /// UNLOCODE of port the voyage goes to.
        /// </summary>
        public string ToUnloc { get; set; }

        /// <summary>
        /// Total distance sailed during voyage. (nautical miles)
        /// </summary>
        public double? TotalDistance { get; set; }

        /// <summary>
        /// Total fuel oil consumption. (tons)
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total CO2 emission. (tons)
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Used internally.
        /// </summary>
        public bool? HasCargoParcels { get; set; }
    }
}
