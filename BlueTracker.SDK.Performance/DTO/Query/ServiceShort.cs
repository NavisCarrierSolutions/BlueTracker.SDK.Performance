using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    public class ServiceShort
    {
        /// <summary>
        /// Id (given by bluetracker.one)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}