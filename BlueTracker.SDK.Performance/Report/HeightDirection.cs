using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// Generic height and direction (true/relative) description.
    /// </summary>
    public struct HeightDirection
    {
        /// <summary>
        /// Height. (Unit: m)
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public double? Height { get; set; }
        
        /// <summary>
        /// True direction (relative to north). (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "directionTrue")]
        public double? DirectionTrue { get; set; }

        /// <summary>
        /// Relative direction (to ships head). (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "directionRel")]
        public double? DirectionRel { get; set; }
    }
}