using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class FuelType
    {
        /// <summary>
        /// Fuel grade. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "grade")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelGradeOptions? Grade { get; set; }

        /// <summary>
        /// Fuel grade. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "isograde2024")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IsoGradeOptions2024? IsoGrade2024 { get; set; }

        /// <summary>
        /// ISO version of fuel grade.
        /// </summary>
        [JsonProperty("isoVersion")]
        public string IsoVersion { get; set; }

        /// <summary>
        /// Density of fuel at 15°C. (kg/m3)
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Lower calorific value of fuel. (kJ/kg)
        /// </summary>
        [JsonProperty(PropertyName = "lcv")]
        public double? LCV { get; set; }

        /// <summary>
        /// Sulfur content of fuel. (%)
        /// </summary>
        [JsonProperty(PropertyName = "sulphur")]
        public double? Sulphur { get; set; }

        /// <summary>
        /// Indicates whether the sulphur content is estimated.
        /// </summary>
        [JsonProperty(PropertyName = "sulphurEstimated")]
        public bool SulphurEstimated { get; set; }

        /// <summary>
        /// Co2 factor of fuel
        /// </summary>
        [JsonProperty(PropertyName = "co2Factor")]
        public double? Co2Factor { get; set; }

        /// <summary>
        /// Kinematic viscosity. (cSt)
        /// </summary>
        [JsonProperty(PropertyName = "kinematicViscosity")]
        public double? KinematicViscosity { get; set; }
    }
}