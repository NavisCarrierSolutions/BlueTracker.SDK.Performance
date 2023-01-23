using BlueTracker.SDK.Performance.Model.Enums;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Schedule
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Schedule identifier
        /// </summary>
        public Guid ScheduleIdentifier { get; set; }

        /// <summary>
        /// Custom Id
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Ship
        /// </summary>
        public ShipShort Ship { get; set; }

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
        /// Whether portcall is omitted
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
        /// Version of data set
        /// </summary>
        public long RowVersion { get; set; }

        /// <summary>
        /// Version of ship.CurrentVersionStamp
        /// </summary>
        public long VersionStamp { get; set; }

        /// <summary>
        /// Indicates whether 
        /// </summary>
        public bool Synchronized { get; set; }

        /// <summary>
        /// Indicates who created the schedule
        /// </summary>
        public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Shows when the schedule was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Shows when most recent change date of the schedule
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
}
