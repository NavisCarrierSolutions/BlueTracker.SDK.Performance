using System;
using BlueTracker.SDK.Performance.Model.Common;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
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
        /// Duration of sailing during reporting period. (Unit: hours)
        /// </summary>
        [JsonProperty(PropertyName = "sailingTime")]
        public double? SailingTime { get; set; }

        /// <summary>
        /// Average heading of vessel during reporting period. (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "heading")]
        public double? Heading { get; set; }

        /// <summary>
        /// Course made good during reporting period. (Unit: deg)
        /// </summary>
        [JsonProperty(PropertyName = "courseMadeGood")]
        public double? CourseMadeGood { get; set; }

        /// <summary>
        /// Average speed over ground over reporting period. (Unit: knots)
        /// </summary>
        [JsonProperty(PropertyName = "averageSpeedOverGround")]
        public double? AverageSpeedOverGround { get; set; }

        /// <summary>
        /// Average speed through water over reporting period. (Unit: knots)
        /// </summary>
        [JsonProperty(PropertyName = "averageSpeedThroughWater")]
        public double? AverageSpeedThroughWater { get; set; }
        
        /// <summary>
        /// Sailed distance over ground during reporting period. (Unit: nautical miles)
        /// </summary>
        [JsonProperty(PropertyName = "sailedDistanceOverGround")]
        public double? SailedDistanceOverGround { get; set; }

        /// <summary>
        /// Sailed distance through water during reporting period. (Unit: nautical miles)
        /// </summary>
        [JsonProperty(PropertyName = "sailedDistanceThroughWater")]
        public double? SailedDistanceThroughWater { get; set; }

        /// <summary>
        /// Depth of water below surface. (m)
        /// </summary>
        [JsonProperty(PropertyName = "waterDepth")]
        public double? WaterDepth { get; set; }

        /// <summary>
        /// Depth of water below keel. (m)
        /// </summary>
        [JsonProperty(PropertyName = "waterDepthBelowKeel")]
        public double? WaterDepthBelowKeel { get; set; }

        /// <summary>
        /// Draft details.
        /// </summary>
        [JsonProperty(PropertyName = "draft")]
        public Draft Draft { get; set; }

        /// <summary>
        /// Estimated time of arrival according to ship's master.
        /// </summary>
        [JsonProperty(PropertyName = "mastersEta")]
        public DateTimeOffset? MastersEta { get; set; }

        /// <summary>
        /// UN-LOCODE of arrival port (5-char code).
        /// </summary>
        [JsonProperty(PropertyName = "arrivalPortUnloc")]
        public string ArrivalPortUnloc { get; set; }

        /// <summary>
        /// Name of arrival port.
        /// </summary>
        [JsonProperty(PropertyName = "arrivalPortName")]
        public string ArrivalPortName { get; set; }
    }
}