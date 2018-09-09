using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// A voyage (full rotation).
    /// </summary>
    public class VoyageData
    {
        /// <summary>
        /// ID of voyage.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom Id.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name (or number) of voyage.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of service associated with voyage.
        /// </summary>
        [JsonProperty("serviceId")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// Name of service associated with voyage.
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
    }
}