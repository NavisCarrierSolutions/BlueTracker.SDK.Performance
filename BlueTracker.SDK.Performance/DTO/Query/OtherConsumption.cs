using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class OtherConsumption
    {
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilAggregateConsumption> LubOil { get; set; }

        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterConsumption> FreshWater { get; set; }
    }
}
