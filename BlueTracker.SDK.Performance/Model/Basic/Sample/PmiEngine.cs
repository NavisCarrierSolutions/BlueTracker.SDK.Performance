using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Cylinder Pressure Measurement Interface
    /// </summary>
    public class PmiEngine
    {
        /// <summary>
        /// Number of cylinders
        /// </summary>
        [JsonProperty(PropertyName = "numberOfCylinders")]
        public int NumberOfCylinders { get; set; }

        /// <summary>
        /// Bore diameter of cylinders (meter)
        /// </summary>
        [JsonProperty(PropertyName = "cylinderBore")]
        public double? CylinderBore { get; set; }

        /// <summary>
        /// Length of cylinder connection rod (meter)
        /// </summary>
        [JsonProperty(PropertyName = "connectionRodLength")]
        public double? ConnectionRodLength { get; set; }

        /// <summary>
        /// Length of cylinder stroke (meter)
        /// </summary>
        [JsonProperty(PropertyName = "strokeLength")]
        public double? StrokeLength { get; set; }

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
        public List<PmiCylinder> Cylinders { get; set; }
    }
}