namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class MainEngine : InternalCombustionEngine, IAttachedGenerator
    {
        public override string Name => $"ME{No}";

        public double? RunningHoursShaftGenerator { get; set; }

        public double? AverageShaftRpm { get; set; }

        public double? ShaftRevolutions { get; set; }

        public double? GeneratorEfficiency { get; set; }

        public double? AverageShaftPower { get; set; }

        public double? GeneratedShaftEnergy { get; set; }

        public double? AverageGeneratorPower { get; set; }

        public double? RelativePower { get; set; }

        public double? GeneratedGeneratorEnergy { get; set; }

        public double? PropellerPitch { get; set; }

        public double? Slip { get; set; }
    }
}