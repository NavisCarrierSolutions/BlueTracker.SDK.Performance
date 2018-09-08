using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// A sfoc curve.
    /// </summary>
    public class SfocCurveShort 
    {
        /// <summary>
        /// ID of sfoc curve.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of sfoc curve.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Time stamp of creation of sfoc curve.
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
    }
}