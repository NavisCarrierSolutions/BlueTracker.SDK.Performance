using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class FuelQuantity
    {
        /// <summary>
        /// Unique ID of bunker charge in reporting system.
        /// </summary>
        public string BunkerChargeId { get; set; }

        /// <summary>
        /// Unique name of bunker charge.
        /// </summary>
        public string BunkerChargeName { get; set; }

        /// <summary>
        /// Kind of fuel. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        /// <summary>
        /// Amount of fuel. (tons)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Fuel type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }
    }
}