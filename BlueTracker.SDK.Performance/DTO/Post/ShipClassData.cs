using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// A ship class.
    /// </summary>
    public class ShipClassData
    {
        /// <summary>
        /// Name of ship class.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of ship yard.
        /// </summary>
        [JsonProperty("yardName")]
        public string YardName { get; set; }
    }
}