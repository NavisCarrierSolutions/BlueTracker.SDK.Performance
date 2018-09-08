using System.Collections.Generic;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class Discharge
    {
        [JsonProperty("oilyWater")]
        public List<OilyWaterDischarge> OilyWater { get; set; }

        public Dictionary<OilyWaterDischargeMethods, double?> TotalOilyWaterDischargeMethod { get; set; }
    }
}