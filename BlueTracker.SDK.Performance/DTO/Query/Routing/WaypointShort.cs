using System;

namespace BlueTracker.SDK.Performance.DTO.Query.Routing
{
    public class WaypointShort : PositionShort
    {
        /// <summary>
        /// Identifier for position
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ETA to next waypoint (if known)
        /// </summary>
        public TimeSpan? ETA { get; set; }

        /// <summary>
        /// Is active waypoint sailed toward
        /// </summary>
        public bool IsActive { get; set; }
    }
}