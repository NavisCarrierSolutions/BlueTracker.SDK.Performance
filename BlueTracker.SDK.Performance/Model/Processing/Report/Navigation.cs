using System;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class Navigation
    {
        public Position Position { get; set; }

        public double? SailingTime { get; set; }

        public double? Heading { get; set; }

        public double? CourseMadeGood { get; set; }

        public double? AverageSpeedOverGround { get; set; }

        public double? AverageSpeedThroughWater { get; set; }

        public double? SailedDistanceOverGround { get; set; }

        public double? SailedDistanceThroughWater { get; set; }

        public double? Displacement { get; set; }

        public double? WaterDepth { get; set; }

        public double? WaterDepthBelowKeel { get; set; }

        public Draft Draft { get; set; }

        public double? Trim { get; set; }

        public DateTimeOffset? MastersEta { get; set; }

        public double? DistanceToGo { get; set; }

        public string ArrivalPortUnloc { get; set; }

        public string ArrivalPortName { get; set; }

        public string ArrivalPortTerminalCode { get; set; }

        public string DeparturePortUnloc { get; set; }

        public string DeparturePortName { get; set; }

        public string DeparturePortTerminalCode { get; set; }

        /// <summary>
        /// Charter speed instruction (use this OR CharterSpeedInstructionKnots).
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterSpeedInstruction? CharterSpeedInstruction { get; set; }

        /// <summary>
        /// Charter speed instruction (knots) - (use this OR CharterSpeedInstruction).
        /// </summary>
        public double? CharterSpeedInstructionKnots { get; set; }

        /// <summary>
        /// Charter voyage status.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterVoyageStatus? CharterVoyageStatus { get; set; }
    }
}