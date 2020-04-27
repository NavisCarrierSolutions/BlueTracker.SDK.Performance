using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A ship.
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// Unique identifier of the ship.
        /// </summary>
        [JsonProperty("Uid")]
        public Guid Uid { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of ship.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Feed state (data interface state).
        /// </summary>
        [JsonProperty("feedState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeedState FeedState { get; set; }
       
    }
}