using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Ship
{
    /// <summary>
    /// Aggregate.
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// Number of aggregate.
        /// </summary>
        [JsonProperty(PropertyName = "no")]
        public int No { get; set; }
    }
}