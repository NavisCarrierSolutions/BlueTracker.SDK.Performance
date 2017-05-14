namespace BlueTracker.SDK.Performance.Query
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
        /// Distance Sailed over Ground
        /// </summary>
        public double? DistanceSailedOverGround { get; set; }

        /// <summary>
        /// Distance Sailed through Water
        /// </summary>
        public double? DistanceSailedThroughWater { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption ISO
        /// </summary>
        public double? TotalFocIso { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Main Engine 
        /// </summary>
        public double? TotalFocMe { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Main Engine (ISO)
        /// </summary>
        public double? TotalFocMeIso { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxilliary Engine
        /// </summary>
        public double? TotalFocAe { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxilliary Engine (ISO)
        /// </summary>
        public double? TotalFocAeIso { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxilliary Boiler
        /// </summary>
        public double? TotalFocAb { get; set; }

        /// <summary>
        /// Total Fuel Oil Consumption Auxilliary Boiler (ISO)
        /// </summary>
        public double? TotalFocAbIso { get; set; }

        /// <summary>
        /// Total CO2 emission
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total CO2 emission Main Engine
        /// </summary>
        public double? TotalCo2Me { get; set; }

        /// <summary>
        /// Total CO2 emission Auxilliary Engine
        /// </summary>
        public double? TotalCo2Ae { get; set; }

        /// <summary>
        /// Total CO2 emission Auxilliary Boiler
        /// </summary>
        public double? TotalCo2Ab { get; set; }

        /// <summary>
        /// EEOI TEU
        /// </summary>
        public double? EeoiTeu { get; set; }

        /// <summary>
        /// EEOI Cargo Weight
        /// </summary>
        public double? EeoiWeight { get; set; }

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