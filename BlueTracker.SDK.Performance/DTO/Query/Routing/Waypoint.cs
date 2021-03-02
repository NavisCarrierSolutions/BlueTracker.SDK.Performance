using System;

namespace BlueTracker.SDK.Performance.DTO.Query.Routing
{
    public class Waypoint : Position
    {
        /// <summary>
        /// Identifier for position - NOT Database Id
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Travel time from current position (if known)
        /// </summary>
        public TimeSpan? TravelTime { get; set; }

        /// <summary>
        /// Estimated time of arrival
        /// </summary>
        public DateTime? EstimatedTimeOfArrivalUtc { get; set; }

        /// <summary>
        /// Estimated time of arrival next waypoint
        /// </summary>
        public DateTime? EstimatedTimeNextWaypointUtc { get; set; }

        /// <summary>
        /// Distance to next waypoint (rhumb line distance point to point, nautical miles)
        /// </summary>
        public double? DistanceNextWaypoint { get; set; }

        /// <summary>
        /// Bearing to next waypoint (rhumb line bearing)
        /// </summary>
        public double? BearingNextWaypoint { get; set; }

        /// <summary>
        /// Is active waypoint sailed toward
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Is this waypoint a calculation representation of the current position of the vessel? (so technically no waypoint but the current position)
        /// </summary>
        public bool IsCurrentPosition { get; set; }
    }
}