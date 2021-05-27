using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class CargoCondition
    {
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
        /// Speed instruction of cargo condition.
        /// </summary>
        [JsonProperty(PropertyName = "charterSpeedInstruction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterSpeedInstruction CharterSpeedInstruction { get; set; }

        /// <summary>
        /// Voyage status of cargo condition.
        /// </summary>
        [JsonProperty(PropertyName = "charterVoyageStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterVoyageStatus CharterVoyageStatus { get; set; }
    }
}
