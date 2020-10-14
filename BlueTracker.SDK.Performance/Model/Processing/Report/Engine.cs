using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class Engine
    {
        public double? EngineRoomTemp { get; set; }

        public double? CoolingWaterTemp { get; set; }

        public bool? IsTcCutout { get; set; }

        public bool? IsSlowSteaming { get; set; }

        public bool? IsCombinatorMode { get; set; }

        public bool? IsOnShorePowerSupply { get; set; }

        public bool? IsOnScrubberMode { get; set; }

        public double? TotalFoc { get; set; }

        public double? TotalFocIso { get; set; }

        public double? TotalCo2 { get; set; }

        public double? AverageShaftRpm { get; set; }

        public double? AverageSlip { get; set; }

        public double? TotalAverageMePower { get; set; }

        public double? TotalAverageAePower { get; set; }

        public double? AverageRelativeMePower { get; set; }

        public double? AverageRelativeAePower { get; set; }

        public double? TotalAverageShaftPower { get; set; }

        public double? TotalAverageElectricalPower { get; set; }

        public double? TotalGeneratedMeEnergy { get; set; }

        public double? TotalGeneratedAeEnergy { get; set; }

        public double? TotalGeneratedShaftEnergy { get; set; }

        public double? TotalGeneratedElectricalEnergy { get; set; }

        public double? TotalCylinderOilConsumption { get; set; }

        public double? TotalCylinderHsLubOilConsumption { get; set; }

        public double? TotalCylinderLsLubOilConsumption { get; set; }

        public List<MainEngine> MainEngines { get; set; }

        public List<AuxEngine> AuxEngines { get; set; }

        public List<Boiler> Boilers { get; set; }

        public List<AggregateConsumption> Consumptions { get; set; }

        public OtherConsumption OtherConsumptions { get; set; }

        public Dictionary<AggregateOptions, double?> TotalFocAggregate { get; set; }

        public Dictionary<AggregateOptions, double?> TotalFocIsoAggregate { get; set; }

        public Dictionary<AggregateOptions, double?> TotalCo2Aggregate { get; set; }

        public Dictionary<AggregateOptions, double?> TotalSfocAggregate { get; set; }

        public Dictionary<AggregateOptions, double?> TotalSfocIsoAggregate { get; set; }

        public Dictionary<AggregateOptions, double?> TotalLubOilCirculationAggregate { get; set; }

        public Dictionary<FreshWaterConsumptionPurposeOptions, double?> TotalFreshWaterConsumptionPurpose { get; set; }

        public Dictionary<FuelKindOptions, double?> TotalFocFuelKind { get; set; }

        public Dictionary<FuelKindOptions, double?> TotalFocIsoFuelKind { get; set; }

        public Dictionary<FuelKindOptions, double?> TotalCo2FuelKind { get; set; }
    }
}