using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents an electrical motor.
    /// </summary>
    public class ElectricalMotor : EnergyConsumer
    {
        /// <summary>
        /// Load of motor (%).
        /// </summary>
        [JsonProperty("load")]
        public double? Load { get; set; }
    }
}
