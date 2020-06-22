using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Provides information about consumed lub oil by aggregate type.
    /// </summary>
    public class LubOilAggregateConsumption : LubOilConsumption
    {
        /// <summary>
        /// Consuming aggregate type.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }
    }
}
