using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Provides information about consumed fresh water.
    /// </summary>
    public class FreshWaterConsumption
    {
        /// <summary>
        /// Purpose of fresh water. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions Purpose { get; set; }

        /// <summary>
        /// Volume of fresh water (cubic metres).
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}
