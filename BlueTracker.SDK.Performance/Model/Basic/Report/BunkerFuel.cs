﻿using BlueTracker.SDK.Performance.Model.Common;
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
        /// GHG intensity value 'E' (gCO2eq/MJ) represents greenhouse gas emissions per unit of energy for biofuels and e-fuels.
        /// </summary>
        [JsonProperty("ghgIntensityValue")]
        public double? GhgIntensityValue { get; set; }

        /// <summary>
        /// Reference to recognized certification scheme (ISSC, RSB, etc.) or Unique number of the Proof of Sustainability. 
        /// </summary>
        [JsonProperty("posNumber")]
        public string PosNumber { get; set; }
    }
}
