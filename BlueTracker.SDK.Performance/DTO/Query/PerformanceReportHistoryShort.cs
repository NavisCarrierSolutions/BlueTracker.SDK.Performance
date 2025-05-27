using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class PerformanceReportHistoryShort
    {
        /// <summary>
        /// ID of history entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// UID of history entry.
        /// </summary>
        public Guid Uid { get; set; }

        /// <summary>
        /// History type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public HistoryTypeOptions HistoryType { get; set; }

        /// <summary>
        /// ID of the performance report this history entry is associated with.
        /// </summary>
        public int PerformanceReportId { get; set; }

        /// <summary>
        /// Timestamp of the associated performance report in UTC.
        /// </summary>
        public DateTime TimeStampUtc { get; set; }

        /// <summary>
        /// Date and time when the history entry was created in UTC.
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
}
