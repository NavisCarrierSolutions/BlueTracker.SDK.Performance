using System;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Hull event DTO with fewer properties than the whole object.
    /// </summary>
    public class HullEventShort
    {
        /// <summary>
        /// ID of hull event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Timestamp of hull event (including offset to UTC.)
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// Type of hull event.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullEventType HullEventType { get; set; }
    }
}
