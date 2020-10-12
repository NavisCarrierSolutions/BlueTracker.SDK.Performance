using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class GainLossLubOilQuantity : LubOilQuantity
    {
        [JsonProperty(PropertyName = "reason")]
        public GainLossReason Reason { get; set; }
    }
}
