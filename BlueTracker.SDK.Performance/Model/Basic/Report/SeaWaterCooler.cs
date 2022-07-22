using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the sea water cooling system on board.
    /// </summary>
    public class SeaWaterCooler
    {
        /// <summary>
        /// Cooling systems
        /// </summary>
        [JsonProperty(PropertyName = "coolingSystems")]
        public List<CoolingSystem> CoolingSystems { get; set; }
    }
}
