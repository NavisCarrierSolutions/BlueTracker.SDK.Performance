using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Id (given by bluetracker.one)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom Id (given by customer)
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}