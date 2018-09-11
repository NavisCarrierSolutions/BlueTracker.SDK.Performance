using BlueTracker.SDK.Performance.Model.Common;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Details of the vessel environment conditions (weather etc.).
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Outside air temperature. (Unit: °C)
        /// </summary>
        [JsonProperty(PropertyName = "airTemp")]
        public double? AirTemp { get; set; }

        /// <summary>
        /// Outside air pressure. (Unit: mbar)
        /// </summary>
        [JsonProperty(PropertyName = "airPress")]
        public double? AirPress { get; set; }

        /// <summary>
        /// Sea water temperature. (Unit: °C)
        /// </summary>
        [JsonProperty(PropertyName = "seaWaterTemp")]
        public double? SeaWaterTemp { get; set; }

        /// <summary>
        /// Sea state on Beaufort scale.
        /// </summary>
        [JsonProperty(PropertyName = "seaState")]
        public int? SeaState { get; set; }

        /// <summary>
        /// Douglas sea scale. (Douglas)
        /// </summary>
        [JsonProperty(PropertyName = "douglasSeaScale")]
        public int? DouglasSeaScale { get; set; }

        /// <summary>
        /// Details of waves.
        /// </summary>
        [JsonProperty(PropertyName = "wave")]
        public HeightDirection Wave { get; set; }

        /// <summary>
        /// Details of swell.
        /// </summary>
        [JsonProperty(PropertyName = "swell")]
        public HeightDirection Swell { get; set; }

        /// <summary>
        /// Details of wind.
        /// </summary>
        [JsonProperty(PropertyName = "wind")]
        public SpeedDirection Wind { get; set; }
    }
}