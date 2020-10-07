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
        /// Duration of leg. (hours)
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Sailing time of leg. (hours)
        /// </summary>
        public double? SailingTime { get; set; }

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
        /// Volume of cargo. (cubic meters)
        /// </summary>
        public double? CargoVolume { get; set; }

        /// <summary>
        /// Number of passengers.
        /// </summary>
        public int? CargoPassengers { get; set; }

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
        /// Total fuel oil consumption inert gas system. (metric tons)
        /// </summary>
        public double? TotalFocIgs { get; set; }

        /// <summary>
        /// Total fuel oil consumption inert gas system (ISO corrected). (metric tons)
        /// </summary>
        public double? TotalFocIgsIso { get; set; }

        /// <summary>
        /// Total fuel oil consumption incinerator. (metric tons)
        /// </summary>
        public double? TotalFocInc { get; set; }

        /// <summary>
        /// Total fuel oil consumption incinerator (ISO corrected). (metric tons)
        /// </summary>
        public double? TotalFocIncIso { get; set; }

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
        /// Total CO2 emission inert gas system. (tons)
        /// </summary>
        public double? TotalCo2Igs { get; set; }

        /// <summary>
        /// Total CO2 emission incinerator. (tons)
        /// </summary>
        public double? TotalCo2Inc { get; set; }

        /// <summary>
        /// Total heavy fuel oil consumption. (metric tons)
        /// </summary>
        public double? TotalFocHfo { get; set; }

        /// <summary>
        /// Total heavy fuel oil consumption high sulphur. (metric tons)
        /// </summary>
        public double? TotalFocHfoHs { get; set; }

        /// <summary>
        /// Total heavy fuel oil consumption low sulphur. (metric tons)
        /// </summary>
        public double? TotalFocHfoLs { get; set; }

        /// <summary>
        /// Total heavy fuel oil consumption ultra low sulphur. (metric tons)
        /// </summary>
        public double? TotalFocHfoLls { get; set; }

        /// <summary>
        /// Total light fuel oil consumption. (metric tons)
        /// </summary>
        public double? TotalFocLfo { get; set; }

        /// <summary>
        /// Total fuel oil consumption marine diesel oil. (metric tons)
        /// </summary>
        public double? TotalFocMdo { get; set; }

        /// <summary>
        /// Total fuel oil consumption marine gas oil. (metric tons)
        /// </summary>
        public double? TotalFocMgo { get; set; }

        /// <summary>
        /// Total fuel oil consumption propane. (metric tons)
        /// </summary>
        public double? TotalFocPropane { get; set; }

        /// <summary>
        /// Total fuel oil consumption butane. (metric tons)
        /// </summary>
        public double? TotalFocButane { get; set; }

        /// <summary>
        /// Total fuel oil consumption LNG. (metric tons)
        /// </summary>
        public double? TotalFocLng { get; set; }

        /// <summary>
        /// Total fuel oil consumption methanol. (metric tons)
        /// </summary>
        public double? TotalFocMethanol { get; set; }

        /// <summary>
        /// Total fuel oil consumption ethanol. (metric tons)
        /// </summary>
        public double? TotalFocEthanol { get; set; }

        /// <summary>
        /// EEOI by TEU. (Grams CO2 per TEU and mile)
        /// </summary>
        public double? EeoiTeu { get; set; }

        /// <summary>
        /// EEOI by cargo weight. (Grams CO2 per cargo ton and mile)
        /// </summary>
        public double? EeoiWeight { get; set; }

        /// <summary>
        /// Total cylinder oil consumption (litres).
        /// </summary>
        public double? TotalCylinderOilConsumption { get; set; }

        /// <summary>
        /// Total main engine circulation lub oil consumption (litres).
        /// </summary>
        public double? TotalCirculationLubOilMeConsumption { get; set; }

        /// <summary>
        /// Total aux engine circulation lub oil consumption (litres).
        /// </summary>
        public double? TotalCirculationLubOilAeConsumption { get; set; }

        /// <summary>
        /// Total fresh water consumption with an undefined usage (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionUndef { get; set; }

        /// <summary>
        /// Total domestic fresh water consumption (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionDomestic { get; set; }

        /// <summary>
        /// Total boiler fresh water consumption (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionBoiler { get; set; }

        /// <summary>
        /// Total fresh water consumption by washing (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionWashing { get; set; }

        /// <summary>
        /// Total oily water discharged via an undefined method (cubic meters).
        /// </summary>
        public double? TotalOilyWaterDischargeUndef { get; set; }

        /// <summary>
        /// Total oily water discharged via an oily water separator (cubic meters).
        /// </summary>
        public double? TotalOilyWaterDischargeViaOws { get; set; }

        /// <summary>
        /// Total oily water discharged via an oil discharge monitoring equipment (cubic meters).
        /// </summary>
        public double? TotalOilyWaterDischargeViaOdme { get; set; }

        /// <summary>
        /// ME SOx Emissions (metric tons).
        /// </summary>
        public double? SoxEmissionsMe { get; set; }

        /// <summary>
        /// AE SOx Emissions (metric tons).
        /// </summary>
        public double? SoxEmissionsAe { get; set; }

        /// <summary>
        /// Boiler SOx Emissions (metric tons).
        /// </summary>
        public double? SoxEmissionsAb { get; set; }

        /// <summary>
        /// Total SOx Emissions (metric tons).
        /// </summary>
        public double? TotalSoxEmissions { get; set; }

        /// <summary>
        /// ME NOx Emissions (metric tons).
        /// </summary>
        public double? NoxEmissionsMe { get; set; }

        /// <summary>
        /// AE NOx Emissions (metric tons).
        /// </summary>
        public double? NoxEmissionsAe { get; set; }

        /// <summary>
        /// Boiler NOx Emissions (metric tons).
        /// </summary>
        public double? NoxEmissionsAb { get; set; }

        /// <summary>
        /// Total NOx Emissions (metric tons).
        /// </summary>
        public double? TotalNoxEmissions { get; set; }

        /// <summary>
        /// Bunkered fresh water (cubic meters)
        /// </summary>
        public double? BunkerFreshWaterBunkered { get; set; }

        /// <summary>
        /// Produced fresh water (cubic meters)
        /// </summary>
        public double? BunkerFreshWaterProduced { get; set; }

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