using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Processing.Core
{
    public class LubOilType
    {
        [JsonProperty(PropertyName = "tbn")]
        public double? TBN { get; set; }
    }
}