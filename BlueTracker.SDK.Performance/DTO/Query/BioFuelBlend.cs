using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class BioFuelBlend
    {
        /// <summary>
        /// Bio fuel used in blend. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "bioBlend")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BioBlendOptions BioBlend { get; set; }
        /// <summary>
        /// Fossil fuel used in blend. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "fossilBlend")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions FossilBlend { get; set; }
        /// <summary>
        /// The percentage of bio fuel used in blend. (%)
        /// </summary>
        [JsonProperty(PropertyName = "percentageOfBioFuelInBlend")]
        public double? PercentageOfBioFuelInBlend { get; set; }
    }
}
