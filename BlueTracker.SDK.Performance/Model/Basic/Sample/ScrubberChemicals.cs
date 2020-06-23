using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberChemicals
    {
        /// <summary>
        ///     TypeOption of scrubber chemical
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ScrubberChemicalsTypeOptions Type { get; set; }

        /// <summary>
        ///     Sampling active (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "samplingActive")]
        public bool? SamplingActive { get; set; }

        /// <summary>
        ///     Temperature of chemical. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }

        /// <summary>
        ///     Volume flow of the chemical flow. (l/h)
        /// </summary>
        [JsonProperty(PropertyName = "volumeFlow")]
        public double? VolumeFlow { get; set; }

        /// <summary>
        ///     Mass flow of the chemical flow. (kg/h)
        /// </summary>
        [JsonProperty(PropertyName = "massFlow")]
        public double? MassFlow { get; set; }
        
        /// <summary>
        ///     Total consumption of the chemical by mass (t)
        /// </summary>
        [JsonProperty(PropertyName = "totalMassConsumption")]
        public double? TotalMassConsumption { get; set; }

        /// <summary>
        ///     Total consumption of the chemical by volume (m3)
        /// </summary>
        [JsonProperty(PropertyName = "TotalVolumeConsumption")]
        public double? TotalVolumeConsumption { get; set; }
    }
}
