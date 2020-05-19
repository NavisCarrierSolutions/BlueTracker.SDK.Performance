namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Voyage Summary
    /// </summary>
    public class VoyageSummary
    {
        /// <summary>
        /// Id (given by bluetracker.one)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Version Stamp (incremented by bluetracker.one on every change)
        /// </summary>
        public long VersionStamp { get; set; }

        /// <summary>
        /// Ship Information
        /// </summary>
        public virtual ShipShort Ship { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        public virtual ServiceShort Service { get; set; }

        /// <summary>
        /// Voyage Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Voyage Duration
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Distance Sailed over Ground. (miles)
        /// </summary>
        public double? DistanceSailedOverGround { get; set; }

        /// <summary>
        /// Distance Sailed through Water. (miles)
        /// </summary>
        public double? DistanceSailedThroughWater { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption. (metric tons)
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption ISO. (metric tons)
        /// </summary>
        public double? TotalFocIso { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Main Engine. (metric tons) 
        /// </summary>
        public double? TotalFocMe { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Main Engine (ISO). (metric tons)
        /// </summary>
        public double? TotalFocMeIso { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxiliary Engine. (metric tons)
        /// </summary>
        public double? TotalFocAe { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxiliary Engine (ISO). (metric tons)
        /// </summary>
        public double? TotalFocAeIso { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxiliary Boiler. (metric tons)
        /// </summary>
        public double? TotalFocAb { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxiliary Boiler (ISO). (metric tons)
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
        /// Total CO2 emission. (metric tons)
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total CO2 emission Main Engine. (metric tons)
        /// </summary>
        public double? TotalCo2Me { get; set; }

        /// <summary>
        /// Total CO2 emission Auxiliary Engine. (metric tons)
        /// </summary>
        public double? TotalCo2Ae { get; set; }

        /// <summary>
        /// Total CO2 emission Auxiliary Boiler. (metric tons)
        /// </summary>
        public double? TotalCo2Ab { get; set; }

        /// <summary>
        /// Total CO2 emission inert gas system. (metric tons)
        /// </summary>
        public double? TotalCo2Igs { get; set; }

        /// <summary>
        /// Total CO2 emission incinerator. (metric tons)
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
        /// EEOI TEU. (Grams CO2 per TEU and mile)
        /// </summary>
        public double? EeoiTeu { get; set; }

        /// <summary>
        /// EEOI Cargo Weight. (Grams CO2 per cargo ton and mile)
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
        /// Estimation Score
        /// </summary>
        public double? EstimationScore { get; set; }

        /// <summary>
        /// Completeness Score
        /// </summary>
        public double? CompletenessScore { get; set; }

        /// <summary>
        /// Plausibility Score
        /// </summary>
        public double? PlausibilityScore { get; set; }
    }
}