using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     Fuel flow of a fuel consumer.
    /// </summary>
    public class FuelCounter
    {
        /// <summary>
        ///     Type of fuel flow (Consumption, Supply, Return)
        /// </summary>
        [JsonProperty(PropertyName = "flowType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelFlowOptions FlowType { get; set; }

        /// <summary>
        ///     Kind of fuel in use.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        /// <summary>
        ///     Detailed description of the fuel type used.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }

        /// <summary>
        ///     Fuel temperature at flow meter. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }

        /// <summary>
        ///     Fuel temperature at engine inlet. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "inletTemp")]
        public double? InletTemp { get; set; }

        /// <summary>
        ///     Actual density of fuel. (kg/m3)
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        ///    The total volume count of the pulse per liter counter. (1 Pulse/liter)
        /// </summary>
        [JsonProperty(PropertyName = "totalVolumeCount")]
        public int TotalVolumeCount { get; set; }
    }
}