using BlueTracker.SDK.Performance.Model.Enums;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class ScrubberOperation
    {
        public DateTimeOffset? StartDateTime { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public ScrubberExhaustStream? ExhaustStream { get; set; }
        public ScrubberMode? ScrubberMode { get; set; }
        public ScrubberDesulphurizationMode? DesulphurizationMode { get; set; }
        public double? EmissionRatioSo2ToCo2 { get; set; }
        public List<ScrubberChemicalEntry> Consumptions { get; set; }
    }
}
