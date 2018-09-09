namespace BlueTracker.SDK.Performance.Model.Processing.Reports
{
    public class AuxEngine : InternalCombustionEngine, IAttachedGenerator
    {
        public override string Name => $"AE{No}";

        public double? GeneratorEfficiency { get; set; }

        public double? AverageGeneratorPower { get; set; }

        public double? GeneratedGeneratorEnergy { get; set; }

        public double? RelativeGeneratorPower { get; set; }
    }
}