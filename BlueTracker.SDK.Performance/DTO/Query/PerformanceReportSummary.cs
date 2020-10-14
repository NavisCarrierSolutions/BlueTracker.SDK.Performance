using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
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
        /// Master's estimated time of arrival (including UTC offset).
        /// </summary>
        public DateTimeOffset? MastersEta { get; set; }

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
        /// Water depth (meters).
        /// </summary>
        public double? WaterDepth { get; set; }

        /// <summary>
        /// Water depth below keel (meters).
        /// </summary>
        public double? WaterDepthBelowKeel { get; set; }

        /// <summary>
        /// Actual displacementof ship (metric tons).
        /// </summary>
        public double? Displacement { get; set; }

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
        /// Mean draft. (meters)
        /// </summary>
        public double? MeanDraft { get; set; }

        /// <summary>
        /// Trim (DraftFwd - DraftAft) (meters).
        /// </summary>
        public double? Trim { get; set; }

        /// <summary>
        /// Outside air temperature. (�C)
        /// </summary>
        public double? AirTemp { get; set; }

        /// <summary>
        /// Outside air pressure. (hPa)
        /// </summary>
        public double? AirPress { get; set; }

        /// <summary>
        /// Sea water temperature. (�C)
        /// </summary>
        public double? SeaWaterTemp { get; set; }

        /// <summary>
        /// Sea state. (Beaufort scale)
        /// </summary>
        public int? SeaState { get; set; }

        /// <summary>
        /// Douglas sea scale. (Douglas)
        /// </summary>
        public int? DouglasSeaScale { get; set; }

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
        /// Cargo volume. (cubic meters)
        /// </summary>
        public double? CargoVolume { get; set; }

        /// <summary>
        /// Number of passengers.
        /// </summary>
        public int? CargoPassengers { get; set; }

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
        /// Engine room temperature. (�C)
        /// </summary>
        public double? EngineRoomTemp { get; set; }

        /// <summary>
        /// Temperature of LT cooling water. (�C)
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
        /// Is ship on shore power supply?
        /// </summary>
        public bool? IsOnShorePowerSupply { get; set; }

        /// <summary>
        /// Is ship running the scrubber in operation?
        /// </summary>
        public bool? IsOnScrubberMode { get; set; }

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
        /// Total fuel oil consumption of undefined source or type. (metric tons)
        /// </summary>
        public double? TotalFocUndef { get; set; }

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
        /// Daily fuel oil consumption of main engines. (t/d)
        /// </summary>
        public double? DailyMeFoc { get; set; }

        /// <summary>
        /// Daily fuel oil consumption of auxiliary engines. (t/d)
        /// </summary>
        public double? DailyAeFoc { get; set; }

        /// <summary>
        /// Daily fuel oil consumption of auxiliary boilers. (t/d)
        /// </summary>
        public double? DailyAbFoc { get; set; }

        /// <summary>
        /// Daily fuel oil consumption of all engines and boilers. (t/d)
        /// </summary>
        public double? DailyTotalFoc { get; set; }

        /// <summary>
        /// Sum of average aux engine power. (kW)
        /// </summary>
        public double? TotalAverageAePower { get; set; }

        /// <summary>
        /// Sum of average main engine power. (kW)
        /// </summary>
        public double? TotalAverageMePower { get; set; }

        /// <summary>
        /// Total generated main engine energy. (kWh)
        /// </summary>
        public double? TotalGeneratedMeEnergy { get; set; }

        /// <summary>
        /// Total generated shaft energy (delivered energy). (kWh)
        /// </summary>
        public double? TotalGeneratedShaftEnergy { get; set; }

        /// <summary>
        /// Total average shaft power (delivered power). (kW)
        /// </summary>
        public double? TotalAverageShaftPower { get; set; }

        /// <summary>
        /// Total average shaft power (delivered power, corrected). (kW)
        /// </summary>
        public double? TotalAverageShaftPowerCorrected { get; set; }

        /// <summary>
        /// Total generated aux engine energy. (kWh)
        /// </summary>
        public double? TotalGeneratedAeEnergy { get; set; }

        /// <summary>
        /// Total generated electrical energy. (kWh)
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
        /// Power added or reduced by wind. (kW)
        /// </summary>
        public double? ResistanceByWind { get; set; }

        /// <summary>
        /// Delivered power corrected by environmental factors. (kW)
        /// </summary>
        public double? DeliveredPowerCorrected { get; set; }

        /// <summary>
        /// Loss of vessel speed compared to active hull model. (%)
        /// </summary>
        public double? SpeedLoss { get; set; }

        /// <summary>
        /// Loss of vessel speed compared to active hull model. (%)
        /// </summary>
        public double? SpeedLossUncorrected { get; set; }

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
        /// Total CO2 emission inert gas system. (tons)
        /// </summary>
        public double? TotalCo2Igs { get; set; }

        /// <summary>
        /// Total CO2 emission incinerator. (tons)
        /// </summary>
        public double? TotalCo2Inc { get; set; }

        /// <summary>
        /// Total CO2 emission of undefined source. (tons)
        /// </summary>
        public double? TotalCo2Undef { get; set; }

        /// <summary>
        /// EEOI by TEU. (Grams CO2 per TEU and mile)
        /// </summary>
        public double? EeoiTeu { get; set; }

        /// <summary>
        /// EEOI by cargo weight. (Grams CO2 per cargo ton and mile)
        /// </summary>
        public double? EeoiWeight { get; set; }

        /// <summary>
        /// Transport efficiency. (Grams of fuel oil per cargo ton and mile)
        /// </summary>
        public double? TransportEfficiency { get; set; }

        /// <summary>
        /// Total fuel oil remain on board. (metric tons)
        /// </summary>
        public double? TotalRobFuelOil { get; set; }

        /// <summary>
        /// Total fresh water remain on board. (cubic meters)
        /// </summary>
        public double? TotalRobFreshWater { get; set; }

        /// <summary>
        /// Heavy fuel oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfo { get; set; }

        /// <summary>
        /// Heavy fuel oil high sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfoHs { get; set; }

        /// <summary>
        /// Heavy fuel oil low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfoLs { get; set; }

        /// <summary>
        /// Heavy fuel oil ultra low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfoLls { get; set; }

        /// <summary>
        /// Light fuel oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelLfo { get; set; }

        /// <summary>
        /// Marine diesel oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMdo { get; set; }

        /// <summary>
        /// Marine gas oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMgo { get; set; }

        /// <summary>
        /// Fuel oil propane remain on board. (metric tons)
        /// </summary>
        public double? RobFuelPropane { get; set; }

        /// <summary>
        /// Fuel oil butane remain on board. (metric tons)
        /// </summary>
        public double? RobFuelButane { get; set; }

        /// <summary>
        /// Fuel oil LNG remain on board. (metric tons)
        /// </summary>
        public double? RobFuelLng { get; set; }

        /// <summary>
        /// Fuel oil methanol remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMethanol { get; set; }

        /// <summary>
        /// Fuel oil ethanol remain on board. (metric tons)
        /// </summary>
        public double? RobFuelEthanol { get; set; }

        /// <summary>
        /// Cylinder lub oil remain on board. (litres)
        /// </summary>
        public double? RobLubOilCylinder { get; set; }

        /// <summary>
        /// Cylinder lub oil high sulphur remain on board. (litres)
        /// </summary>
        public double? RobLubOilCylinderHs { get; set; }

        /// <summary>
        /// Cylinder lub oil low sulphur remain on board. (litres)
        /// </summary>
        public double? RobLubOilCylinderLs { get; set; }

        /// <summary>
        /// Circulation lub oil main engines remain on board. (litres)
        /// </summary>
        public double? RobLubOilCirculationMe { get; set; }

        /// <summary>
        /// Circulation lub oil auxiliary engines remain on board. (litres)
        /// </summary>
        public double? RobLubOilCirculationAe { get; set; }

        /// <summary>
        /// Circulation lub oil of undefined source remain on board. (litres)
        /// </summary>
        public double? RobLubOilCirculationUndef { get; set; }

        /// <summary>
        /// Total circulation lub oil remain on board. (litres)
        /// </summary>
        public double? TotalRobLubOilCirculation { get; set; }

        /// <summary>
        /// Undefined lub oil remain on board. (litres)
        /// </summary>
        public double? RobLubOilUndef { get; set; }

        /// <summary>
        /// Fresh water drinking remain on board. (cubic meters).
        /// </summary>
        public double? RobFreshWaterDrinking { get; set; }

        /// <summary>
        /// Fresh water distilled remain on board. (cubic meters).
        /// </summary>
        public double? RobFreshWaterDistilled { get; set; }

        /// <summary>
        /// Fresh water undefined remain on board. (cubic meters).
        /// </summary>
        public double? RobFreshWaterUndef { get; set; }

        /// <summary>
        /// Total fuel oil bunkered. (metric tons).
        /// </summary>
        public double? TotalBunkerFuelOil { get; set; }

        /// <summary>
        /// Heavy fuel oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfo { get; set; }

        /// <summary>
        /// Heavy fuel oil high sulphur bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfoHs { get; set; }

        /// <summary>
        /// Heavy fuel oil low sulphur bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfoLs { get; set; }

        /// <summary>
        /// Heavy fuel oil ultra low sulphur bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfoLls { get; set; }

        /// <summary>
        /// Light fuel oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelLfo { get; set; }

        /// <summary>
        /// Marine diesel oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelMdo { get; set; }

        /// <summary>
        /// Marine gas oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelMgo { get; set; }

        /// <summary>
        /// Fuel oil propane bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelPropane { get; set; }

        /// <summary>
        /// Fuel oil butane bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelButane { get; set; }

        /// <summary>
        /// Fuel oil LNG bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelLng { get; set; }

        /// <summary>
        /// Fuel oil methanol bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelMethanol { get; set; }

        /// <summary>
        /// Fuel oil ethanol bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelEthanol { get; set; }

        /// <summary>
        /// Cylinder lub oil bunkered. (litres).
        /// </summary>
        public double? BunkerLubOilCylinder { get; set; }

        /// <summary>
        /// Cylinder high sulphur lub oil bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCylinderHs { get; set; }

        /// <summary>
        /// Cylinder low sulphur lub oil bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCylinderLs { get; set; }

        /// <summary>
        /// Undefined lub oil bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilUndef { get; set; }

        /// <summary>
        /// Circulation lub oil main engines bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCirculationMe { get; set; }

        /// <summary>
        /// Circulation lub oil auxiliary engines bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCirculationAe { get; set; }

        /// <summary>
        /// Circulation lub oil of undefined source bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCirculationUndef { get; set; }

        /// <summary>
        /// Total circulation oil bunkered. (litres)
        /// </summary>
        public double? TotalBunkerLubOilCirculation { get; set; }

        /// <summary>
        /// Bunker fresh water bunkered. (cubic meters)
        /// </summary>
        public double? BunkerFreshWaterBunkered { get; set; }

        /// <summary>
        /// Bunker fresh water produced. (cubic meters)
        /// </summary>
        public double? BunkerFreshWaterProduced { get; set; }

        /// <summary>
        /// Total fuel oil gain/loss. (metric tons)
        /// </summary>
        public double? TotalGainLossFuelOil { get; set; }

        /// <summary>
        /// Heavy fuel oil gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfo { get; set; }

        /// <summary>
        /// Heavy fuel oil high sulphur gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfoHs { get; set; }

        /// <summary>
        /// Heavy fuel oil low sulphur gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfoLs { get; set; }

        /// <summary>
        /// Heavy fuel oil ultra low sulphur gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfoLls { get; set; }

        /// <summary>
        /// Light fuel oil high gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelLfo { get; set; }

        /// <summary>
        /// Marine diesel oil gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelMdo { get; set; }

        /// <summary>
        /// Marine gas oil gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelMgo { get; set; }

        /// <summary>
        /// Fuel oil propane gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelPropane { get; set; }

        /// <summary>
        /// Fuel oil butane gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelButane { get; set; }

        /// <summary>
        /// Fuel oil LNG gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelLng { get; set; }

        /// <summary>
        /// Fuel oil methanol gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelMethanol { get; set; }

        /// <summary>
        /// Fuel oil ethanol gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelEthanol { get; set; }

        /// <summary>
        /// Cylinder lub oul gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCylinder { get; set; }

        /// <summary>
        /// Cylinder high sulphur lub oil gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCylinderHs { get; set; }

        /// <summary>
        /// Cylinder low sulphur lub oil gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCylinderLs { get; set; }

        /// <summary>
        /// Undefined lub oil gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilUndef { get; set; }

        /// <summary>
        /// Circulation lub oil main engines gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCirculationMe { get; set; }

        /// <summary>
        /// Circulation lub oil auxiliary engines gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCirculationAe { get; set; }

        /// <summary>
        /// Circulation lub oil of undefined source gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCirculationUndef { get; set; }

        /// <summary>
        /// Total circulation lub oil gain/loss. (litres)
        /// </summary>
        public double? TotalGainLossLubOilCirculation { get; set; }

        /// <summary>
        /// Total cylinder lub oil consumption (litres).
        /// </summary>
        public double? TotalCylinderOilConsumption { get; set; }

        /// <summary>
        /// Total cylinder high-sulphur lub oil consumption (litres).
        /// </summary>
        public double? TotalCylinderHsLubOilConsumption { get; set; }

        /// <summary>
        /// Total cylinder low-sulphur lub oil consumption (litres).
        /// </summary>
        public double? TotalCylinderLsLubOilConsumption { get; set; }

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
        /// Main engine HFO sulphur content (%).
        /// </summary>
        public double? MeHfoSulphurContent { get; set; }

        /// <summary>
        /// Main engine HFO HS sulphur content (%).
        /// </summary>
        public double? MeHfoHsSulphurContent { get; set; }

        /// <summary>
        /// Main engine HFO LS sulphur content (%).
        /// </summary>
        public double? MeHfoLsSulphurContent { get; set; }

        /// <summary>
        /// Main engine HFO LLS sulphur content (%).
        /// </summary>
        public double? MeHfoLlsSulphurContent { get; set; }

        /// <summary>
        /// Main engine HFO LFO sulphur content (%).
        /// </summary>
        public double? MeLfoSulphurContent { get; set; }

        /// <summary>
        /// Main engine MDO sulphur content (%).
        /// </summary>
        public double? MeMdoSulphurContent { get; set; }

        /// <summary>
        /// Main engine MDO HS sulphur content (%).
        /// </summary>
        public double? MeMdoHsSulphurContent { get; set; }

        /// <summary>
        /// Main engine MDO LS sulphur content (%).
        /// </summary>
        public double? MeMdoLsSulphurContent { get; set; }

        /// <summary>
        /// Main engine MDO LLS sulphur content (%).
        /// </summary>
        public double? MeMdoLlsSulphurContent { get; set; }

        /// <summary>
        /// Main engine MGO sulphur content (%).
        /// </summary>
        public double? MeMgoSulphurContent { get; set; }

        /// <summary>
        /// Main engine MGO LS sulphur content (%).
        /// </summary>
        public double? MeMgoLsSulphurContent { get; set; }

        /// <summary>
        /// Main engine MGO LLS sulphur content (%).
        /// </summary>
        public double? MeMgoLlsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine HFO sulphur content (%).
        /// </summary>
        public double? AeHfoSulphurContent { get; set; }

        /// <summary>
        /// Aux engine HFO HS sulphur content (%).
        /// </summary>
        public double? AeHfoHsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine HFO LS sulphur content (%).
        /// </summary>
        public double? AeHfoLsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine HFO LLS sulphur content (%).
        /// </summary>
        public double? AeHfoLlsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine LFO sulphur content (%).
        /// </summary>
        public double? AeLfoSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MDO sulphur content (%).
        /// </summary>
        public double? AeMdoSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MDO HS sulphur content (%).
        /// </summary>
        public double? AeMdoHsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MDO LS sulphur content (%).
        /// </summary>
        public double? AeMdoLsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MDO LLS sulphur content (%).
        /// </summary>
        public double? AeMdoLlsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MGO sulphur content (%).
        /// </summary>
        public double? AeMgoSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MGO LS sulphur content (%).
        /// </summary>
        public double? AeMgoLsSulphurContent { get; set; }

        /// <summary>
        /// Aux engine MGO LLS sulphur content (%).
        /// </summary>
        public double? AeMgoLlsSulphurContent { get; set; }

        /// <summary>
        /// Boiler HFO sulphur content (%).
        /// </summary>
        public double? AbHfoSulphurContent { get; set; }

        /// <summary>
        /// Boiler HFO HS sulphur content (%).
        /// </summary>
        public double? AbHfoHsSulphurContent { get; set; }

        /// <summary>
        /// Boiler HFO LS sulphur content (%).
        /// </summary>
        public double? AbHfoLsSulphurContent { get; set; }

        /// <summary>
        /// Boiler HFO LLS sulphur content (%).
        /// </summary>
        public double? AbHfoLlsSulphurContent { get; set; }

        /// <summary>
        /// Boiler LFO sulphur content (%).
        /// </summary>
        public double? AbLfoSulphurContent { get; set; }

        /// <summary>
        /// Boiler MDO sulphur content (%).
        /// </summary>
        public double? AbMdoSulphurContent { get; set; }

        /// <summary>
        /// Boiler MDO HS sulphur content (%).
        /// </summary>
        public double? AbMdoHsSulphurContent { get; set; }

        /// <summary>
        /// Boiler MDO LS sulphur content (%).
        /// </summary>
        public double? AbMdoLsSulphurContent { get; set; }

        /// <summary>
        /// Boiler MDO LLS sulphur content (%).
        /// </summary>
        public double? AbMdoLlsSulphurContent { get; set; }

        /// <summary>
        /// Boiler MGO sulphur content (%).
        /// </summary>
        public double? AbMgoSulphurContent { get; set; }

        /// <summary>
        /// Boiler MGO LS sulphur content (%).
        /// </summary>
        public double? AbMgoLsSulphurContent { get; set; }

        /// <summary>
        /// Boiler MGO LLS sulphur content (%).
        /// </summary>
        public double? AbMgoLlsSulphurContent { get; set; }

        /// <summary>
        /// ME SOx Emissions (t).
        /// </summary>
        public double? SoxEmissionsMe { get; set; }

        /// <summary>
        /// AE SOx Emissions (t).
        /// </summary>
        public double? SoxEmissionsAe { get; set; }

        /// <summary>
        /// Boiler SOx Emissions (t).
        /// </summary>
        public double? SoxEmissionsAb { get; set; }

        /// <summary>
        /// Total SOx Emissions (t).
        /// </summary>
        public double? TotalSoxEmissions { get; set; }

        /// <summary>
        /// ME NOx Emissions (t).
        /// </summary>
        public double? NoxEmissionsMe { get; set; }

        /// <summary>
        /// AE NOx Emissions (t).
        /// </summary>
        public double? NoxEmissionsAe { get; set; }

        /// <summary>
        /// Boiler NOx Emissions (t).
        /// </summary>
        public double? NoxEmissionsAb { get; set; }

        /// <summary>
        /// Total NOx Emissions (t).
        /// </summary>
        public double? TotalNoxEmissions { get; set; }

        /// <summary>
        /// Total main engine running hours.
        /// </summary>
        public double? TotalRunningHoursMe {get; set;}

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