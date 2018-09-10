using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{

    /// <summary>
    /// A leg (voyage from port-to-port).
    /// </summary>
    public class LegData
    {
        /// <summary>
        /// ID of leg.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom Id.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// ID of voyage associated with leg.
        /// </summary>
        [JsonProperty("voyageId")]
        public int? VoyageId { get; set; }

        /// <summary>
        /// Name of voyage associated with leg.
        /// </summary>
        [JsonProperty("voyageName")]
        public string VoyageName { get; set; }

        /// <summary>
        /// UN-LOCODE of origin port associated with leg.
        /// </summary>
        [JsonProperty("portOfOriginUnloc")]
        public string PortOfOriginUnloc { get; set; }

        /// <summary>
        /// Name of origin port associated with leg.
        /// </summary>
        [JsonProperty("portOfOriginName")]
        public string PortOfOriginName { get; set; }

        /// <summary>
        /// UN-LOCODE of destination port associated with leg.
        /// </summary>
        [JsonProperty("portOfDestinationUnloc")]
        public string PortOfDestinationUnloc { get; set; }

        /// <summary>
        /// Name of destination port associated with leg.
        /// </summary>
        [JsonProperty("portOfDestinationName")]
        public string PortOfDestinationName { get; set; }

        /// <summary>
        /// Departure time from origin port (local).
        /// </summary>
        [JsonProperty("departureTime")]
        public DateTime DepartureTime { get; set; }

        /// <summary>
        /// Departure time from origin port (UTC).
        /// </summary>
        [JsonProperty("departureTimeUtc")]
        public DateTime? DepartureTimeUtc { set; get; }

        /// <summary>
        /// Arrival time at destination port (local).
        /// </summary>
        [JsonProperty("arrivalTime")]
        public DateTime? ArrivalTime { get; set; }

        /// <summary>
        /// Arrival time at destination port (UTC).
        /// </summary>
        [JsonProperty("arrivalTimeUtc")]
        public DateTime? ArrivalTimeUtc { get; set; }

        /// <summary>
        /// Name of the master on departure.
        /// </summary>
        [JsonProperty("captain")]
        public string Captain { get; set; }

        /// <summary>
        /// Name of chief engineer on departure.
        /// </summary>
        [JsonProperty("chiefEng")]
        public string ChiefEng { get; set; }

        /// <summary>
        /// Total cargo weight on departure. (tons)
        /// </summary>
        [JsonProperty("cargoWeight")]
        public double? CargoWeight { get; set; }

        /// <summary>
        /// Number of full TEU on departure.
        /// </summary>
        [JsonProperty("cargoTeuFull")]
        public double? CargoTeuFull { get; set; }

        /// <summary>
        /// Number of empty TEU on departure.
        /// </summary>
        [JsonProperty("cargoTeuEmpty")]
        public double? CargoTeuEmpty { get; set; }

        /// <summary>
        /// Number of reefer containers on departure.
        /// </summary>
        [JsonProperty("cargoReefers")]
        public int? CargoReefers { get; set; }

        /// <summary>
        /// Ballast water weight on departure. (tons)
        /// </summary>
        [JsonProperty("ballastWeight")]
        public double? BallastWeight { get; set; }
    }
}