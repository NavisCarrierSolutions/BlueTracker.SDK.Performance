using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class ElectricalDevice : EnergyConsumer
    {
        /// <summary>
        /// Running level e.g. Low, Mid, High for fans
        /// </summary>
        [JsonProperty("runningLevel")]
        public int? RunningLevel { get; set; }

        /// <summary>
        /// Running hours since first usage
        /// </summary>
        [JsonProperty("runningHours")]
        public int? RunningHours { get; set; }
    }
}
