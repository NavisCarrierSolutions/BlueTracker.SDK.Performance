using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Represents the navigational area of a vessel.
    /// </summary>
    public class Navigation
    {
        /// <summary>
        ///  Position of the vessel at reporting time.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }
        /// <summary>
        /// Heading of vessel (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "heading")]
        public double? Heading { get; set; }

        /// <summary>
        /// Course made good (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "courseMadeGood")]
        public double? CourseMadeGood { get; set; }

        /// <summary>
        /// Speed over ground (Unit: knots)
        /// </summary>
        [JsonProperty(PropertyName = "speedOverGround")]
        public double? SpeedOverGround { get; set; }

        /// <summary>
        /// Speed through water (Unit: knots)
        /// </summary>
        [JsonProperty(PropertyName = "speedThroughWater")]
        public double? SpeedThroughWater { get; set; }

        /// <summary>
        /// Draft details.
        /// </summary>
        [JsonProperty(PropertyName = "draft")]
        public Draft Draft { get; set; }

        /// <summary>
        /// Trim of vessel (Unit: meters)
        /// </summary>
        [JsonProperty(PropertyName = "trim")]
        public double? Trim { get; set; }
    }
}
