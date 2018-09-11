using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// A hull interruption.
    /// </summary>
    public class HullInterruptionData
    {
        /// <summary>
        /// ID of event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID of hull interruption (maximum lenght: 50).
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship relating to hull interruption.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Start date of hull interruption in local time.
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End date of hull interruption in local time.
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Type of hull interruption.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullInterruptionType Type { get; set; }

        /// <summary>
        /// Remarks of hull interruption.
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
    }
}
