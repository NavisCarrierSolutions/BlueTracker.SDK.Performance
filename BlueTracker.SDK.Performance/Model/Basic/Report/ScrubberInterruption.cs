using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents a scrubber interruption interval and its reason.
    /// </summary>
    public class ScrubberInterruption
    {
        /// <summary>
        /// Gets or sets the start date and time of the scrubber interruption.
        /// </summary>
        [JsonProperty("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the scrubber interruption.
        /// </summary>
        [JsonProperty("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the exhaust stream affected by the interruption.
        /// </summary>
        [JsonProperty("exhaustStream")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberExhaustStream? ExhaustStream { get; set; }

        /// <summary>
        /// Gets or sets the reason for the scrubber interruption.
        /// </summary>
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberInterruptionReason? Reason { get; set; }

        /// <summary>
        /// Gets or sets additional comments for the scrubber interruption.
        /// </summary>
        [JsonProperty("comments")]
        public string Comments { get; set; }
    }
}
