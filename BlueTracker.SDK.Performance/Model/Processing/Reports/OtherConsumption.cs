﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class OtherConsumption
    {
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilConsumption> LubOil { get; set; }

        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterConsumption> FreshWater { get; set; }
    }
}