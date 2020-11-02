using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class PerformanceReportDetails
    {
        public PerformanceReport Report { get; set; }

        public ReportScore ReportScores { get; set; }

        public Dictionary<PlausibilationAreaOptions, PlausibilityCount> PlausibilityCounts { get; set; }

        public Dictionary<PlausibilationAreaOptions, PlausibilityResultOptions?> AreaPlausibilities { get; set; }

        public IList<PlausibilityResult> PlausibilityResults { get; set; }

        public IList<ProcessResult> ProcessingDetails { get; set; }
    }
}
