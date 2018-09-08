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
        /// List of oily water discharges.
        /// </summary>
        [JsonProperty(PropertyName = "oilyWater")]
        public List<OilyWaterDischarge> OilyWater { get; set; }
    }
}
