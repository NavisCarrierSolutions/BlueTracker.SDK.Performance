using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class FuelType
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelGradeOptions? Grade { get; set; }

        /// <summary>
        /// Fuel grade options according ISO 8217 - 2024.
        /// </summary>
        [JsonProperty(PropertyName = "isoGradeOptions2024")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IsoGradeOptions2024? IsoGradeOptions2024 { get; set; }

        public double? Density { get; set; }

        public double? LCV { get; set; }

        public double? Sulphur { get; set; }

        public bool SulphurEstimated { get; set; }
        public double? Co2Factor { get; set; }

        /// <summary>
        /// Bio fuel details.
        /// </summary>
        [JsonProperty(PropertyName = "bioFuelBlendDetails")]
        public BioFuelBlend BioFuelBlendDetails { get; set; }

        public double? KinematicViscosity { get; set; }
    }
}