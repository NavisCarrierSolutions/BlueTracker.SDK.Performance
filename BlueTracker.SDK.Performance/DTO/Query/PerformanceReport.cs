﻿using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Performance report metadata.
    /// </summary>
    public class PerformanceReport
    {
        /// <summary>
        /// ID of report.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Version Stamp when the report was created or changed.
        /// </summary>
        [JsonProperty("versionStamp")]
        public long VersionStamp { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        [JsonProperty("ship")]
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Time stamp of report (including UTC Offset).
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTimeOffset TimeStamp { get; set; }
    }
}