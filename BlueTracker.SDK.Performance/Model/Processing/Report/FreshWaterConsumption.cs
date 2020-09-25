using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class FreshWaterConsumption
    {
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions Purpose { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}