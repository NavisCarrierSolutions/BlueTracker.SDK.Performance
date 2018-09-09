using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A voyage (full rotation).
    /// </summary>
    public class Voyage
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
        /// Version Stamp when the voyage was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }

        /// <summary>
        /// Name (or number) of voyage.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        [JsonProperty("ship")]
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Service info.
        /// </summary>
        [JsonProperty("service")]
        public ServiceShort Service { get; set; }
    }
}