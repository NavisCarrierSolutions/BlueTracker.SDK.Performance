using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class LubOilType
    {
        /// <summary>
        /// Total Base number. (mgKOH/g)
        /// </summary>
        [JsonProperty(PropertyName = "tbn")]
        public double? TBN { get; set; }
    }
}