using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// A pump
    /// </summary>
    public class Pump
    {
        /// <summary>
        /// Running signal
        /// </summary>
        [JsonProperty(PropertyName = "runningSignal")]
        public bool? RunningSignal { get; set; }

        /// <summary>
        /// Power consumption
        /// </summary>
        [JsonProperty(PropertyName = "powerConsumption")]
        public double? PowerConsumption { get; set; }

        /// <summary>
        /// Energy
        /// </summary>
        [JsonProperty(PropertyName = "energy")]
        public double? Energy { get; set; }

        /// <summary>
        /// Current
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public double? Current { get; set; }

        /// <summary>
        /// Voltage
        /// </summary>
        [JsonProperty(PropertyName = "voltage")]
        public double? Voltage { get; set; }

        /// <summary>
        /// Frequency
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public double? Frequency { get; set; }

        /// <summary>
        /// Running hours
        /// </summary>
        [JsonProperty(PropertyName = "runningHours")]
        public double? RunningHours { get; set; }

        /// <summary>
        /// Temperature
        /// </summary>
        [JsonProperty(PropertyName = "temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Inlet pressure
        /// </summary>
        [JsonProperty(PropertyName = "inletPressure")]
        public double? InletPressure { get; set; }

        /// <summary>
        /// Oulet pressure
        /// </summary>
        [JsonProperty(PropertyName = "ouletPressure")]
        public double? OuletPressure { get; set; }
    }
}