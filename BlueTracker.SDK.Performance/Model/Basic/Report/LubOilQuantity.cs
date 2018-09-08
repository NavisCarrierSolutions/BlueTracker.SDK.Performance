using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueCloud.DTO.Report
{
    /// <summary>
    /// Lub oil ROB quantities.
    /// </summary>
    public class LubOilQuantity
    {
        /// <summary>
        /// Aggregate type.
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
        /// Amount of luboil remain on board. (litres)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Luboil type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}