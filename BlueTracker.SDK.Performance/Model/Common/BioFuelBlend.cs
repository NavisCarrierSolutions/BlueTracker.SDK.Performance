using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class BioFuelBlend
    {
        /// <summary>
        /// Biofuel used in blend. (enumeration)
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
        /// The percentage of biofuel used in blend. (%)
        /// </summary>
        [JsonProperty(PropertyName = "percentageOfBioFuelInBlend")]
        public double? PercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        /// Amount of biofuel in blend. (mt)
        /// </summary>
        [JsonProperty(PropertyName = "bioBlendAmount")]
        public double? BioBlendAmount { get; set; }

        /// <summary>
        /// Amount of fossil fuel in blend. (mt)
        /// </summary>
        [JsonProperty(PropertyName = "fossilBlendAmount")]
        public double? FossilBlendAmount { get; set; }
    }
}
