﻿using System;
using System.ComponentModel.DataAnnotations;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Post
{
    /// <summary>
    /// A hull event.
    /// </summary>
    public class HullEventData
    {
        /// <summary>
        /// ID of event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID of hull event (maximum lenght: 50).
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship relating to hull event.
        /// </summary>
        [Required]
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Hull event time stamp in local time.
        /// </summary>
        [Required]
        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Type of hull event.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullEventType Type { get; set; }

        /// <summary>
        /// Maximally allowed annual speed loss degradation.
        /// </summary>
        [JsonProperty("maxYearlyDegradation")]
        public double? MaxYearlyDegradation { get; set; }

        /// <summary>
        /// Initial speed loss at hull event date.
        /// </summary>
        [JsonProperty("initialSpeedLoss")]
        public double? InitialSpeedLoss { get; set; }

        /// <summary>
        /// Allowed deviation from the maximally allowed yearly degradation (minor).
        /// </summary>
        [JsonProperty("toleranceMinor")]
        public double? ToleranceMinor { get; set; }

        /// <summary>
        /// Allowed deviation from the maximally allowed yearly degradation (major).
        /// </summary>
        [JsonProperty("toleranceMajor")]
        public double? ToleranceMajor { get; set; }

        /// <summary>
        /// Remarks of hull event.
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
    }
}