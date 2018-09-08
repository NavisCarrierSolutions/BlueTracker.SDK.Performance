namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public abstract class Aggregate
    {
        public int No { get; set; }

        public abstract string Name { get; }

        public double? RunningHours { get; set; }
    }
}