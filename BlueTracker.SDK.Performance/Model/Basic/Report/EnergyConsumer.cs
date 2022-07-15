using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents an energy consumer.
    /// </summary>
    public class EnergyConsumer : Aggregate
    {
        /// <summary>
        /// Electrical power - rate at which electrical power is transferred (kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }

        /// <summary>
        /// Electrical energy - electrical energy consumption (kW/h)
        /// </summary>
        [JsonProperty(PropertyName = "energy")]
        public double? Energy { get; set; }
    }
}
