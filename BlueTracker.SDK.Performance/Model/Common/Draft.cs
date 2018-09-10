using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Draft of vessel.
    /// </summary>
    public class Draft
    {
        /// <summary>
        /// Draft forward.
        /// </summary>
        [JsonProperty(PropertyName = "fwd")]
        public double? Fwd { get; set; }

        /// <summary>
        /// Draft midships.
        /// </summary>
        [JsonProperty(PropertyName = "mid")]
        public double? Mid { get; set; }

        /// <summary>
        /// Draft aft.
        /// </summary>
        [JsonProperty(PropertyName = "aft")]
        public double? Aft { get; set; }
    }
}