using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class ScrubberChemicalEntry
    {
        public ScrubberChemicalType? ChemicalType { get; set; }
        public double? ChemicalAmountLitre { get; set; }
        public ScrubberWtuChemical? WtuChemical { get; set; }
        public double? WtuAmountLitre { get; set; }
    }
}
