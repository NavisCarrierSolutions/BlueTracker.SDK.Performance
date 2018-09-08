using System.Collections.Generic;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class ROB
    {
        [JsonProperty(PropertyName = "fuelOil")]
        public List<FuelQuantity> FuelOil { get; set; }

        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilQuantity> LubOil { get; set; }

        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterQuantity> FreshWater { get; set; }

        public Dictionary<FuelKindOptions, double?> TotalFuelQuantityKind { get; set; }

        public Dictionary<LubOilKindOptions, double?> TotalLubOilQuantityKind { get; set; }

        public Dictionary<AggregateOptions, double?> TotalLubOilCirculationAggregate { get; set; }

        public Dictionary<FreshWaterKindOptions, double?> TotalFreshWaterQuantityKind { get; set; }

        public double? TotalFuelQuantity { get; set; }

        public double? TotalCirculationOilRob { get; set; }

        public double? TotalFreshWaterQuantity { get; set; }
    }
}