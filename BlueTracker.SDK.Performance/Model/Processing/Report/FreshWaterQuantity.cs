using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class FreshWaterQuantity
    {
        [JsonProperty(PropertyName = "freshWaterKind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions FreshWaterKind { get; set; }

        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        [Obsolete("Please use freshWaterKind.")]
        public FreshWaterKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }
    }
}