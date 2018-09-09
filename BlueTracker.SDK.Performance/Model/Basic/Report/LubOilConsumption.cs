using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Provides information about consumed luboil.
    /// </summary>
    public class LubOilConsumption
    {
        /// <summary>
        /// Consuming aggregate type.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AggregateOptions Aggregate { get; set; }

        /// <summary>
        /// Kind of luboil. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        /// <summary>
        /// Volume of luboil consumption. (litres)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Density of luboil.
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Luboil type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}
