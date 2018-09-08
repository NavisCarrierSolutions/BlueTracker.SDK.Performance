namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public abstract class InternalCombustionEngine : FuelConsumer
    {
        public double? AveragePower { get; set; }

        public double? GeneratedEnergy { get; set; }

        public double? Sfoc { get; set; }

        public double? SfocIso { get; set; }
    }
}