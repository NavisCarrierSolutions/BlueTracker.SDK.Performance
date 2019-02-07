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
        [JsonProperty(PropertyName = "IndicatedPressure")]
        public double? IndicatedPressure { get; set; }

        /// <summary>
        ///     P(comp) compression pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "CompressionPressure")]
        public double? CompressionPressure { get; set; }

        /// <summary>
        ///     P(max) maximum pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "MaximumPressure")]
        public double? MaximumPressure { get; set; }

        /// <summary>
        ///     P(scav) scavenging air pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "ScavengingAirPressure")]
        public double? ScavengingAirPressure { get; set; }
    }
}