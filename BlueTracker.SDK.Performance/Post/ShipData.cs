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
    }
}