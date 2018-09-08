using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// Provides information about consumed fresh water.
    /// </summary>
    public class FreshWaterConsumption
    {
        /// <summary>
        /// Kind of fresh water. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterConsumptionKindOptions Kind { get; set; }

        /// <summary>
        /// Volume of fresh water (cubic metres).
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}
