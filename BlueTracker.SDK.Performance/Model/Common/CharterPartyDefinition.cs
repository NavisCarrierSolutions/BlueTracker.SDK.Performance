using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Definition of consumption (charter) party
    /// </summary>
    public class CharterPartyDefinition
    {
         /// <summary>
        /// Major-/Minor- deviation limits.
        /// </summary>
        [JsonProperty("deviations")]
        public Deviation Deviations { get; set; }

        /// <summary>
        /// Sea state limit[bft].
        /// </summary>
        [JsonProperty("seaState")]
        public double? SeaState { get; set; }

        /// <summary>
        /// Wind force limit [bft].
        /// </summary>
        [JsonProperty("windForce")]
        public double? WindForce { get; set; }

        /// <summary>
        /// Wind speed limit [m/s].
        /// </summary>
        [JsonProperty("windSpeed")]
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Douglas sea scale [dgl].
        /// </summary>
        [JsonProperty("douglasSeaScale")]
        public double? DouglasSeaScale { get; set; }

        /// <summary>
        /// Gets or sets the maximal wave height [m].
        /// </summary>
        [JsonProperty("waveHeight")]
        public double? WaveHeight { get; set; }

        /// <summary>
        /// Get or sets the minimal sea water temperature [°C].
        /// </summary>
        [JsonProperty("seaWaterTemperatureMin")]
        public double? SeaWaterTemperatureMin { get; set; }

        /// <summary>
        /// Get or sets the maximal sea water temperature [°C].
        /// </summary>
        [JsonProperty("seaWaterTemperatureMax")]
        public double? SeaWaterTemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets the maximal swell height [m].
        /// </summary>
        [JsonProperty("swellHeight")]
        public double? SwellHeight { get; set; }

        /// <summary>
        /// Issues to be excluded.
        /// </summary>
        [JsonProperty("excludedIssues")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ExcludedIssues ExcludedIssues { get; set; }

        /// <summary>
        /// Points of speed vs consumption curve. For charter parties this will be set implicitly through
        /// the associated charter curve.
        /// </summary>
        [JsonProperty("curvePoints")]
        public CharterCurvePoint[] CurvePoints { get; set; }

        /// <summary>
        /// Drafts. For charter parties this will be set implicitly through
        /// the associated charter curve.
        /// </summary>
        [JsonProperty("drafts")]
        public CharterDraft[] Drafts { get; set; }

        /// <summary>
        /// Gets or sets the maximum allowed daily consumption [t/d]
        /// (Used only for charter party type ConsumptionCap).
        /// </summary>
        [JsonProperty("consumptionCap")]
        public double? ConsumptionCap { get; set; }

        /// <summary>
        /// Gets or sets the maximum allowed speed [kn]
        /// (Used only for charter party type ConsumptionCap).
        /// </summary>
        [JsonProperty("speedCap")]
        public double? SpeedCap { get; set; }

        /// <summary>
        /// Gets or sets the minimum required speed [kn]
        /// (Used only for charter party type ConsumptionCap).
        /// </summary>
        [JsonProperty("minimumSpeed")]
        public double? MinimumSpeed { get; set; }

        /// <summary>
        /// Gets or sets the charter party type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterPartyType Type { get; set; }

        /// <summary>
        /// Gets or sets the FOC type of the charter party.
        /// (Used only for charter party type ConsumptionCap).
        /// </summary>
        [JsonProperty("focType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterPartyFocType? FocType { get; set; }

        /// <summary>
        /// Gets or sets the weather source of the charter party.
        /// </summary>
        [JsonProperty("weatherSource")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeatherSourceOptions? WeatherSource { get; set; }

        /// <summary>
        /// Gets or sets the charter instructions of the charter party.
        /// (Used only for charter party type ConsumptionCap).
        /// </summary>
        [JsonProperty("charterPartyInstruction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterPartyInstruction? CharterPartyInstruction { get; set; }

        /// <summary>
        /// List of cargo conditions (Used only for charter party type ConsumptionCap with multiple instructions).
        /// </summary>
        [JsonProperty("cargoConditions")]
        public List<CargoCondition> CargoConditions { get; set; }
    }
}
