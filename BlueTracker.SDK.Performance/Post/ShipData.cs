using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Post
{
    /// <summary>
    /// A ship.
    /// </summary>
    public class ShipData
    {
        /// <summary>
        /// 7-digit IMO Number of the ship
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of the ship
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Alternative name of the ship (eg. Chartername)
        /// </summary>
        [JsonProperty("alternativeName")]
        public string AlternativeName { get; set; }

        /// <summary>
        /// ID of ship class associated to ship.
        /// </summary>
        [JsonProperty("shipClassId")]
        public int? ShipClassId { get; set; }

        /// <summary>
        /// ID of port of registry. If you only have an UNLOC you can leave Id out and set only UNLOC
        /// </summary>
        [JsonProperty("portOfRegistryId")]
        public int? PortOfRegistryId { get; set; }

        /// <summary>
        /// Unlocode of port of registry.
        /// </summary>
        [JsonProperty("portOfRegistryUnloc")]
        public string PortOfRegistryUnloc { get; set; }

        /// <summary>
        /// ID of owner.
        /// </summary>
        [JsonProperty("ownerId")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Email address of ship.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Second email address of ship.
        /// </summary>
        [JsonProperty("secondEmailAddress")]
        public string SecondEmailAddress { get; set; }
    }
}