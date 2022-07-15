using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents a pump.
    /// </summary>
    public class Pump : ElectricalMotor
    {
        /// <summary>
        /// Name of pump
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
