using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// A leg (voyage from port-to-port).
    /// </summary>
    public class Leg
    {
        /// <summary>
        /// ID of leg.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Version Stamp when the leg was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        [JsonProperty("ship")]
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Id of Voyage
        /// </summary>
        public int? VoyageId { get; set; }

        /// <summary>
        /// Voyage info.
        /// </summary>
        [JsonProperty("voyage")]
        public VoyageShort Voyage { get; set; }

        /// <summary>
        /// Port info of origin port.
        /// </summary>
        [JsonProperty("portOfOrigin")]
        public PortShort PortOfOrigin { get; set; }

        /// <summary>
        /// Port info of destination port.
        /// </summary>
        [JsonProperty("portOfDestination")]
        public PortShort PortOfDestination { get; set; }

        /// <summary>
        /// UN-LOCODE of origin port (5-char code).
        /// </summary>
        [JsonProperty("portOfOriginUnloc")]
        public string PortOfOriginUnloc { get; set; }

        /// <summary>
        /// Name of origin port associated with leg.
        /// </summary>
        [JsonProperty("PortOfOriginName")]
        public string PortOfOriginName { get; set; }

        /// <summary>
        /// UN-LOCODE of destination port (5-char code).
        /// </summary>
        [JsonProperty("portOfDestinationUnloc")]
        public string PortOfDestinationUnloc { get; set; }

        /// <summary>
        /// Name of destination port associated with leg.
        /// </summary>
        [JsonProperty("portOfDestinationName")]
        public string PortOfDestinationName { get; set; }

        /// <summary>
        /// Departure Time.
        /// </summary>
        [JsonProperty("departureTime")]
        public DateTimeOffset DepartureTime { get; set; }

        /// <summary>
        /// Arrival Time.
        /// </summary>
        [JsonProperty("arrivalTime")]
        public DateTimeOffset? ArrivalTime { get; set; }

        /// <summary>
        /// Name of captain.
        /// </summary>
        [JsonProperty("captain")]
        public string Captain { get; set; }

        /// <summary>
        /// Name of Chief Engineer.
        /// </summary>
        [JsonProperty("chiefEng")]
        public string ChiefEng { get; set; }

        /// <summary>
        /// Total cargo weight on departure.
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
        /// Number of reefers on departure.
        /// </summary>
        [JsonProperty("cargoReefers")]
        public int? CargoReefers { get; set; }

        /// <summary>
        /// Total weight of ballast water on departure.
        /// </summary>
        [JsonProperty("ballastWeight")]
        public double? BallastWeight { get; set; }
    }
}