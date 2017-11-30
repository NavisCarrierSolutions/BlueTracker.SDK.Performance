using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// Represents the fuel consumption of a fuel by a fuel consumer.
    /// </summary>
    public class Consumption
    {
        /// <summary>
        /// The kind of fuel which was consumed.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        /// <summary>
        /// The amount of fuel which was consumed (Unit: metric tons).
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; set; }

        /// <summary>
        /// A detailed description of the fuel type used.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }
    }
}