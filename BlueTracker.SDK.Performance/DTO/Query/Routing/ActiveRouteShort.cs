using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query.Routing
{
    public class ActiveRouteShort
    {
        /// <summary>
        /// Name of route
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Point in time when journey should start
        /// </summary>
        public DateTime TimeStampUtc { get; set; }

        /// <summary>
        /// Optional: current position of vessel
        /// </summary>
        public PositionShort CurrentPosition { get; set; }

        /// <summary>
        /// List of gps positions in correct order
        /// </summary>
        public List<WaypointShort> Waypoints { get; set; }
    }
}