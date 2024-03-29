﻿using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        /// Custom ID of report.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of the ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Delete Flag.
        /// </summary>
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        /// Time stamp of report (Local).
        /// </summary>
        [JsonProperty("timeStampLocal")]
        public DateTime TimeStampLocal { get; set; }

        /// <summary>
        /// Time stamp of report (UTC).
        /// </summary>
        [JsonProperty("timeStampUtc")]
        public DateTime TimeStampUtc { get; set; }

        /// <summary>
        /// State of ship
        /// </summary>
        [JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StateOptions State { get; set; }

        /// <summary>
        /// Version stamp
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }
    }
}
