using System;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class Pos
    {
        /// <summary>
        /// Identifier of the Proof of Sustainability.
        /// </summary>
        public Guid Uid { get; set; }

        /// <summary>
        /// Energy content of the fuel. (MJ)
        /// </summary>
        public double? Energy { get; set; }

        /// <summary>
        /// GHG emissions factor. (gCO2eq/MJ)
        /// </summary>
        public double? EFactor { get; set; }

        /// <summary>
        /// Indicates whether the Red II regulation has been applied.
        /// </summary>
        public bool RedTwoApplied { get; set; }

        /// <summary>
        /// Unique number of the Proof of Sustainability certificate.
        /// </summary>
        public string PosNumber { get; set; }
    }
}
