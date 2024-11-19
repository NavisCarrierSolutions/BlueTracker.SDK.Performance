using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the fuel consumption of a fuel by a fuel consumer. You can either use "Amount" or a combination of "Volume" and "Density". If both is provided the value of "Amount" is used
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
        public double? Amount { get; set; }

        /// <summary>
        /// Amount of fuel consumed in cubic meters. 
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Density of fuel consumed.
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Temperature of consumed fuel.
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }

        /// <summary>
        /// A detailed description of the fuel type used.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }

        /// <summary>
        /// Unique ID of bunker charge in reporting system.
        /// </summary>
        public string BunkerChargeId { get; set; }

        /// <summary>
        /// Unique name of bunker charge.
        /// </summary>
        public string BunkerChargeName { get; set; }
    }
}