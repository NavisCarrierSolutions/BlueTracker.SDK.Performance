using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Post
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
        /// Custom name of a hull event (maximum length: 50).
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Custom ID of hull event (maximum length: 50).
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship relating to hull event.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Hull event time stamp in local time.
        /// </summary>
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

        /// <summary>
        /// Vertical sides type.
        /// </summary>
        [JsonProperty("verticalSidesType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullCoatingType? VerticalSidesType { get; set; }

        /// <summary>
        /// Vertical sides product description.
        /// </summary>
        [JsonProperty("verticalSidesProduct")]
        public string VerticalSidesProduct { get; set; }

        /// <summary>
        /// Vertical sides supplier.
        /// </summary>
        [JsonProperty("verticalSidesSupplier")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullCoatingSupplier? VerticalSidesSupplier { get; set; }

        /// <summary>
        /// Vertical sides thickness in μm.
        /// </summary>
        [JsonProperty("verticalSidesThickness")]
        public double? VerticalSidesThickness { get; set; }

        /// <summary>
        /// Vertical sides preparation method.
        /// </summary>
        [JsonProperty("verticalSidesPreparation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullCoatingPreparation? VerticalSidesPreparation { get; set; }

        /// <summary>
        /// Flat bottom type.
        /// </summary>
        [JsonProperty("flatBottomType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullCoatingType? FlatBottomType { get; set; }

        /// <summary>
        /// Flat bottom product description.
        /// </summary>
        [JsonProperty("flatBottomProduct")]
        public string FlatBottomProduct { get; set; }

        /// <summary>
        /// Flat bottom supplier.
        /// </summary>
        [JsonProperty("flatBottomSupplier")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullCoatingSupplier? FlatBottomSupplier { get; set; }

        /// <summary>
        /// Flat bottom thickness in μm.
        /// </summary>
        [JsonProperty("flatBottomThickness")]
        public double? FlatBottomThickness { get; set; }

        /// <summary>
        /// Flat bottom preparation method.
        /// </summary>
        [JsonProperty("flatBottomPreparation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HullCoatingPreparation? FlatBottomPreparation { get; set; }

        /// <summary>
        /// General hull coating comments.
        /// </summary>
        [JsonProperty("hullCoatingComments")]
        public string HullCoatingComments { get; set; }
    }
}
