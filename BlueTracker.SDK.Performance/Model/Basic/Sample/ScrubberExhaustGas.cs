using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberExhaustGas
    {
        /// <summary>
        ///     Type of exhaust gas
        /// </summary>
        [JsonProperty("type")]
        public ScrubberExhaustGasTypeOptions Type { get; set; }
        
        /// <summary>
        ///     Number of engine
        /// </summary>
        [JsonProperty(PropertyName = "engineNumber")]
        public int EngineNumber { get; set; }

        /// <summary>
        ///     Downstream [mbar]
        /// </summary>
        [JsonProperty(PropertyName = "downstream")]
        public double? Downstream { get; set; }
        
        /// <summary>
        ///     Press before Scrubber [mbar]
        /// </summary>
        [JsonProperty(PropertyName = "pressBeforeScrubber")]
        public double? PressBeforeScrubber { get; set; }

        /// <summary>
        ///     Press after Scrubber [mbar]
        /// </summary>
        [JsonProperty(PropertyName = "pressAfterScrubber")]
        public double? PressAfterScrubber { get; set; }
        
        /// <summary>
        ///     Temperature before Scrubber [C°]
        /// </summary>
        [JsonProperty(PropertyName = "tempBeforeScrubber")]
        public double? TempBeforeScrubber { get; set; }

        /// <summary>
        ///     Temperature after Scrubber [C°]
        /// </summary>
        [JsonProperty(PropertyName = "tempAfterScrubber")]
        public double? TempAfterScrubber { get; set; }

        /// <summary>
        ///     Press after Boiler [mbar]
        /// </summary>
        [JsonProperty(PropertyName = "pressAfterBoiler")]
        public double? PressAfterBoiler { get; set; }
        
        /// <summary>
        ///     Difference press [mbar]
        /// </summary>
        [JsonProperty(PropertyName = "differencePress")]
        public double? DifferencePress { get; set; }

        /// <summary>
        ///     Temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }
    }
}
