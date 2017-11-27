using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Onboard sample.
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// IMO number of ship.
        /// </summary>
        [JsonProperty(PropertyName = "imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        /// <remarks>
        /// The custom ID can be used to identify a specific sample with an ID provided from the client.
        /// If a sample is send with an already exsiting custom ID, the respective sample will be
        /// replaced.
        /// </remarks>
        [JsonProperty(PropertyName = "customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Time stamp of sample.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTimeOffset? TimeStamp { get; set; }

        /// <summary>
        /// Navigational data.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public Navigation Navigation { get; set; }

        /// <summary>
        /// Environmental data.
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public Environment Environment { get; set; }

        /// <summary>
        /// Engine data.
        /// </summary>
        [JsonProperty(PropertyName = "engine")]
        public Engine Engine { get; set; }
    }
}
