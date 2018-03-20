using System;
using BlueTracker.SDK.Performance.Enums;
using BlueTracker.SDK.Performance.Report;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Post
{
    /// <summary>
    /// A navigation or organizational event.
    /// </summary>
    public class EventData
    {
        /// <summary>
        /// ID of event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID of event (maximum lenght: 50).
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship relating to event.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// ID of voyage associated with event.
        /// </summary>
        [JsonProperty("voyageId")]
        public int VoyageId { get; set; }

        /// <summary>
        /// Name of voyage associated with event.
        /// </summary>
        [JsonProperty("voyageName")]
        public string VoyageName { get; set; }

        /// <summary>
        /// UN-LOCODE of port associated with event.
        /// </summary>
        [JsonProperty("portUnloc")]
        public string PortUnloc { get; set; }

        /// <summary>
        /// Name of port associated with event.
        /// </summary>
        [JsonProperty("portName")]
        public string PortName { get; set; }

        /// <summary>
        /// Type of event
        /// </summary>
        [JsonProperty("eventType")]
        public EventType EventType { get; set; }

        /// <summary>
        /// Event time stamp in local time.
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Event time stamp in UTC.
        /// </summary>
        [JsonProperty("timeStampUtc")]
        public DateTime? TimeStampUtc { get; set; }
    }
}