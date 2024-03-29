﻿using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class LubOilConsumption
    {
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "volume")]
        [Obsolete("Legacy code, this will be removed in the future.")]
        public double? Volume { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}
