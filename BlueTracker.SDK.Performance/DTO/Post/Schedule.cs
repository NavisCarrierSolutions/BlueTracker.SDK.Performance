using BlueTracker.SDK.Performance.Model.Enums;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// Schedule
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Custom ID
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Schedule identifier
        /// </summary>
        public Guid? ScheduleIdentifier { get; set; }

        /// <summary>
        /// Inbound voyage
        /// </summary>
        public string InboundVoyage { get; set; }

        /// <summary>
        /// Outbound voyage
        /// </summary>
        public string OutboundVoyage { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// ETA - Estimated time of arrival
        /// </summary>
        public DateTimeOffset? ETA { get; set; }

        /// <summary>
        /// ETB - Estimated time of berth
        /// </summary>
        public DateTimeOffset? ETB { get; set; }

        /// <summary>
        /// ETD - Estimated time to destination
        /// </summary>
        public DateTimeOffset? ETD { get; set; }

        /// <summary>
        /// Port activities
        /// </summary>
        public List<PortActivity> PortActivities { get; set; }

        /// <summary>
        /// Whether portcall is omitted.
        /// </summary>
        public bool IsOmitted { get; set; }

        /// <summary>
        /// Charter agent
        /// </summary>
        public Contact CharterAgent { get; set; }

        /// <summary>
        /// Owner agent
        /// </summary>
        public Contact OwnerAgent { get; set; }

        /// <summary>
        /// Other agent
        /// </summary>
        public Contact OtherAgent { get; set; }

        /// <summary>
        /// Marks schedule as deleted
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Terminal code
        /// </summary>
        public string TerminalCode { get; set; }
    }
}
