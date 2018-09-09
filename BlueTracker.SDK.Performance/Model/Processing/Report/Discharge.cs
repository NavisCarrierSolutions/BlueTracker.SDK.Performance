using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class Discharge
    {
        [JsonProperty("oilyWater")]
        public List<OilyWaterDischarge> OilyWater { get; set; }

        public Dictionary<OilyWaterDischargeMethods, double?> TotalOilyWaterDischargeMethod { get; set; }
    }
}