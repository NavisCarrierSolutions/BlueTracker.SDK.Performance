using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Oily water discharge information.
    /// </summary>
    public class OilyWaterDischarge
    {
        /// <summary>
        /// Method used to discharge oily water. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OilyWaterDischargeMethods Method { get; set; }

        /// <summary>
        /// Volume of discharged oily water. (cubic metres)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}
