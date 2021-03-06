﻿namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public interface IAttachedGenerator
    {
        int No { get; }

        string Name { get; }

        double? AverageGeneratorPower { get; set; }

        double? GeneratedGeneratorEnergy { get; set; }

        double? GeneratorEfficiency { get; set; }
    }
}