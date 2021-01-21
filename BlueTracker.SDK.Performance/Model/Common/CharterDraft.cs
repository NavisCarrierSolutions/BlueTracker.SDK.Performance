using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Draft details.
    /// </summary>
    public class CharterDraft
    {
        /// <summary>
        /// Draft [m].
        /// </summary>
        [JsonProperty("draft")]
        public double? Draft { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
