using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class GainLossLubOilQuantity : LubOilQuantity
    {
        /// <summary>
        /// Gain/Loss reason.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GainLossReason Reason { get; set; }
    }
}
