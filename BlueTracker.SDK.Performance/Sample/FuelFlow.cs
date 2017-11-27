using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using BlueTracker.SDK.Performance.Report;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Fuel flow of a fuel consumer.
    /// </summary>
    public class FuelFlow
    {
        /// <summary>
        /// Kind of fuel in use.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions FuelKind { get; set; }

        /// <summary>
        /// Detailed description of the fuel type used.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType FuelType { get;set; }

        /// <summary>
        /// Temperature of fuel. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }

        /// <summary>
        /// Actual density of fuel. (kg/m3)
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Volume flow of the consumed fuel. (m3/h)
        /// </summary>
        [JsonProperty(PropertyName = "volumeFlow")]
        public double? VolumeFlow { get; set; }

        /// <summary>
        /// Mass flow of the consumed fuel. (mt/h)
        /// </summary>
        [JsonProperty(PropertyName = "massFlow")]
        public double? MassFlow { get; set; }
    }
}
