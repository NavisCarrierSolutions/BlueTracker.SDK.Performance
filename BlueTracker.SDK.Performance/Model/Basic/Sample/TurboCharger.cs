using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// A turgo charger
    /// </summary>
    public class TurboCharger
    {
        /// <summary>
        /// Speed
        /// </summary>
        [JsonProperty(PropertyName = "speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Exhaust gas temperature
        /// </summary>
        [JsonProperty(PropertyName = "exhaustGasTemp")]
        public double? ExhaustGasTemp { get; set; }
    }
}