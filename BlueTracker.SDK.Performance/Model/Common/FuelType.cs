using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Details of fuel type.
    /// </summary>
    public class FuelType
    {
        /// <summary>
        /// Fuel grade according ISO 8217.
        /// </summary>
        [JsonProperty(PropertyName = "grade")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelGradeOptions? Grade { get; set; }

        /// <summary>
        /// Density of fuel (Unit: kg/m3)
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Lower Calorific Value of fuel (Unit: kJ/kg)
        /// </summary>
        [JsonProperty(PropertyName = "lcv")]
        public double? LCV { get; set; }

        /// <summary>
        /// Sulphur content of fuel (Unit: %)
        /// </summary>
        [JsonProperty(PropertyName = "sulphur")]
        public double? Sulphur { get; set; }

        /// <summary>
        /// Co2 factor of fuel
        /// </summary>
        [JsonProperty(PropertyName = "co2Factor")]
        public double? Co2Factor { get; set; }

        /// <summary>
        /// Energy content. (MJ)
        /// </summary>
        [JsonProperty(PropertyName = "energyContent")]
        public double? EnergyContent { get; set; }

        /// <summary>
        /// Bio fuel details.
        /// </summary>
        [JsonProperty(PropertyName = "bioFuelBlendDetails")]
        public BioFuelBlend BioFuelBlendDetails { get; set; }

        /// <summary>
        /// Kinematic viscosity. (cSt)
        /// </summary>
        [JsonProperty(PropertyName = "kinematicViscosity")]
        public double? KinematicViscosity { get; set; }
    }
}