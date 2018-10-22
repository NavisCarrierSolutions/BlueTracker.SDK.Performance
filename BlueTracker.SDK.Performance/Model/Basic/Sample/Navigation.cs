using BlueTracker.SDK.Performance.Model.Common;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Navigational data.
    /// </summary>
    public class Navigation
    {
        /// <summary>
        /// Position of ship.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }

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
        /// Speed of current (knots)
        /// </summary>
        [JsonProperty(PropertyName = "speedOfCurrent")]
        public double? SpeedOfCurrent { get; set; }

        /// <summary>
        /// Trim. (meter)
        /// </summary>
        [JsonProperty(PropertyName = "trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Rate of turn (deg/minute)
        /// </summary>
        [JsonProperty(PropertyName = "rateOfTurn")]
        public double? RateOfTurn { get; set; }

        /// <summary>
        /// Rudder angle mean (degrees)
        /// </summary>
        [JsonProperty(PropertyName = "rudderAngleMean")]
        public double? RudderAngleMean { get; set; }

        /// <summary>
        /// Rudder angle port sensor (degrees)
        /// </summary>
        [JsonProperty(PropertyName = "rudderAnglePortSensor")]
        public double? RudderAnglePortSensor { get; set; }

        /// <summary>
        /// Rudder angle starboard sensor (degrees)
        /// </summary>
        [JsonProperty(PropertyName = "rudderAngleStbSensor")]
        public double? RudderAngleStbSensor { get; set; }

        /// <summary>
        /// Draft data.
        /// </summary>
        [JsonProperty(PropertyName = "draft")]
        public Draft Draft { get; set; }
    }
}
