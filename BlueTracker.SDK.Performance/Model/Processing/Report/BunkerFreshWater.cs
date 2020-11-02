using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class BunkerFreshWater
    {
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterTypeOptions Type { get; set; }

        [JsonProperty(PropertyName = "freshWaterKind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions FreshWaterKind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }
    }
}
