using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class PerformanceReport
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "customId")]
        public string CustomId { get; set; }

        [JsonProperty(PropertyName = "imoNumber")]
        public int ImoNumber { get; set; }

        [JsonProperty(PropertyName = "timeStamp")]
        public DateTimeOffset TimeStamp { get; set; }

        [JsonProperty(PropertyName = "period")]
        public double? Period { get; set; }

        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StateOptions State { get; set; }

        [JsonProperty(PropertyName = "general")]
        public General General { get; set; }

        [JsonProperty(PropertyName = "navigation")]
        public Navigation Navigation { get; set; }

        [JsonProperty(PropertyName = "environment")]
        public Environment Environment { get; set; }

        [JsonProperty(PropertyName = "cargo")]
        public Cargo Cargo { get; set; }

        [JsonProperty(PropertyName = "engine")]
        public Engine Engine { get; set; }

        [JsonProperty(PropertyName = "discharge")]
        public Discharge Discharge { get; set; }

        [JsonProperty(PropertyName = "rob")]
        public ROB ROB { get; set; }

        [JsonProperty(PropertyName = "hull")]
        public Hull Hull { get; set; }

        [JsonProperty(PropertyName = "performanceIndicators")]
        public PerformanceIndicators PerformanceIndicators { get; set; }

        [JsonProperty(PropertyName = "custom")]
        public object Custom { get; set; }
    }
}