using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
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
        /// Details of wind.
        /// </summary>
        [JsonProperty(PropertyName = "wind")]
        public SpeedDirection Wind { get; set; }
    }
}
