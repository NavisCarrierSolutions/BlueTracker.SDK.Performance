using BlueTracker.SDK.Performance.Core;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Post
{
    /// <summary>
    /// Tzhe sfoc curve
    /// </summary>
    public class SfocCurve
    {
        /// <summary>
        /// The name of sfoc curve
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The description of sfoc curve
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The definition of sfoc curve
        /// </summary>
        [JsonProperty("definition")]
        public SfocCurveDefinition Definition { get; set; }

        /// <summary>
        /// Reason of change
        /// </summary>
        [JsonProperty("changeReason")]
        public string ChangeReason { get; set; }
    }
}
