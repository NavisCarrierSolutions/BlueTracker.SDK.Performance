using System;
using System.ComponentModel.DataAnnotations;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// A hull interruption.
    /// </summary>
    public class HullInterruption
    {
        /// <summary>
        /// ID of hull interruption.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        [MaxLength(50)]
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        [JsonProperty("ship")]
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Version Stamp when the hull interruption was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }

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

        /// <summary>
        /// Remarks of hull interruption.
        /// </summary>
        [MaxLength(256)]
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
    }
}
