using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Represents a generic aggregate.
    /// </summary>
    public class Aggregate
    {
        /// <summary>
        /// Number (or position) of aggregate within aggregate group (e.g. auxilliary engine).
        /// </summary>
        /// <remarks>
        /// To denote the auxilliary engine number 2 on the vessel, the value 2 should be used here.
        /// </remarks>
        [JsonProperty(PropertyName = "no", Order = 1)]
        public int No { get; set; }
    }
}
