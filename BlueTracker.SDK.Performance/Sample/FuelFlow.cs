using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Represents the fuel flow of a fuel consumer
    /// </summary>
    public class FuelFlow
    {
        /// <summary>
        /// The consumed fuel kind.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions FuelKind { get; set; }

        /// <summary>
        /// A detailed description of the fuel type used.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType FuelType { get;set; }

        /// <summary>
        /// The temperature of the consumed fuel (Unit: °C)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }

        /// <summary>
        /// The density of the consumed fuel (Unit: kg/m3)
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// The volume of the consumed fuel (Unit: m3)
        /// </summary>
        [JsonProperty(PropertyName = "volumeFlow")]
        public double? VolumeFlow { get; set; }

        /// <summary>
        /// The mass of the consumed fuel (Unit: Metric Tons)
        /// </summary>
        [JsonProperty(PropertyName = "massFlow")]
        public double? MassFlow { get; set; }
    }
}
