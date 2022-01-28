using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class MainEngine : InternalCombustionEngine
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

        public double? SlipThroughWater { get; set; }

        public double? SlipOverGround { get; set; }

        public double? EngineDistance { get; set; }

        public List<LubOilConsumption> LubOilConsumptions { get; set; }
    }
}