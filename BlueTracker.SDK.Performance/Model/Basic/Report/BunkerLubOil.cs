using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class BunkerLubOil
    {
        /// <summary>
        /// Circulation oil aggregate type.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilAggregateOptions Aggregate { get; set; }

        /// <summary>
        /// Kind of luboil. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        /// <summary>
        /// Amount of luboil bunkered. (litres)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Luboil type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        [JsonProperty("bdnNumber")]
        public string BdnNumber { get; set; }
    }
}
