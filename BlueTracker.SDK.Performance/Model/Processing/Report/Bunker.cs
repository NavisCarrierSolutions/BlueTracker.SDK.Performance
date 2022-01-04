using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class Bunker
    {
        [JsonProperty(PropertyName = "fuelOil")]
        public List<BunkerFuel> FuelOil { get; set; }

        [JsonProperty(PropertyName = "lubOil")]
        public List<BunkerLubOil> LubOil { get; set; }

        [JsonProperty(PropertyName = "freshWater")]
        public List<BunkerFreshWater> FreshWater { get; set; }

        public Dictionary<FuelKindOptions, double?> TotalBunkerFuelKind { get; set; }

        public Dictionary<LubOilKindOptions, double?> TotalBunkerLubOilKind { get; set; }

        public Dictionary<FreshWaterTypeOptions, double?> TotalBunkerFreshWaterType { get; set; }

        public Dictionary<LubOilAggregateOptions, double?> TotalBunkerLubOilCirculationAggregate { get; set; }

        public double? TotalBunkerFuel { get; set; }

        public double? TotalBunkerCirculationOil { get; set; }
    }
}
