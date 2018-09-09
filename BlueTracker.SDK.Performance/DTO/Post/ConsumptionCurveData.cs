using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// The consumption curve
    /// </summary>
    public class ConsumptionCurveData
    {
        /// <summary>
        /// The name of the consumption curve
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The description of the consumption curve
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The definition of the consumption curve
        /// </summary>
        [JsonProperty("definition")]
        public CharterPartyDefinition Definition { get; set; }

        /// <summary>
        /// The type of consumption curve
        /// </summary>
        [JsonProperty("consumptionCurveType")]
        public ConsumptionCurveType ConsumptionCurveType { get; set; }

        /// <summary>
        /// The reason of change
        /// </summary>
        [JsonProperty("changeReason")]
        public string ChangeReason { get; set; }
    }
}
