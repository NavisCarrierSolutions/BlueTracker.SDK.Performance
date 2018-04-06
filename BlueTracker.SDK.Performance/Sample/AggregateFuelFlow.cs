using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// Fuel flow of an aggregate.
    /// </summary>
    public class AggregateFuelFlow : FuelFlow
    {
        /// <summary>
        /// Consuming aggregate type.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }
    }
}
