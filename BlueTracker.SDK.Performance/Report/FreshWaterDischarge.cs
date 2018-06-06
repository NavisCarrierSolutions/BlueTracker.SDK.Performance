using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// Fresh water discharge information.
    /// </summary>
    public class FreshWaterDischarge
    {
        /// <summary>
        /// Method used to discharge fresh water. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterDischargeMethods Method { get; set; }

        /// <summary>
        /// Volume of discharged fresh water. (cubic metres)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}
