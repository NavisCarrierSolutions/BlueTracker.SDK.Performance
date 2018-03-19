using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Enums
{
    /// <summary>
    /// State of ships data interface.
    /// </summary>
    public enum FeedState
    {
        /// <summary>
        /// Indicates ship interface is online. New data items will trigger re-calculation immediatelly.
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        Online = 0,

        /// <summary>
        /// Indicates ship interface is in batch mode. New data items will not trigger re-calculation.
        /// </summary>
        [JsonProperty(PropertyName = "batchMode")]
        BatchMode = 1,

        /// <summary>
        /// Ship is pending for re-calculation. Data cannot be pushed.
        /// </summary>
        [JsonProperty(PropertyName = "pending")]
        Pending = 2,

        /// <summary>
        /// Ship is currently in re-calculation. Data cannot be pushed.
        /// </summary>
        [JsonProperty(PropertyName = "calculation")]
        Calculation = 3
    }
}