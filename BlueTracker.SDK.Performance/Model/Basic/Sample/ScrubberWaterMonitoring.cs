using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberWaterMonitoring
    {
        /// <summary>
        ///     Type of water monitoring
        /// </summary>
        [JsonProperty("type")]
        public ScrubberWaterMonitoringTypeOptions Type { get; set; }

        /// <summary>
        ///     Flow [l/min]
        /// </summary>
        [JsonProperty(PropertyName = "flow")]
        public double? Flow { get; set; }

        /// <summary>
        ///     Turbidity [FNU]
        /// </summary>
        [JsonProperty(PropertyName = "turbidity")]
        public double? Turbidity { get; set; }

        /// <summary>
        ///     pH-Value [pH]
        /// </summary>
        [JsonProperty(PropertyName = "pH")]
        public double? PH { get; set; }

        /// <summary>
        ///     PAH-Value [µg/l]
        /// </summary>
        [JsonProperty(PropertyName = "pAH")]
        public double? PAH { get; set; }

        /// <summary>
        ///     Temperature [C°].
        /// </summary>
        [JsonProperty("temp")]
        public double? Temperature { get; set; }

        /// <summary>
        ///     Pressure [bar].
        /// </summary>
        [JsonProperty("pressure")]
        public double? Pressure { get; set; }

        /// <summary>
        ///     Conductivity [S/m].
        /// </summary>
        [JsonProperty("conductivity")]
        public double? Conductivity { get; set; }
    }
}
