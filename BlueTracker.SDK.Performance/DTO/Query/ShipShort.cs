using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Ship Base Data Short
    /// </summary>
    public class ShipShort
    {
        /// <summary>
        /// ID of ship.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of ship.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Short name of ship.
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Alternative name of ship.
        /// </summary>
        [JsonProperty("alternativeName")]
        public string AlternativeName { get; set; }

        /// <summary>
        /// Radio call sign of vessel.
        /// </summary>
        [JsonProperty("callSign")]
        public string CallSign { get; set; }

        /// <summary>
        /// Current change tracking version stamp.
        /// </summary>
        [JsonProperty("currentVersionStamp")]
        public long CurrentVersionStamp { get; set; }

        /// <summary>
        /// Name of ship class associated with ship.
        /// </summary>
        [JsonProperty("shipClassName")]
        public string ShipClassName { get; set; }

        /// <summary>
        /// Name of owner associated with ship.
        /// </summary>
        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        /// <summary>
        /// UN/LOCODE of port of registry.
        /// </summary>
        [JsonProperty("portOfRegistryUnloc")]
        public string PortOfRegistryUnloc { get; set; }
    }
}