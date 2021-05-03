using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class WasteDisposal
    {
        /// <summary>
        /// Volume of disposed waste. (cubic metres)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Waste disposal MARPOL category.
        /// </summary>
        [JsonProperty(PropertyName = "marpolCategory")]
        public MarpolCategory MarpolCategory { get; set; }

        /// <summary>
        /// Location where the waste disposal happened.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WasteDisposalLocation? Location { get; set; }

        /// <summary>
        /// Defines the distance (in nautical miles) from the nearest land for a disposal at sea.
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WasteDisposalDistance? Distance { get; set; }
    }
}
