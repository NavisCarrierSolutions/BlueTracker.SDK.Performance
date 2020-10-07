using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Provides information about consumed fresh water.
    /// </summary>
    public class FreshWaterConsumption
    {
        /// <summary>
        /// Purpose of fresh water consumption. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterConsumptionPurposeOptions Purpose { get; set; }

        /// <summary>
        /// Kind of fresh water consumption. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "freshWaterKind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FreshWaterKindOptions FreshWaterKind { get; set; }

        /// <summary>
        /// Purpose of fresh water consumption. (Obsolete, please use purpose instead.)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        [Obsolete("Use purpose instead.")]
        public FreshWaterConsumptionPurposeOptions Kind { get; set; }

        /// <summary>
        /// Volume of fresh water (cubic metres). (Obsolete, please use amount instead)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        [Obsolete("Use amount instead.")]
        public double? Volume { get; set; }

        /// <summary>
        /// Amount of fresh water (cubic metres).
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }
    }
}
