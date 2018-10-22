using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Represents a cargohold fan
    /// </summary>
    public class CargoHoldFan : Fan
    {
        /// <summary>
        /// Temperature of Cargohold (C°)
        /// </summary>
        [JsonProperty("cargoHoldTemperature")]
        public double? CargoHoldTemperature { get; set; }
    }
}
