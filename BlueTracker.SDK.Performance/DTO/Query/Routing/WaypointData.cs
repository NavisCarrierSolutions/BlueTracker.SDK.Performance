using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query.Routing
{
    /// <summary>
    /// class to serialize into database string column
    /// </summary>
    public class WaypointData
    {
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
        public List<IntermediateWeatherWaypoint> Waypoints { get; set; }
    }
}