using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents scrubber residue quantities for the reporting period.
    /// </summary>
    public class ScrubberResidue
    {
        /// <summary>
        /// Gets or sets the scrubber residue type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberResidueType? Type { get; set; }

        /// <summary>
        /// Gets or sets the scrubber residue mass in kilograms.
        /// </summary>
        [JsonProperty("massKg")]
        public double? MassKg { get; set; }

        /// <summary>
        /// Gets or sets the scrubber residue volume in litres.
        /// </summary>
        [JsonProperty("volumeLitre")]
        public double? VolumeLitre { get; set; }
    }
}
