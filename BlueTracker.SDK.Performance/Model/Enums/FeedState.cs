using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// State of ships data interface.
    /// </summary>
    public enum FeedState
    {
        /// <summary>
        /// Indicates ship interface is online. New data items will trigger re-calculation immediately.
        /// </summary>
        Online = 0,

        /// <summary>
        /// Indicates ship interface is in batch mode. New data items will not trigger re-calculation.
        /// </summary>
        BatchMode = 1,

        /// <summary>
        /// Ship is pending for re-calculation. Data cannot be pushed.
        /// </summary>
        Pending = 2,

        /// <summary>
        /// Ship is currently in re-calculation. Data cannot be pushed.
        /// </summary>
        Calculation = 3,

        /// <summary>
        /// Last re-calculation run has failed.
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        Failed = 4,

        /// <summary>
        /// Ship is marked for deletion.
        /// </summary>
        [JsonProperty(PropertyName = "deletion")]
        Deletion = 5,

        /// <summary>
        /// Re-calculation is failing permanently.
        /// </summary>
        [JsonProperty(PropertyName = "permanentlyFailed")]
        PermanentlyFailed = 6
    }
}