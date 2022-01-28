namespace BlueTracker.SDK.Performance.DTO.Query
{
    public abstract class InternalCombustionEngine : FuelConsumer
    {
        public double? AveragePower { get; set; }

        public double? GeneratedEnergy { get; set; }

        public double? Sfoc { get; set; }

        public double? SfocIso { get; set; }

        public double? AverageNoxValue { get; set; }
    }
}