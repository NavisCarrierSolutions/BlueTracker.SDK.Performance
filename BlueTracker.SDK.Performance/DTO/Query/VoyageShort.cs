using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    public class VoyageShort
    {
        /// <summary>
        /// ID of voyage.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name (or number) of voyage.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of service.
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
    }
}