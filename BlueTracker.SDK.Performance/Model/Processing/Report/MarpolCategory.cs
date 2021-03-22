using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class MarpolCategory
    {
        /// <summary>
        /// Defines the waste main type.
        /// </summary>
        [JsonProperty(PropertyName = "wasteMainType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WasteMainType? WasteMainType { get; set; }

        /// <summary>
        /// Defines the waste sub type.
        /// </summary>
        [JsonProperty(PropertyName = "wasteSubType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WasteSubType? WasteSubType { get; set; }
    }
}
