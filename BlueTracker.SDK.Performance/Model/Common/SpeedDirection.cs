using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Represents a speed and direction information.
    /// </summary>
    public class SpeedDirection
    {
        /// <summary>
        /// True speed. (Unit: m/s)
        /// </summary>
        [JsonProperty(PropertyName = "speedTrue")]
        public double? SpeedTrue { get; set; }

        /// <summary>
        /// Relative speed (to the vessel). (Unit: m/s)
        /// </summary>
        [JsonProperty(PropertyName = "speedRel")]
        public double? SpeedRel { get; set; }

        /// <summary>
        /// True direction (relative to north). (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "directionTrue")]
        public double? DirectionTrue { get; set; }

        /// <summary>
        /// Relative direction (relative to ships head). (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "directionRel")]
        public double? DirectionRel { get; set; }
    }
}