using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Processing.Core
{
    public class SpeedDirection
    {
        [JsonProperty(PropertyName = "speedTrue")]
        public double? SpeedTrue { get; set; }

        [JsonProperty(PropertyName = "speedRel")]
        public double? SpeedRel { get; set; }

        [JsonProperty(PropertyName = "directionTrue")]
        public double? DirectionTrue { get; set; }

        [JsonProperty(PropertyName = "directionRel")]
        public double? DirectionRel { get; set; }
    }
}