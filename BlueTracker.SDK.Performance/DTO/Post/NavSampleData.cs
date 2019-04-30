using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// Navigational sample data
    /// </summary>
    public class NavSampleData
    {
        /// <summary>
        /// UTC timestamp.
        /// </summary>
        [JsonProperty("timeStampUtc")]
        public DateTime TimeStampUtc { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        [JsonProperty("customId")]
        public int? CustomId { get; set; }

        /// <summary>
        /// Latitude [deg].
        /// </summary>
        [JsonProperty("lat")]
        public double? Lat { get; set; }

        /// <summary>
        /// Longitude [deg].
        /// </summary>
        [JsonProperty("lng")]
        public double? Lng { get; set; }

        /// <summary>
        /// Heading [deg]
        /// </summary>
        [JsonProperty("hdg")]
        public double? Hdg { get; set; }

        /// <summary>
        /// Course over ground [deg].
        /// </summary>
        [JsonProperty("cog")]
        public double? Cog { get; set; }

        /// <summary>
        /// Speed over ground [kn].
        /// </summary>
        [JsonProperty("sog")]
        public double? Sog { get; set; }

        /// <summary>
        /// Speed through water [kn].
        /// </summary>
        [JsonProperty("stw")]
        public double? Stw { get; set; }
    }
}
