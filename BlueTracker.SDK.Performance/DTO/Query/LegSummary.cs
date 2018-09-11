using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Leg summary.
    /// </summary>
    public class LegSummary
    {
        /// <summary>
        /// ID of leg.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Version Stamp when the leg was created or changed.
        /// </summary>
        public long VersionStamp { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        public virtual ShipShort Ship { get; set; }

        /// <summary>
        /// Voyage info.
        /// </summary>
        public virtual VoyageShort Voyage { get; set; }

        /// <summary>
        /// Port info of origin port.
        /// </summary>
        public virtual PortShort PortOfOrigin { get; set; }

        /// <summary>
        /// Port info of destination port.
        /// </summary>
        public virtual PortShort PortOfDestination { get; set; }

        /// <summary>
        /// UN-LOCODE of origin port (5-char code).
        /// </summary>
        public string PortOfOriginUnloc { get; set; }

        /// <summary>
        /// UN-LOCODE of destination port (5-char code).
        /// </summary>
        public string PortOfDestinationUnloc { get; set; }

        /// <summary>
        /// Departure time.
        /// </summary>
        public DateTimeOffset DepartureTime { get; set; }

        /// <summary>
        /// Arrival time.
        /// </summary>
        public DateTimeOffset? ArrivalTime { get; set; }

        /// <summary>
        /// Name of captain.
        /// </summary>
        public string Captain { get; set; }

        /// <summary>
        /// Name of chief engineer.
        /// </summary>
        public string ChiefEng { get; set; }

        /// <summary>
        /// Duration of leg. (days)
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Sailed distance over ground. (nautical miles)
        /// </summary>
        public double? DistanceSailedOverGround { get; set; }

        /// <summary>
        /// Sailed distance through water. (nautical miles)
        /// </summary>
        public double? DistanceSailedThroughWater { get; set; }

        /// <summary>
        /// Total cargo weight. (tons)
        /// </summary>
        public double? CargoWeight { get; set; }

        /// <summary>
        /// Ballast water weight. (tons)
        /// </summary>
        public double? BallastWeight { get; set; }

        /// <summary>
        /// TEU full.
        /// </summary>
        public double? CargoTeuFull { get; set; }

        /// <summary>
        /// TEU empty.
        /// </summary>
        public double? CargoTeuEmpty { get; set; }

        /// <summary>
        /// Number of reefers.
        /// </summary>
        public int? CargoReefers { get; set; }

        /// <summary>
        /// Total fuel oil consumption (tons)
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total fuel oil consumption (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocIso { get; set; }

        /// <summary>
        /// Total fuel oil consumption of main engines. (tons)
        /// </summary>
        public double? TotalFocMe { get; set; }

        /// <summary>
        /// Total fuel oil consumption of main engines (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocMeIso { get; set; }

        /// <summary>
        /// Total fuel oil consumption of aux engines. (tons)
        /// </summary>
        public double? TotalFocAe { get; set; }

        /// <summary>
        /// Total fuel oil consumption of aux engines (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocAeIso { get; set; }

        /// <summary>
        /// Total fuel oil consumption of aux boilers. (tons)
        /// </summary>
        public double? TotalFocAb { get; set; }

        /// <summary>
        /// Total fuel oil consumption of aux boilers (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocAbIso { get; set; }

        /// <summary>
        /// Total CO2 emission. (tons)
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total CO2 emission of main engines. (tons)
        /// </summary>
        public double? TotalCo2Me { get; set; }

        /// <summary>
        /// Total CO2 emission of aux engines. (tons)
        /// </summary>
        public double? TotalCo2Ae { get; set; }

        /// <summary>
        /// Total CO2 emission of aux boilers. (tons)
        /// </summary>
        public double? TotalCo2Ab { get; set; }

        /// <summary>
        /// EEOI by TEU. (Grams CO2 per TEU and mile)
        /// </summary>
        public double? EeoiTeu { get; set; }

        /// <summary>
        /// EEOI by cargo weight. (Grams CO2 per cargo ton and mile)
        /// </summary>
        public double? EeoiWeight { get; set; }

        /// <summary>
        /// Average estimation score. (%)
        /// </summary>
        public double? EstimationScore { get; set; }

        /// <summary>
        /// Average completeness score. (%)
        /// </summary>
        public double? CompletenessScore { get; set; }

        /// <summary>
        /// Average plausibility score. (%)
        /// </summary>
        public double? PlausibilityScore { get; set; }
    }
}