using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class BunkerLubOil
    {
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilAggregateOptions Aggregate { get; set; }

        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        [JsonProperty(PropertyName = "bdnNumber")]
        public string BdnNumber { get; set; }
    }
}
