using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     Cylinder pressure measurement interface
    /// </summary>
    public class PmiData
    {
        /// <summary>
        ///     P(i) indicated pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "indicatedPressure")]
        public double? IndicatedPressure { get; set; }

        /// <summary>
        ///     P(comp) compression pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "compressionPressure")]
        public double? CompressionPressure { get; set; }

        /// <summary>
        ///     P(max) maximum pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "maximumPressure")]
        public double? MaximumPressure { get; set; }

        /// <summary>
        ///     P(scav) scavenging air pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "scavengingAirPressure")]
        public double? ScavengingAirPressure { get; set; }
    }
}