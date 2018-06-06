using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// Discharge information.
    /// </summary>
    public class Discharge
    {
        /// <summary>
        /// List of fresh water discharges.
        /// </summary>
        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterDischarge> FreshWater { get; set; }
    }
}
