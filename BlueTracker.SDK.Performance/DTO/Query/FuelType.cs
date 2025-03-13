using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class FuelType
    {
        [JsonProperty(PropertyName = "grade")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelGradeOptions? Grade { get; set; }

        /// <summary>
        /// Fuel grade options according ISO 8217 - 2024.
        /// </summary>
        [JsonProperty(PropertyName = "isograde2024")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IsoGradeOptions2024? IsoGrade2024 { get; set; }

        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        [JsonProperty(PropertyName = "lcv")]
        public double? LCV { get; set; }

        [JsonProperty(PropertyName = "sulphur")]
        public double? Sulphur { get; set; }

        [JsonProperty(PropertyName = "sulphurEstimated")]
        public bool SulphurEstimated { get; set; }

        [JsonProperty(PropertyName = "co2Factor")]
        public double? Co2Factor { get; set; }

        /// <summary>
        /// Bio fuel details.
        /// </summary>
        [JsonProperty(PropertyName = "bioFuelBlendDetails")]
        public BioFuelBlend BioFuelBlendDetails { get; set; }

        [JsonProperty(PropertyName = "kinematicViscosity")]
        public double? KinematicViscosity { get; set; }
    }
}