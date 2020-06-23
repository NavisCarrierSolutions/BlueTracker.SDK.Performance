using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberTank : Tank
    {
        /// <summary>
        ///     Kind of scrubber tank
        /// </summary>
        [JsonProperty("type")]
        public ScrubberTankTypeOptions Type { get; set; }
    }
}