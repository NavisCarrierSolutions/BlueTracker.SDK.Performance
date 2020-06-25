using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberPump : Pump
    {
        /// <summary>
        ///     Kind of scrubber pump
        /// </summary>
        [JsonProperty("type")]
        public ScrubberPumpTypeOptions Type { get; set; }
    }
}
