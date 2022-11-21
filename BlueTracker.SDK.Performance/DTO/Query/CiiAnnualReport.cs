using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// CII annual report for a specific year and ship.
    /// </summary>
    public class CiiAnnualReport
    {
        /// <summary>
        /// Id of annual report.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// IMO number of ship.
        /// </summary>
        [JsonProperty("imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Year of annual report.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// Total CO2 emitted during the year [metric tons].
        /// </summary>
        [JsonProperty("co2Emitted")]
        public double? Co2Emitted { get; set; }

        /// <summary>
        /// Total distance sailed during the year [nautical miles].
        /// </summary>
        [JsonProperty("distanceSailed")]
        public double? DistanceSailed { get; set; }

        /// <summary>
        /// Required CII [Grams CO2 per deadweight and nautical mile].
        /// </summary>
        [JsonProperty("requiredCii")]
        public double? RequiredCii { get; set; }

        /// <summary>
        /// Actual attained CII [Grams CO2 per deadweight and nautical mile].
        /// </summary>
        [JsonProperty("attainedCii")]
        public double? AttainedCii { get; set; }

        /// <summary>
        /// Actual attained CII with corrections applied [Grams CO2 per deadweight and nautical mile].
        /// </summary>
        [JsonProperty("attainedCiiCorrected")]
        public double? AttainedCiiCorrected { get; set; }

        /// <summary>
        /// Rating of actual attained CII [A or B or C or D or E].
        /// </summary>
        [JsonProperty("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Rating of actual attained CII corrected [A or B or C or D or E].
        /// </summary>
        [JsonProperty("ratingCorrected")]
        public string RatingCorrected { get; set; }
    }
}
