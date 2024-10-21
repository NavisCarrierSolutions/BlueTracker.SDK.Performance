using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class BunkerFuel
    {
        /// <summary>
        /// Kind of fuel. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        /// <summary>
        /// Amount of fuel bunkered. (tons)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Fuel type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        [JsonProperty("bdnNumber")]
        public string BdnNumber { get; set; }

        /// <summary>
        /// Reference to recognized certification schemes (ISSC, RSB, etc.) or Unique numbers of the Proof of Sustainability. 
        /// </summary>
        [JsonProperty("posNumber")]
        public List<Pos> PosNumbers { get; set; }
    }
}
