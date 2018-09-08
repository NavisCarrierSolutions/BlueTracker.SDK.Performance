using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class FreshWaterConsumption
    {
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterConsumptionKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}