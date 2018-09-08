using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Core
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
    }
}