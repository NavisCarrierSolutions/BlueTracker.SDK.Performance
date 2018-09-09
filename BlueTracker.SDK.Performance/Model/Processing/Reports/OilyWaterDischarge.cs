using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Reports
{
    public class OilyWaterDischarge
    {
        [JsonProperty(PropertyName = "method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OilyWaterDischargeMethods Method { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}