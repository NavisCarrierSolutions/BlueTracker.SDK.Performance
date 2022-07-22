using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the auxiliary systems on board.
    /// </summary>
    public class AuxiliarySystems
    {
        /// <summary>
        /// Pumps
        /// </summary>
        [JsonProperty("pumps")]
        public Pumps Pumps { get; set; }

        /// <summary>
        /// Sea water cooler system
        /// </summary>
        [JsonProperty("seaWaterCooler")]
        public SeaWaterCooler SeaWaterCooler { get; set; }
    }
}
