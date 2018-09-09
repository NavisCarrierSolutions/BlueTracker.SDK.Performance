using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class LegShort
    {
        /// <summary>
        /// ID of leg.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of voyage.
        /// </summary>
        [JsonProperty("voyageName")]
        public string VoyageName { get; set; }

        /// <summary>
        /// UN-LOCODE of origin port (5-char Code).
        /// </summary>
        [JsonProperty("portOfOriginUnloc")]
        public string PortOfOriginUnloc { get; set; }

        /// <summary>
        /// UN-LOCODE of destination port (5-char Code).
        /// </summary>
        [JsonProperty("portOfDestinationUnloc")]
        public string PortOfDestinationUnloc { get; set; }

        /// <summary>
        /// Departure time (including UTC Offset).
        /// </summary>
        [JsonProperty("departureTime")]
        public DateTimeOffset DepartureTime { get; set; }

        /// <summary>
        /// Arrival time (including UTC Offset).
        /// </summary>
        [JsonProperty("arrivalTime")]
        public DateTimeOffset? ArrivalTime { get; set; }
    }
}