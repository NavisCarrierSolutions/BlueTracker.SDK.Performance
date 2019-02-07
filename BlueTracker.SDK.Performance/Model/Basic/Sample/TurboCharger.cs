using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// A turgo charger
    /// </summary>
    public class TurboCharger
    {
        /// <summary>
        ///     Number (or position) of turbo charger
        /// </summary>
        [JsonProperty(PropertyName = "no", Order = 1)]
        public int No { get; set; }

        /// <summary>
        /// Speed (rpm)
        /// </summary>
        [JsonProperty(PropertyName = "speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Exhaust gas temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "exhaustGasTemp")]
        public double? ExhaustGasTemp { get; set; }
    }
}