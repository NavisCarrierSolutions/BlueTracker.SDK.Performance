using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Details of fuel type.
    /// </summary>
    public class FuelType
    {
        /// <summary>
        /// Factor of (Unit kg/kwh)
        /// </summary>
        [JsonProperty(PropertyName = "co2Factor")]
        public double? Co2Factor { get; set; }

        /// <summary>
        /// Density of consumed fuel at 15°C
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Fuel grade according ISO 8217.
        /// </summary>
        [JsonProperty(PropertyName = "grade")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelGradeOptions? Grade { get; set; }

        /// <summary>
        /// Lower Calorific Value of fuel (Unit: kJ/kg)
        /// </summary>
        [JsonProperty(PropertyName = "lcv")]
        public  double? Lcv { get; set; }

        /// <summary>
        /// Sulphur content of fuel (Unit: %)
        /// </summary>
        [JsonProperty(PropertyName = "sulphur")]
        public double? Sulphur { get; set; }
    }
}
