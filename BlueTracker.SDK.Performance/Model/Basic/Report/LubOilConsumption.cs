using System;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Provides information about consumed lub oil.
    /// </summary>
    public class LubOilConsumption
    {
        /// <summary>
        /// Kind of lub oil. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LubOilKindOptions Kind { get; set; }

        /// <summary>
        /// Volume of lub oil consumption. (litres) (Obsolete please use amount)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        [Obsolete("Use amount instead.")]
        public double? Volume { get; set; }

        /// <summary>
        /// Amount of lub oil consumption. (litres)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Density of lub oil.
        /// </summary>
        [JsonProperty(PropertyName = "density")]
        public double? Density { get; set; }

        /// <summary>
        /// Lub oil type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LubOilType Type { get; set; }
    }
}
