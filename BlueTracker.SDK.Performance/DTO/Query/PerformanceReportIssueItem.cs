using BlueTracker.SDK.Performance.Model.Enums;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Provides information about a performance report issue.
    /// </summary>
    public class PerformanceReportIssueItem
    {
        /// <summary>
        /// Local timestamp of the associated report.
        /// </summary>
        public DateTimeOffset TimestampLocal { get; set; }

        /// <summary>
        /// UTC timestamp of the associated report.
        /// </summary>
        public DateTimeOffset TimestampUtc { get; set; }

        /// <summary>
        /// Name of the issue.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the issue.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Message describing the issue.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Type of associated event.
        /// </summary>
        public EventType? Event { get; set; }

        /// <summary>
        /// Plausibility state of the issue.
        /// </summary>
        public PlausibilityResultOptions State { get; set; }

        /// <summary>
        /// Completeness state of the issue.
        /// </summary>
        public CompletenessResultOptions? CompletenessState { get; set; }

        /// <summary>
        /// List of affected areas.
        /// </summary>
        public List<string> AffectedAreas { get; set; }

        /// <summary>
        /// List of reported values.
        /// </summary>
        public List<string> ReportedValues { get; set; }
    }
}
