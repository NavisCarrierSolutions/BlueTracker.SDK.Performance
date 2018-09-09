using System;
using BlueTracker.SDK.Performance.Model.Common;

namespace BlueTracker.SDK.Performance.Model.Processing.Reports
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

        public double? WaterDepth { get; set; }

        public double? WaterDepthBelowKeel { get; set; }

        public Draft Draft { get; set; }

        public double? Trim { get; set; }

        public DateTimeOffset? MastersEta { get; set; }

        public string ArrivalPortUnloc { get; set; }

        public string ArrivalPortName { get; set; }
    }
}