using System;

namespace BlueTracker.SDK.Performance.DTO.Query.Routing
{
    public class ActiveRoute
    {
        /// <summary>
        /// Point in time when journey should start
        /// </summary>
        public DateTime TimeStampUtc { get; set; }

        /// <summary>
        /// Name of route
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Json serialized WaypointData
        /// </summary>
        public WaypointData WaypointData { get; set; }
    }
}