using System;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// Charter party payload.
    /// </summary>
    public class CharterPartyData
    {
        /// <summary>
        /// ID of charter party.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID of charter party (maximum length: 50).
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship relating to hull event.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Associated charter curve.
        /// </summary>
        [JsonProperty("charterCurveId")]
        public int? CharterCurveId { get; set; }

        /// <summary>
        /// Definition of charter party.
        /// </summary>
        [JsonProperty("definition")]
        public CharterPartyDefinition Definition { get; set; }

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
