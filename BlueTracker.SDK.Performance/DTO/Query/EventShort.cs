using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class EventShort
    {
        /// <summary>
        /// ID of the event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

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
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of voyage.
        /// </summary>
        [JsonProperty("voyageName")]
        public string VoyageName { get; set; }

        /// <summary>
        /// UN-LOCODE of port (5-char Code).
        /// </summary>
        [JsonProperty("portUnloc")]
        public string PortUnloc { get; set; }

        /// <summary>
        /// Name of port.
        /// </summary>
        [JsonProperty("portName")]
        public string PortName { get; set; }

        /// <summary>
        /// Terminal code of port.
        /// </summary>
        [JsonProperty("portTerminalCode")]
        public string PortTerminalCode { get; set; }
    }
}