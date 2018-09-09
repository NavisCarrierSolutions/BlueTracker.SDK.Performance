using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public abstract class FuelConsumer : Aggregate
    {
        public List<Consumption> Consumptions { get; set; }

        public double? TotalFoc { get; set; }

        public double? TotalFocIso { get; set; }

        public double? TotalCo2 { get; set; }
    }
}