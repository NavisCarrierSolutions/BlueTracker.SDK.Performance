using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Post.Routing
{
    public class ActiveRoute
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
        /// Planned average speed for voyage (nm/h)
        /// </summary>
        public double? AvgSpeed { get; set; }

        /// <summary>
        /// Optional: current position of vessel
        /// </summary>
        public Position CurrentPosition { get; set; }

        /// <summary>
        /// List of waypoint coordinates in correct order
        /// </summary>
        public List<Waypoint> Waypoints { get; set; }
    }
}