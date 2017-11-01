using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// A sample of data from a vessel.
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// Imo number of vessel
        /// </summary>
        [JsonProperty(PropertyName = "imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Timestamp 
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTimeOffset? TimeStamp { get; set; }

        /// <summary>
        /// Navigational details
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public Navigation Navigation { get; set; }
        
        /// <summary>
        /// Details on environment
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public Environment Environment { get; set; }

        /// <summary>
        /// Engine details
        /// </summary>
        [JsonProperty(PropertyName = "engine")]
        public Engine Engine { get; set; }
    }
}
