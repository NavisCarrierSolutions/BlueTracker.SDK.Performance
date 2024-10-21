using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class BunkerFuel
    {
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        [JsonProperty(PropertyName = "bdnNumber")]
        public string BdnNumber { get; set; }

        /// <summary>
        /// GHG intensity value 'E' (gCO2eq/MJ) represents greenhouse gas emissions per unit of energy for biofuels and e-fuels.
        /// </summary>
        [JsonProperty("ghgIntensityValue")]
        public double? GhgIntensityValue { get; set; }

        /// <summary>
        /// Reference to recognized certification schemes (ISSC, RSB, etc.) or Unique numbers of the Proof of Sustainability. 
        /// </summary>
        [JsonProperty("posNumbers")]
        public List<Pos> PosNumbers { get; set; }

        /// <summary>
        /// Energy content of the biofuel. (MJ)
        /// </summary>
        public double? BioEnergy { get; set; }
    }
}
