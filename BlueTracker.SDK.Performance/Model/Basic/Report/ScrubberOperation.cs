using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents a scrubber operation interval and its associated measurements.
    /// </summary>
    public class ScrubberOperation
    {
        /// <summary>
        /// Gets or sets the start date and time of the scrubber operation.
        /// </summary>
        [JsonProperty("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the scrubber operation.
        /// </summary>
        [JsonProperty("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the exhaust stream covered by the scrubber operation.
        /// </summary>
        [JsonProperty("exhaustStream")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberExhaustStream? ExhaustStream { get; set; }

        /// <summary>
        /// Gets or sets the scrubber operating mode.
        /// </summary>
        [JsonProperty("scrubberMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberMode? ScrubberMode { get; set; }

        /// <summary>
        /// Gets or sets the desulphurization mode used during the scrubber operation.
        /// </summary>
        [JsonProperty("desulphurizationMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberDesulphurizationMode? DesulphurizationMode { get; set; }

        /// <summary>
        /// Gets or sets the measured SO2 to CO2 emission ratio.
        /// </summary>
        [JsonProperty("emissionRatioSo2ToCo2")]
        public double? EmissionRatioSo2ToCo2 { get; set; }

        /// <summary>
        /// Gets or sets the chemicals consumed during the scrubber operation.
        /// </summary>
        [JsonProperty("consumptions")]
        public List<ScrubberChemicalEntry> Consumptions { get; set; }
    }
}
