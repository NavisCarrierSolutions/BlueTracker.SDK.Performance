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
        /// Time stamp of report (including UTC Offset).
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// Version Stamp when the report was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }
    }
}