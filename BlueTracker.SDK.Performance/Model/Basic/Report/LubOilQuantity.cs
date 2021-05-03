using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Lub oil ROB quantities.
    /// </summary>
    public class LubOilQuantity
    {
        /// <summary>
        /// Aggregate type.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilAggregateOptions Aggregate { get; set; }

        /// <summary>
        /// Kind of lub oil. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        /// <summary>
        /// Amount of lub oil. (litres)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Lub oil type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}