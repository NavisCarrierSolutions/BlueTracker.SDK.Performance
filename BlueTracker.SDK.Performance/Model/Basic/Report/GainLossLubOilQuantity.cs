using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class GainLossLubOilQuantity : LubOilQuantity
    {
        /// <summary>
        /// Gain/Loss reason.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public GainLossReason Reason { get; set; }
    }
}
