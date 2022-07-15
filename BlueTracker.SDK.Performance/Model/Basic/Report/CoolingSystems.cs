using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the cooling systems on board.
    /// </summary>
    public class CoolingSystems
    {
        /// <summary>
        /// Fresh water cooling systems.
        /// </summary>
        [JsonProperty("freshWaterCoolingSystems")]
        public List<FreshWaterCoolingSystem> FreshWaterCoolingSystems { get; set; }

        /// <summary>
        /// Sea water cooling systems.
        /// </summary>
        [JsonProperty("seaWaterCoolingSystems")]
        public List<SeaWaterCoolingSystem> SeaWaterCoolingSystems { get; set; }
    }
}
