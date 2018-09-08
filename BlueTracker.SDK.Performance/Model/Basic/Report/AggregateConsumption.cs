using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Report
{
    public class AggregateConsumption : Consumption
    {
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }
    }
}