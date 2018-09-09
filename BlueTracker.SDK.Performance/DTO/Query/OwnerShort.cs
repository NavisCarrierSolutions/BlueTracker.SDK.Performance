using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Short representation of an owner.
    /// </summary>
    public class OwnerShort
    {
        /// <summary>
        /// ID of owner.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom id of owner.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Name of owner.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
