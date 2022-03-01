using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class LubOilType
    {
        [JsonProperty(PropertyName = "tbn")]
        public double? TBN { get; set; }
    }
}