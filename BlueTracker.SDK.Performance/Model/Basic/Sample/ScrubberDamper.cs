using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberDamper
    {
        /// <summary>
        ///     Kind of scrubber damper
        /// </summary>
        [JsonProperty("type")]
        public ScrubberDamperTypeOptions Type { get; set; }

        /// <summary>
        ///     Direction of scrubber damper
        /// </summary>
        [JsonProperty("direction")]
        public ScrubberDamperDirectionOptions Direction { get; set; }
        
        /// <summary>
        ///     Number of engine
        /// </summary>
        [JsonProperty(PropertyName = "engineNumber")]
        public int EngineNumber { get; set; }

        /// <summary>
        ///     Indication if damper open
        /// </summary>
        [JsonProperty(PropertyName = "isOpen")]
        public bool? IsOpen { get; set; }
    }
}
