using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents an interruption in the on-shore power supply, including its start and end times and the reason for
    /// the interruption.
    /// </summary>
    /// <remarks>This class is used to capture details about periods when on-shore power supply is
    /// unavailable, such as for maintenance or unexpected outages.</remarks>
    public class OnShorePowerSupplyInterruption
    {
        /// <summary>
        /// Gets or sets the start time of the interruption, if available.
        /// </summary>
        [JsonProperty("interruptionStart")]
        public DateTime? InterruptionStart { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the interruption ends, if available.
        /// </summary>
        [JsonProperty("interruptionEnd")]
        public DateTime? InterruptionEnd { get; set; }

        /// <summary>
        /// Gets or sets the reason for the interruption of on-shore power supply.
        /// </summary>
        [JsonProperty("interruptionReason")]
        public OnShorePowerSupplyInterruptionReason InterruptionReason { get; set; }
    }
}
