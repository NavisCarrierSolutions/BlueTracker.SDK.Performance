using System.Collections.Generic;
using BlueTracker.SDK.Performance.Enums;

namespace BlueTracker.SDK.Performance.Ship
{
    /// <summary>
    /// Hull
    /// </summary>
    public class Hull
    {
        /// <summary>
        /// Draft the ship is designed for
        /// </summary>
        public double? DesignDraft { get; set; }

        /// <summary>
        /// Ships width from Port to Starboard
        /// </summary>
        public double? ShipWidth { get; set; }

        /// <summary>
        /// Length of ship over all.
        /// </summary>
        public double? LengthOverAll { get; set; }

        /// <summary>
        /// Length between perpendiculars.
        /// </summary>
        public double? LengthBetweenPerpendiculars { get; set; }

        /// <summary>
        /// Anemometer Height above Keel
        /// </summary>
        public double? AnemometerHeightAboveKeel { get; set; }

        /// <summary>
        /// Transverse Projected Area Design
        /// </summary>
        public double? TransverseProjectedAreaDesign { get; set; }

        /// <summary>
        /// Reference Height above Sea level
        /// </summary>
        public double? ReferenceHeightAboveSeaLevel { get; set; }

        /// <summary>
        /// Type of Bow
        /// </summary>
        public BowType? BowType { get; set; }

        /// <summary>
        /// Type of Super Structure
        /// </summary>
        public SuperStructureType? SuperStructureType { get; set; }

        /// <summary>
        /// Wind Resistance Data
        /// </summary>
        public List<double[]> WindResistanceData { get; set; }
    }
}
