using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents scrubber system data reported for the vessel.
    /// </summary>
    public class ScrubberSystem
    {
        /// <summary>
        /// Gets or sets the scrubber operations recorded during the reporting period.
        /// </summary>
        [JsonProperty("scrubberOperations")]
        public List<ScrubberOperation> ScrubberOperations { get; set; }

        /// <summary>
        /// Gets or sets the scrubber interruptions recorded during the reporting period.
        /// </summary>
        [JsonProperty("scrubberInterruptions")]
        public List<ScrubberInterruption> ScrubberInterruptions { get; set; }

        /// <summary>
        /// Gets or sets the chemicals received for scrubber operations.
        /// </summary>
        [JsonProperty("chemicalsReceived")]
        public List<ScrubberChemicalEntry> ChemicalsReceived { get; set; }

        /// <summary>
        /// Gets or sets the scrubber chemical corrections.
        /// </summary>
        [JsonProperty("chemicalsCorrections")]
        public List<ScrubberChemicalEntry> ChemicalsCorrections { get; set; }

        /// <summary>
        /// Gets or sets the scrubber chemicals remaining on board.
        /// </summary>
        [JsonProperty("chemicalsRob")]
        public List<ScrubberChemicalEntry> ChemicalsRob { get; set; }

        /// <summary>
        /// Gets or sets the scrubber residues reported for the period.
        /// </summary>
        [JsonProperty("scrubberResidues")]
        public List<ScrubberResidue> ScrubberResidues { get; set; }
    }
}
