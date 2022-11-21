using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class PerformanceReportShort
    {
        /// <summary>
        /// ID of report.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Time stamp of report local time
        /// </summary>
        [JsonProperty("timeStampLocal")]
        public DateTime TimeStampLocal { get; set; }
        
        /// <summary>
        /// Time stamp of report UTC.
        /// </summary>
        [JsonProperty("timeStampUtc")]
        public DateTime TimeStampUtc { get; set; }
    }
}