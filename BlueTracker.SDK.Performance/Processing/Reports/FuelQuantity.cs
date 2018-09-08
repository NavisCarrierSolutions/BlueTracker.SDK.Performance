using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class FuelQuantity
    {
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }
    }
}