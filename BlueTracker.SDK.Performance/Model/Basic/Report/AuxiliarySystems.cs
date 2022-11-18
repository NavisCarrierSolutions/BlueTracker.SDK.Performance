using Newtonsoft.Json;
using System.Collections.Generic;

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
        public List<Pump> Pumps { get; set; }

        /// <summary>
        /// Cooling systems
        /// </summary>
        [JsonProperty(PropertyName = "coolingSystems")]
        public List<CoolingSystem> CoolingSystems { get; set; }
    }
}
