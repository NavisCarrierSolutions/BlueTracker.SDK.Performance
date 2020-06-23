using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberValve
    {
        /// <summary>
        ///     Number of Valve
        /// </summary>
        [JsonProperty(PropertyName = "no")]
        public int No { get; set; }

        /// <summary>
        ///     Kind of scrubber valve
        /// </summary>
        [JsonProperty("type")]
        public ScrubberValveTypeOptions Type { get; set; }

        /// <summary>
        ///     Indication if valve open
        /// </summary>
        [JsonProperty(PropertyName = "isOpen")]
        public bool? IsOpen { get; set; }
    }
}
