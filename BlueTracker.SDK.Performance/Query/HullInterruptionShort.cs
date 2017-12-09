using System;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Hull interruption DTO with fewer properties than the whole object.
    /// </summary>
    public class HullInterruptionShort
    {
        /// <summary>
        /// ID of hull interruption.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Start date of hull interruption (including offset to UTC.)
        /// </summary>
        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End date of hull interruption (including offset to UTC.)
        /// </summary>
        [JsonProperty("endTime")]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Type of hull interruption.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullInterruptionType Type { get; set; }
    }
}
