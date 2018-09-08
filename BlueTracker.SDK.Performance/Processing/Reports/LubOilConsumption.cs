using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class LubOilConsumption
    {
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }

        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }

        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}