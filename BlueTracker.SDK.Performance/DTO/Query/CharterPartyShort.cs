﻿using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A charter party.
    /// </summary>
    public class CharterPartyShort
    {
        /// <summary>
        /// Id of charter party.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom id of charter party.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Start date of charter party.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// End date of charter party.
        /// </summary>
        [JsonProperty("validUntil")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Description of charter party.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// State of charter party.
        /// </summary>
        [JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterPartyState State { get; set; }
    }
}
