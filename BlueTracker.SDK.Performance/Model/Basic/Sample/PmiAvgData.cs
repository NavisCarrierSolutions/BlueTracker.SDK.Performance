using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Cylinder pressure measurement interface (engine average all cylinders)
    /// </summary>
    public class PmiAvgData
    {
        /// <summary>
        /// Average P(i) indicated pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "avgIndicatedPressure")]
        public double? AvgIndicatedPressure { get; set; }

        /// <summary>
        /// Average P(comp) compression pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "avgCompressionPressure")]
        public double? AvgCompressionPressure { get; set; }

        /// <summary>
        /// Average P(max) maximum pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "avgMaximumPressure")]
        public double? AvgMaximumPressure { get; set; }

        /// <summary>
        /// Average P(scav) scavenging air pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "avgScavengingAirPressure")]
        public double? AvgScavengingAirPressure { get; set; }
    }
}