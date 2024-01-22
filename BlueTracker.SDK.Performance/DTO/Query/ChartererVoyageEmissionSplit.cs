using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class ChartererVoyageEmissionSplit
    {
        /// <summary>
        /// Provides information about the voyage.
        /// </summary>
        public VoyageWithCargoParcels Voyage { get; set; }

        /// <summary>
        /// Provides information about emissions during ballast leg.
        /// </summary>
        public ChartererBallastEmissions BallastEmissions { get; set; }

        /// <summary>
        /// Provides information about leg emissions.
        /// </summary>
        public List<ChartererLegEmissions> LegEmissions { get; set; }

        /// <summary>
        /// Provides information about port call emissions.
        /// </summary>
        public List<ChartererPortCallEmissions> PortCallEmissions { get; set; }

        /// <summary>
        /// Provides information about parcel emissions.
        /// </summary>
        public List<ChartererCargoParcelEmissions> ParcelEmissions { get; set; }

        /// <summary>
        /// Indicates whether any un-assignable parcels were found.
        /// </summary>
        public bool HasUnassignableParcels { get; set; }
    }
}
