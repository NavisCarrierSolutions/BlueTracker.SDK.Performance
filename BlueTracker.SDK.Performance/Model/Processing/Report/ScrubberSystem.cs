using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class ScrubberSystem
    {
        public List<ScrubberOperation> ScrubberOperations { get; set; }
        public List<ScrubberInterruption> ScrubberInterruptions { get; set; }
        public List<ScrubberChemicalEntry> ChemicalsReceived { get; set; }
        public List<ScrubberChemicalEntry> ChemicalsCorrections { get; set; }
        public List<ScrubberChemicalEntry> ChemicalsRob { get; set; }
        public List<ScrubberResidue> ScrubberResidues { get; set; }
    }
}
