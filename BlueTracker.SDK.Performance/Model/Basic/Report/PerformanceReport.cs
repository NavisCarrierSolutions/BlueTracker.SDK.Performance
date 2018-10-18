using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// A performance report of a vessel.
    /// </summary>
    /// <remarks>
    /// To create a new report, leave the <see cref="Id"/> field empty, and set the <see cref="ImoNumber"/>.
    /// Additionally you may provide a custom reference in the <see cref="CustomId"/> field, which allows you
    /// to access or update the report by a custom identifier. You may use for example the primary ID of the
    /// report in the reporting system (which provides the data) as the custom reference. The combination of 
    /// <see cref="ImoNumber"/> and <see cref="CustomId"/> must be unique.
    /// 
    /// To update an existing report, you may use the primary identifier <see cref="Id"/> and the <see cref="ImoNumber"/>. 
    /// Alternativly you can provide the <see cref="CustomId"/> and <see cref="ImoNumber"/> to identify a report. 
    /// If the combination does not exist, a new report will be created.
    /// </remarks>
    public class PerformanceReport
    {
        /// <summary>
        /// Unique ID of report.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Customer specific ID of the report. It must be unique for a single vessel.
        /// </summary>
        /// <remarks>
        /// Use this field for a custom reference, to access the report at a later time. You may use the report
        /// identifier from the reporting system which provide the report data.
        /// </remarks>
        [JsonProperty(PropertyName = "customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// IMO number of vessel to which this report belongs.
        /// </summary>
        [JsonProperty(PropertyName = "imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Date, time and timezone of the report (effective time).
        /// </summary>
        /// <remarks>
        /// This reflects the effective time of the report (not the time when the report was created).
        /// The report covers the time (in hours of <see cref="Period"/>) before (and including) the <see cref="TimeStamp"/>.
        /// </remarks>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// Period which the report covers. (Unit: hours)
        /// </summary>
        /// <remarks>
        /// The report covers the time (in hours of <see cref="Period"/>) before (and including) the <see cref="TimeStamp"/>.
        /// </remarks>
        [JsonProperty(PropertyName = "period")]
        public double? Period { get; set; }

        /// <summary>
        /// The vessel operation state during the reporting period.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StateOptions State { get; set; }

        /// <summary>
        /// General details.
        /// </summary>
        [JsonProperty(PropertyName = "general")]
        public General General { get; set; }

        /// <summary>
        /// Navigational details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public Navigation Navigation { get; set; }

        /// <summary>
        /// Environmental details.
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public Environment Environment { get; set; }

        /// <summary>
        /// Cargo details.
        /// </summary>
        [JsonProperty(PropertyName = "cargo")]
        public Cargo Cargo { get; set; }

        /// <summary>
        /// Engine details.
        /// </summary>
        [JsonProperty(PropertyName = "engine")]
        public Engine Engine { get; set; }

        /// <summary>
        /// Fluid quantities remain on board.
        /// </summary>
        [JsonProperty(PropertyName = "rob")]
        public ROB ROB { get; set; }

        /// <summary>
        /// Fluid quantities bunkered.
        /// </summary>
        [JsonProperty(PropertyName = "bunker")]
        public Bunker Bunker { get; set; }

        /// <summary>
        /// Fluid quantities Gain/Loss.
        /// </summary>
        [JsonProperty(PropertyName = "gainLoss")]
        public GainLoss GainLoss { get; set; }

        /// <summary>
        /// Fluid quantities discharged.
        /// </summary>
        [JsonProperty(PropertyName = "discharge")]
        public Discharge Discharge { get; set; }

        /// <summary>
        /// Custom data fields.
        /// </summary>
        [JsonProperty(PropertyName = "custom")]
        public object Custom { get; set; }
    }
}
