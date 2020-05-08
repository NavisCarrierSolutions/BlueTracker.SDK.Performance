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
        /// ID of ship.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the ship.
        /// </summary>
        [JsonProperty("uid")]
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
        /// Short name of ship.
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Alternative name of ship.
        /// </summary>
        [JsonProperty("alternativeName")]
        public string AlternativeName { get; set; }

        /// <summary>
        /// Radio call sign of vessel.
        /// </summary>
        [JsonProperty("callSign")]
        public string CallSign { get; set; }

        /// <summary>
        /// Email address of ship.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Second email address of ship.
        /// </summary>
        [JsonProperty("secondEmailAddress")]
        public string SecondEmailAddress { get; set; }

        /// <summary>
        /// Feed state (data interface state).
        /// </summary>
        [JsonProperty("feedState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeedState FeedState { get; set; }

        /// <summary>
        /// Indicates if ship is visible in UI to non-admin users.
        /// </summary>
        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// Class of the vessel.
        /// </summary>
        [JsonProperty("shipClass")]
        public ShipClassShort ShipClass { get; set; }

        /// <summary>
        /// Class of the vessel.
        /// </summary>
        [JsonProperty("owner")]
        public OwnerShort Owner { get; set; }

        /// <summary>
        /// Port of registry.
        /// </summary>
        [JsonProperty("portOfRegistry")]
        public OwnerShort PortOfRegistry { get; set; }
    }
}