using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Tank
    {
        /// <summary>
        ///     Tank level (m)
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public double? Level { get; set; }

        /// <summary>
        ///     Tank temperature (C°)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temperature { get; set; }

        /// <summary>
        ///     Tank volume (m3)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }
    }
}