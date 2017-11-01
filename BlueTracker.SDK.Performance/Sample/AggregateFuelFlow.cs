using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Fuel flow of an aggregate
    /// </summary>
    public class AggregateFuelFlow : FuelFlow
    {
        /// <summary>
        /// The type of the aggregate
        /// </summary>
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }
    }
}
