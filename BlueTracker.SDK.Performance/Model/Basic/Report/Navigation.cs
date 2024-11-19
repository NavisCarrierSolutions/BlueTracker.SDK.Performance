using System;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        /// Actual displacement of the ship. (mt)
        /// </summary>
        [JsonProperty(PropertyName = "displacement")]
        public double? Displacement { get; set; }

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
        /// Remaining distance to the arrival port. (miles)
        /// </summary>
        [JsonProperty(PropertyName = "distanceToGo")]
        public double? DistanceToGo { get; set; }

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

        /// <summary>
        /// Terminal code of arrival port.
        /// </summary>
        [JsonProperty(PropertyName = "arrivalPortTerminalCode")]
        public string ArrivalPortTerminalCode { get; set; }

        /// <summary>
        /// Charter speed instruction (use this OR CharterSpeedInstructionKnots).
        /// </summary>
        [JsonProperty(PropertyName = "charterSpeedInstruction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterSpeedInstruction? CharterSpeedInstruction { get; set; }

        /// <summary>
        /// Charter speed instruction (knots) - (use this OR CharterSpeedInstruction).
        /// </summary>
        [JsonProperty(PropertyName = "charterSpeedInstructionKnots")]
        public double? CharterSpeedInstructionKnots { get; set; }

        /// <summary>
        /// Charter voyage status.
        /// </summary>
        [JsonProperty(PropertyName = "charterVoyageStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterVoyageStatus? CharterVoyageStatus { get; set; }

        /// <summary>
        /// When the pilot left the ship.
        /// </summary>
        [JsonProperty("pilotOff")]
        public DateTime? PilotOff { get; set; }

        /// <summary>
        /// When the pilot boarded the ship.
        /// </summary>
        [JsonProperty("pilotOn")]
        public DateTime? PilotOn { get; set; }

        /// <summary>
        /// Time to pilot station next port (hrs).
        /// </summary>
        [JsonProperty("timeToPilotStationNextPort")]
        public double? TimeToPilotStationNextPort { get; set; }

        /// <summary>
        /// Average speed to pilot station (knots).
        /// </summary>
        [JsonProperty("averageSpeedToPilotStation")]
        public double? AverageSpeedToPilotStation { get; set; }

        /// <summary>
        /// Timestamp when the last line of the ship was taken away.
        /// </summary>
        [JsonProperty("lastLineAway")]
        public DateTime? LastLineAway { get; set; }

        /// <summary>
        /// Timestamp when the first lines were sent ashore.
        /// </summary>
        [JsonProperty("firstLineAshore")]
        public DateTime? FirstLineAshore { get; set; }
    }
}