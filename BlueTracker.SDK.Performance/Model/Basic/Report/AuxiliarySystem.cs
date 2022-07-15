using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the auxiliary systems on board.
    /// </summary>
    public class AuxiliarySystem
    {
        /// <summary>
        /// Cooling systems
        /// </summary>
        [JsonProperty("coolingSystems")]
        public CoolingSystems CoolingSystems { get; set; }

        /// <summary>
        /// Pumps
        /// </summary>
        [JsonProperty("pumps")]
        public Pumps Pumps { get; set; }
    }
}
