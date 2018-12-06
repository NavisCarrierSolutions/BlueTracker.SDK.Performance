using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Represents a fan in the sense of air moving device
    /// </summary>
    public class Fan : ElectricalMotor
    {
        /// <summary>
        /// Running level Low, Mid, High for fans.
        /// </summary>
        [JsonProperty("runningLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RunningLevelOptions? RunningLevel { get; set; }

        /// <summary>
        /// Direction of fan operation (exhaust/supply).
        /// </summary>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FanDirectionOptions? Direction { get; set; }

        /// <summary>
        /// Speed of fan in (RPM).
        /// </summary>
        [JsonProperty("speed")]
        public double? Speed { get; set; }
    }
}