using System;
using System.ComponentModel.DataAnnotations;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// A hull event.
    /// </summary>
    public class HullEvent
    {
        /// <summary>
        /// ID of hull event.
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
        /// Version Stamp when the hull event was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }

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
        public HullEventType Type { get; set; }

        /// <summary>
        /// Maximally allowed annual speed loss degradation.
        /// </summary>
        [JsonProperty("maxYearlyDegradation")]
        public double? MaxYearlyDegradation { get; set; }

        /// <summary>
        /// Initial speed loss at hull event date.
        /// </summary>
        [JsonProperty("initialSpeedLoss")]
        public double? InitialSpeedLoss { get; set; }

        /// <summary>
        /// Allowed deviation from the maximally allowed yearly degradation (minor).
        /// </summary>
        [JsonProperty("toleranceMinor")]
        public double? ToleranceMinor { get; set; }

        /// <summary>
        /// Allowed deviation from the maximally allowed yearly degradation (major).
        /// </summary>
        [JsonProperty("toleranceMajor")]
        public double? ToleranceMajor { get; set; }

        /// <summary>
        /// Remarks of hull event.
        /// </summary>
        [MaxLength(256)]
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// Timestamp when hull event was created.
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
    }
}
