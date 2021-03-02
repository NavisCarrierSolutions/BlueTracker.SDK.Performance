using System;

namespace BlueTracker.SDK.Performance.DTO.Post.Routing
{
    public class Waypoint : Position
    {
        /// <summary>
        /// Identifier for position (named CustomId for Bluetracker concept namings)
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Estimated time of arrival next waypoint
        /// </summary>
        public DateTime? EstimatedTimeNextWaypointUtc { get; set; }

        /// <summary>
        /// Distance to next waypoint (if known)
        /// </summary>
        public double? DistanceNextWaypoint { get; set; }

        /// <summary>
        /// Heading to next waypoint (if known, degrees)
        /// </summary>
        public double? BearingNextWaypoint { get; set; }

        /// <summary>
        /// Is active waypoint sailed toward
        /// </summary>
        public bool IsActive { get; set; }
    }
}