namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public abstract class Aggregate
    {
        public int No { get; set; }

        public abstract string Name { get; }

        public double? RunningHours { get; set; }
    }
}