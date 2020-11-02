using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class GainLoss
    {
        [JsonProperty(PropertyName = "fuelOil")]
        public List<GainLossFuelQuantity> FuelOil { get; set; }

        [JsonProperty(PropertyName = "lubOil")]
        public List<GainLossLubOilQuantity> LubOil { get; set; }

        public Dictionary<FuelKindOptions, double?> TotalGainLossFuelOilKind { get; set; }

        public Dictionary<LubOilKindOptions, double?> TotalGainLossLubOilKind { get; set; }

        public Dictionary<AggregateOptions, double?> TotalGainLossLubOilCirculationAggregate { get; set; }

        public double? TotalGainLossFuelOil { get; set; }

        public double? TotalGainLossCirculationOil { get; set; }

    }
}
