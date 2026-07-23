using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents a scrubber chemical quantity entry.
    /// </summary>
    public class ScrubberChemicalEntry
    {
        /// <summary>
        /// Gets or sets the scrubber chemical type.
        /// </summary>
        [JsonProperty("chemicalType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberChemicalType? ChemicalType { get; set; }

        /// <summary>
        /// Gets or sets the amount of scrubber chemical in litres.
        /// </summary>
        [JsonProperty("chemicalAmountLitre")]
        public double? ChemicalAmountLitre { get; set; }

        /// <summary>
        /// Gets or sets the WTU chemical used for the scrubber entry.
        /// </summary>
        [JsonProperty("wtuChemical")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberWtuChemical? WtuChemical { get; set; }

        /// <summary>
        /// Gets or sets the WTU amount in litres.
        /// </summary>
        [JsonProperty("wtuAmountLitre")]
        public double? WtuAmountLitre { get; set; }
    }
}
