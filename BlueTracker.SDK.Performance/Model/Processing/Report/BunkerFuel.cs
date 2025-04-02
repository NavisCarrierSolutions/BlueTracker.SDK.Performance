using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class BunkerFuel
    {
        /// <summary>
        /// Unique ID of bunker charge in reporting system.
        /// </summary>
        public string BunkerChargeId { get; set; }

        /// <summary>
        /// Unique name of bunker charge.
        /// </summary>
        public string BunkerChargeName { get; set; }

        public FuelKindOptions Kind { get; set; }

        public FuelCategory FuelCategory { get; set; }

        public double? Amount { get; set; }

        public FuelType Type { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        public string BdnNumber { get; set; }

        /// <summary>
        /// Reference to recognized certification schemes (ISSC, RSB, etc.) or Unique numbers of the Proof of Sustainability. 
        /// </summary>
        public List<Pos> PosNumbers { get; set; }

        /// <summary>
        /// Indicates whether no POS certificate has been issued.
        /// </summary>
        public bool? NoPosIssued { get; set; }

        /// <summary>
        /// Indicates whether this is an initial bunker charge. If yes, the system will not use this charge in ROB calculations.
        /// </summary>
        public bool Initial { get; set; }

        /// <summary>
        /// The percentage of biofuel used in blend. (%)
        /// </summary>
        public double? PercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        /// Fossil component of biofuel blend.
        /// </summary>
        public FossilBlendOptions? FossilComponent { get; set; }

        /// <summary>
        /// The amount of biofuel used in blend. (mt)
        /// Will be calculated based on the percentage of biofuel in blend.
        /// Once the POS details are available, this value will be updated and will contain the actual amount of biofuel in blend.
        /// </summary>
        public double? BioBlendAmount { get; set; }

        /// <summary>
        /// The amount of fossil fuel used in blend. (mt)
        /// </summary>
        public double? FossilBlendAmount { get; set; }

        /// <summary>
        /// Bio energy content of the fuel. (MJ)
        /// </summary>
        public double? BioEnergy { get; set; }
    }
}
