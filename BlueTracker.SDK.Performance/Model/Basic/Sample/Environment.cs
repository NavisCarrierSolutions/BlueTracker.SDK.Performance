using BlueTracker.SDK.Performance.Core;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Details of the vessel environment conditions (weather etc.).
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Outside air temperature. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "airTemp")]
        public double? AirTemp { get; set; }

        /// <summary>
        /// Outside air pressure. (hPa)
        /// </summary>
        [JsonProperty(PropertyName = "airPress")]
        public double? AirPress { get; set; }

        /// <summary>
        /// Sea water temperature. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "seaWaterTemp")]
        public double? SeaWaterTemp { get; set; }

        /// <summary>
        /// Sea water depth. (m)
        /// </summary>
        [JsonProperty(PropertyName = "seaWaterDepth")]
        public double? SeaWaterDepth { get; set; }

        /// <summary>
        /// Sea water depth below keel. (m)
        /// </summary>
        [JsonProperty(PropertyName = "seaWaterDepthBelowKeel")]
        public double? SeaWaterDepthBelowKeel { get; set; }

        /// <summary>
        /// Wind data.
        /// </summary>
        [JsonProperty(PropertyName = "wind")]
        public SpeedDirection Wind { get; set; }
    }
}
