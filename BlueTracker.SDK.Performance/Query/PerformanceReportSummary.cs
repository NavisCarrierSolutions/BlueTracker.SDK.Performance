using System;
using BlueTracker.SDK.Performance.Report;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Performance report summary.
    /// </summary>
    public class PerformanceReportSummary
    {
        /// <summary>
        /// ID of report.
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
        /// Leg info.
        /// </summary>
        public virtual LegShort Leg { get; set; }

        /// <summary>
        /// Time stamp of report (including UTC offset).
        /// </summary>
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// Reporting period or duration. (hours)
        /// </summary>
        public double? Period { get; set; }

        /// <summary>
        /// Operational state of ship.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public StateOptions State { get; set; }

        /// <summary>
        /// Name of captain.
        /// </summary>
        public string Captain { get; set; }

        /// <summary>
        /// Name of chief engineer.
        /// </summary>
        public string ChiefEng { get; set; }

        /// <summary>
        /// Position latitude. (degrees)
        /// </summary>
        public double? PosLat { get; set; }

        /// <summary>
        /// Position longitude. (degrees)
        /// </summary>
        public double? PosLng { get; set; }

        /// <summary>
        /// Duration ship was sailing. (hours)
        /// </summary>
        public double? SailingTime { get; set; }

        /// <summary>
        /// Average heading of ship. (degrees)
        /// </summary>
        public double? Heading { get; set; }

        /// <summary>
        /// Course made good of ship. (degrees)
        /// </summary>
        public double? CourseMadeGood { get; set; }

        /// <summary>
        /// Average speed over ground. (knots)
        /// </summary>
        public double? AverageSpeedOverGround { get; set; }

        /// <summary>
        /// Average speed through water. (knots)
        /// </summary>
        public double? AverageSpeedThroughWater { get; set; }

        /// <summary>
        /// Sailed distance over ground. (miles)
        /// </summary>
        public double? SailedDistanceOverGround { get; set; }

        /// <summary>
        /// Sailed distance through water. (miles)
        /// </summary>
        public double? SailedDistanceThroughWater { get; set; }

        /// <summary>
        /// Draft forward. (meters)
        /// </summary>
        public double? DraftFwd { get; set; }

        /// <summary>
        /// Draft midships. (meters)
        /// </summary>
        public double? DraftMid { get; set; }

        /// <summary>
        /// Draft aft. (meters)
        /// </summary>
        public double? DraftAft { get; set; }

        /// <summary>
        /// Outside air temperature. (°C)
        /// </summary>
        public double? AirTemp { get; set; }

        /// <summary>
        /// Outside air pressure. (hPa)
        /// </summary>
        public double? AirPress { get; set; }

        /// <summary>
        /// Sea water temperature. (°C)
        /// </summary>
        public double? SeaWaterTemp { get; set; }

        /// <summary>
        /// Sea state. (Beaufort scale)
        /// </summary>
        public int? SeaState { get; set; }

        /// <summary>
        /// Wave height. (meters)
        /// </summary>
        public double? WaveHeight { get; set; }

        /// <summary>
        /// Wave direction. (degrees rel. to north)
        /// </summary>
        public double? WaveDirection { get; set; }

        /// <summary>
        /// Swell geight. (meters)
        /// </summary>
        public double? SwellHeight { get; set; }

        /// <summary>
        /// Swell direction. (degrees rel. to north)
        /// </summary>
        public double? SwellDirection { get; set; }

        /// <summary>
        /// Relative wind speed. (m/s rel. to ship)
        /// </summary>
        public double? WindSpeedRel { get; set; }

        /// <summary>
        /// True wind speed. (m/s) rel. to north)
        /// </summary>
        public double? WindSpeedTrue { get; set; }

        /// <summary>
        /// Relative wind direction. (degrees rel. to ship)
        /// </summary>
        public double? WindDirRel { get; set; }

        /// <summary>
        /// True wind direction. (degrees rel. to north)
        /// </summary>
        public double? WindDirTrue { get; set; }

        /// <summary>
        /// Total cargo weight. (tons)
        /// </summary>
        public double? CargoWeight { get; set; }

        /// <summary>
        /// Number of full TEU.
        /// </summary>
        public double? CargoTeuFull { get; set; }

        /// <summary>
        /// Number of empty TEU.
        /// </summary>
        public double? CargoTeuEmpty { get; set; }

        /// <summary>
        /// Number of reefers.
        /// </summary>
        public int? CargoReefers { get; set; }

        /// <summary>
        /// Ballast water weight. (tons)
        /// </summary>
        public double? BallastWeight { get; set; }

        /// <summary>
        /// Engine room temperature. (°C)
        /// </summary>
        public double? EngineRoomTemp { get; set; }

        /// <summary>
        /// Cooling water temperature. (°C)
        /// </summary>
        public double? CoolingWaterTemp { get; set; }

        /// <summary>
        /// Is turbo charger cut out?
        /// </summary>
        public bool? IsTcCutout { get; set; }

        /// <summary>
        /// Is ship operated in slow steaming?
        /// </summary>
        public bool? IsSlowSteaming { get; set; }

        /// <summary>
        /// Is engine in combinator mode?
        /// </summary>
        public bool? IsCombinatorMode { get; set; }

        /// <summary>
        /// Average shaft RPM. (1/min)
        /// </summary>
        public double? AverageShaftRpm { get; set; }

        /// <summary>
        /// Average slip. (%)
        /// </summary>
        public double? AverageSlip { get; set; }

        /// <summary>
        /// Total fuel oil consumption. (tons)
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
        /// Total fuel oil consumption aux engines. (tons)
        /// </summary>
        public double? TotalFocAe { get; set; }

        /// <summary>
        /// Total fuel oil consumption aux engines (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocAeIso { get; set; }

        /// <summary>
        /// Total fuel oil consumption aux boilers. (tons)
        /// </summary>
        public double? TotalFocAb { get; set; }

        /// <summary>
        /// Total fuel oil consumption aux boilers (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocAbIso { get; set; }

        /// <summary>
        /// Total specific fuel oil consumption of main engines. (g/kWh)
        /// </summary>
        public double? TotalSfocMe { get; set; }

        /// <summary>
        /// Total specific fuel oil consumption of main engines (ISO corrected). (g/kWh)
        /// </summary>
        public double? TotalSfocMeIso { get; set; }

        /// <summary>
        /// Total specific fuel oil consumption of aux engines. (g/kWh)
        /// </summary>
        public double? TotalSfocAe { get; set; }

        /// <summary>
        /// Total specific fuel oil consumption of aux engines (ISO corrected). (g/kWh)
        /// </summary>
        public double? TotalSfocAeIso { get; set; }

        /// <summary>
        /// Sum of average aux engine power. (kW)
        /// </summary>
        public double? TotalAverageAePower { get; set; }

        /// <summary>
        /// Sum of average main engine power. (kW)
        /// </summary>
        public double? TotalAverageMePower { get; set; }

        /// <summary>
        /// Total generated main engine energy. (kJ)
        /// </summary>
        public double? TotalGeneratedMeEnergy { get; set; }

        /// <summary>
        /// Total generated shaft energy (delivered energy). (kJ)
        /// </summary>
        public double? TotalGeneratedShaftEnergy { get; set; }

        /// <summary>
        /// Total average shaft power (delivered power). (kW)
        /// </summary>
        public double? TotalAverageShaftPower { get; set; }

        /// <summary>
        /// Total generated aux engine energy. (kJ)
        /// </summary>
        public double? TotalGeneratedAeEnergy { get; set; }

        /// <summary>
        /// Total generated electrical energy. (kJ)
        /// </summary>
        public double? TotalGeneratedElectricalEnergy { get; set; }

        /// <summary>
        /// Total average electrical power. (kW)
        /// </summary>
        public double? TotalAverageElectricalPower { get; set; }

        /// <summary>
        /// Average relative main engine power. (%)
        /// </summary>
        public double? AverageRelativeMePower { get; set; }

        /// <summary>
        /// Average relative aux engine power. (%)
        /// </summary>
        public double? AverageRelativeAePower { get; set; }

        /// <summary>
        /// Total CO2 emission. (tons)
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total CO2 emission main engines. (tons)
        /// </summary>
        public double? TotalCo2Me { get; set; }

        /// <summary>
        /// Total CO2 emission aux engines. (tons)
        /// </summary>
        public double? TotalCo2Ae { get; set; }

        /// <summary>
        /// Total CO2 emission aux boilers. (tons)
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
        /// Estimation score. (%)
        /// </summary>
        public double? EstimationScore { get; set; }

        /// <summary>
        /// Completeness score. (%)
        /// </summary>
        public double? CompletenessScore { get; set; }

        /// <summary>
        /// Plausibility score. (%)
        /// </summary>
        public double? PlausibilityScore { get; set; }

        /// <summary>
        /// Plausibility count: Values not available.
        /// </summary>
        public int PlausibilityCountNotSet { get; set; }

        /// <summary>
        /// Plausibility count: Fine
        /// </summary>
        public int PlausibilityCountFine { get; set; }

        /// <summary>
        /// Plausibility count: Minor issue
        /// </summary>
        public int PlausibilityCountMinor { get; set; }

        /// <summary>
        /// Plausibility Count: Major issue
        /// </summary>
        public int PlausibilityCountMajor { get; set; }
    }
}