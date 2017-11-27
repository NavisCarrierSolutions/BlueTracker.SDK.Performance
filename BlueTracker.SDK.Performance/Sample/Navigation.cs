using BlueTracker.SDK.Performance.Core;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Navigational data.
    /// </summary>
    public class Navigation
    {
        /// <summary>
        /// Heading of ship. (degrees)
        /// </summary>
        [JsonProperty(PropertyName = "heading")]
        public double? Heading { get; set; }

        /// <summary>
        /// Course made good. (degrees)
        /// </summary>
        [JsonProperty(PropertyName = "courseMadeGood")]
        public double? CourseMadeGood { get; set; }

        /// <summary>
        /// Speed over ground. (knots)
        /// </summary>
        [JsonProperty(PropertyName = "speedOverGround")]
        public double? SpeedOverGround { get; set; }

        /// <summary>
        /// Speed through water. (knots)
        /// </summary>
        [JsonProperty(PropertyName = "speedThroughWater")]
        public double? SpeedThroughWater { get; set; }

        /// <summary>
        /// Trim. (meter)
        /// </summary>
        [JsonProperty(PropertyName = "trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Draft data.
        /// </summary>
        [JsonProperty(PropertyName = "draft")]
        public Draft Draft { get; set; }
    }
}
