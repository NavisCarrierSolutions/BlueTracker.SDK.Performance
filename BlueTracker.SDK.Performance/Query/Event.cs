using System;
using BlueTracker.SDK.Performance.Report;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// A navigation or organizational event.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// ID of event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Version Stamp when the event was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }

        /// <summary>
        /// Timestamp of event (including offset to UTC.)
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// Type of event.
        /// </summary>
        [JsonProperty("eventType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EventType EventType { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        [JsonProperty("ship")]
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Voyage info.
        /// </summary>
        [JsonProperty("voyage")]
        public VoyageShort Voyage { get; set; }

        /// <summary>
        /// Port info.
        /// </summary>
        [JsonProperty("port")]
        public PortShort Port { get; set; }

        /// <summary>
        /// UN-LOCODE of port (5-char code).
        /// </summary>
        [JsonProperty("portUnloc")]
        public string PortUnloc { get; set; }

        /// <summary>
        /// Name of port.
        /// </summary>
        [JsonProperty("portName")]
        public string PortName { get; set; }
    }
}