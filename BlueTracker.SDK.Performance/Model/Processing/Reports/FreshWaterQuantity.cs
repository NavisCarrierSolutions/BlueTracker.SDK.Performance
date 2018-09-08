using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class FreshWaterQuantity
    {
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }
    }
}