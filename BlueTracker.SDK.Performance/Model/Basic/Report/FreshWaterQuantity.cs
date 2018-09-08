using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Report
{
    public class FreshWaterQuantity
    {
        /// <summary>
        /// Kind of fresh water. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions Kind { get; set; }

        /// <summary>
        /// Amount of fresh water remain on board. (litres)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }
    }
}