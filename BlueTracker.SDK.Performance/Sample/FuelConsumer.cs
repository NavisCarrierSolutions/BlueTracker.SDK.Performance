using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// A generic fuel consuming aggregate.
    /// </summary>
    public class FuelConsumer : Aggregate
    {
        /// <summary>
        /// The fuel flow at time stamp
        /// </summary>
        [JsonProperty(PropertyName = "fuelFlow")]
        public FuelFlow Consumption { get; set; }
    }
}
