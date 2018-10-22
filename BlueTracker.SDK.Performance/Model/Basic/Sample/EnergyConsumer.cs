using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class EnergyConsumer : Aggregate
    {
        /// <summary>
        /// Electrical voltage - Voltage, electric potential difference, electric pressure or electric tension (V)
        /// </summary>
        [JsonProperty(PropertyName = "voltage")]
        public double? Voltage { get; set; }

        /// <summary>
        /// Electrical current - flow of electric charge (A)
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public double? Current { get; set; }

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
