using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Post
{
    /// <summary>
    /// The consumption curve
    /// </summary>
    public class ConsumptionCurve
    {
        /// <summary>
        /// The Id of the charter curve
        /// </summary>
        [JsonProperty("charterCurveId")]
        public int CharterCurveId { get; set; }

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
