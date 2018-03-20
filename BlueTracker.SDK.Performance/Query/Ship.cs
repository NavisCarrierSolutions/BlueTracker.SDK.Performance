using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
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
        /// Time stamp of ship creation.
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Current change tracking version stamp.
        /// </summary>
        [JsonProperty("currentVersionStamp")]
        public long CurrentVersionStamp { get; set; }

        /// <summary>
        /// Feed state (data interface state).
        /// </summary>
        [JsonProperty("feedState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeedState FeedState { get; set; }

        /// <summary>
        /// Ship class associated with ship.
        /// </summary>
        [JsonProperty("shipClass")]
        public ShipClassShort ShipClass { get; set; }

        /// <summary>
        /// Owner associated with ship.
        /// </summary>
        [JsonProperty("owner")]
        public OwnerShort Owner { get; set; }

        /// <summary>
        /// Port of registry.
        /// </summary>
        [JsonProperty("portOfRegistry")]
        public PortShort PortOfRegistry { get; set; }
        
        /// <summary>
        /// Tags associated with ship.
        /// </summary>
        [JsonProperty("tags")]
        public List<TagShort> Tags { get; set; }

        /// <summary>
        /// Second email address of ship.
        /// </summary>
        [JsonProperty("secondEmailAddress")]
        public string SecondEmailAddress { get; set; }

        /// <summary>
        /// Email address of ship.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }
}