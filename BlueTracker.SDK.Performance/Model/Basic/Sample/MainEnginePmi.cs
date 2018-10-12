using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Cylinder Pressure Measurement Interface
    /// </summary>
    public class MainEnginePmi
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
        [JsonProperty(PropertyName = "avgAvgMaximumPressure")]
        public double? AvgMaximumPressure { get; set; }

        /// <summary>
        /// Average P(scav) scavenging air pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "avgAvgScavengingAirPressure")]
        public double? AvgScavengingAirPressure { get; set; }

        /// <summary>
        /// List of cylinder PMI information (1-n cylinders)
        /// </summary>
        [JsonProperty(PropertyName = "cylinders")]
        public List<PmiMainEngineCylinder> Cylinders { get; set; }
    }
}