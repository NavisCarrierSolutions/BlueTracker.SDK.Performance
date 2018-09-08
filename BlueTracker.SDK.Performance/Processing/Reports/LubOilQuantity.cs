using BlueTracker.SDK.Performance.Enums;
using BlueTracker.SDK.Performance.Processing.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class LubOilQuantity
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}