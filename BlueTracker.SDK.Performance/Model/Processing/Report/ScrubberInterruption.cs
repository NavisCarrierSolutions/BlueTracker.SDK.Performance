using BlueTracker.SDK.Performance.Model.Enums;
using System;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class ScrubberInterruption
    {
        public DateTimeOffset? StartDateTime { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public ScrubberExhaustStream? ExhaustStream { get; set; }
        public ScrubberInterruptionReason? Reason { get; set; }
        public string Comments { get; set; }
    }
}
