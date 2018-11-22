using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class ElectricalMotor : EnergyConsumer
    {
        /// <summary>
        /// Running level Low, Mid, High for fans.
        /// </summary>
        [JsonProperty("runningLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RunningLevelOptions? RunningLevel { get; set; }

        /// <summary>
        /// Running hours since first usage.
        /// </summary>
        [JsonProperty("runningHours")]
        public double? RunningHours { get; set; }

        /// <summary>
        /// Load of motor (%).
        /// </summary>
        [JsonProperty("load")]
        public double? Load { get; set; }
    }
}