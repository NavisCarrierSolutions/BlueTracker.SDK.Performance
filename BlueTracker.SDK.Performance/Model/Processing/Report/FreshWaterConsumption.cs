using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class FreshWaterConsumption
    {
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterConsumptionPurposeOptions Purpose { get; set; }

        [JsonProperty(PropertyName = "freshWaterKind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions FreshWaterKind { get; set; }

        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        [Obsolete("Please use freshWaterKind instead.")]
        public FreshWaterConsumptionPurposeOptions Kind { get; set; }

        [JsonProperty(PropertyName = "volume")]
        [Obsolete("Please use amount instead.")]
        public double? Volume { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }
    }
}