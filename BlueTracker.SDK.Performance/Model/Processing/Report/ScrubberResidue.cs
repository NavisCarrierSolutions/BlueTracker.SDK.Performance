using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class ScrubberResidue
    {
        public ScrubberResidueType? Type { get; set; }
        public double? MassKg { get; set; }
        public double? VolumeLitre { get; set; }
    }
}
