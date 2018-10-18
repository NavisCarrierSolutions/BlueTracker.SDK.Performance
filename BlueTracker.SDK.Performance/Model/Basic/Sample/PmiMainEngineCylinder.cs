using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// PMI information for a cylinder
    /// </summary>
    public class PmiMainEngineCylinder
    {
        /// <summary>
        /// P(i) indicated pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "indicatedPressure")]
        public double? IndicatedPressure { get; set; }

        /// <summary>
        /// P(comp) compression pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "compressionPressure")]
        public double? CompressionPressure { get; set; }

        /// <summary>
        /// P(max) maximum pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "maximumPressure")]
        public double? MaximumPressure { get; set; }

        /// <summary>
        /// P(scav) scavenging air pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "scavengingAirPressure")]
        public double? ScavengingAirPressure { get; set; }
        
        /// <summary>
        /// List of pressure values (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "pressureValues")]
        public List<PmiDegreePressureValue> PressureValues { get; set; }
    }
}