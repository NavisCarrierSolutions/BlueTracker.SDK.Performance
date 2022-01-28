using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class AuxEngine : InternalCombustionEngine
    {
        public override string Name => $"AE{No}";


        public double? GeneratorEfficiency { get; set; }


        public double? AverageGeneratorPower { get; set; }


        public double? GeneratedGeneratorEnergy { get; set; }


        public double? RelativeGeneratorPower { get; set; }


        public double? Load { get; set; }


        public List<LubOilConsumption> LubOilConsumptions { get; set; }
    }
}