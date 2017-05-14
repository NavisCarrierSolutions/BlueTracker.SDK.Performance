using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Post
{
    /// <summary>
    /// A tag.
    /// </summary>
    public class TagData
    {
        /// <summary>
        /// Name of tag.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}