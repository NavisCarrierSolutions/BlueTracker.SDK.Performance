namespace BlueTracker.SDK.Performance.Processing.Reports
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