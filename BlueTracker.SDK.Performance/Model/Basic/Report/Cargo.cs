using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Details of Cargo.
    /// </summary>
    public class Cargo
    {
        /// <summary>
        /// Total weigth of cargo loaded. (Unit: metric tons)
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Cargo volume. (m³)
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Number of passengers.
        /// </summary>
        [JsonProperty(PropertyName = "passengers")]
        public int? Passengers { get; set; }

        /// <summary>
        /// Total weight water ballast. (Unit: metric tons)
        /// </summary>
        [JsonProperty(PropertyName = "ballast")]
        public double? Ballast { get; set; }

        /// <summary>
        /// Number of full TEU loaded. (Unit: pieces)
        /// </summary>
        /// <remarks>
        /// This value should reflect both 20' and 40' units, where a 40' unit count as two 20' units.
        /// </remarks>
        [JsonProperty(PropertyName = "teuFull")]
        public double? TeuFull { get; set; }

        /// <summary>
        /// Number of empty TEU loaded. (Unit: pieces)
        /// </summary>
        /// <remarks>
        /// This value should reflect both 20' and 40' units, where a 40' unit count as two 20' units.
        /// </remarks>
        [JsonProperty(PropertyName = "teuEmpty")]
        public double? TeuEmpty { get; set; }

        /// <summary>
        /// Number of live reefers loaded. (Unit: pieces)
        /// </summary>
        /// <remarks>
        /// Empty (non-live) reefers should be added to <see cref="TeuEmpty"/>. Loaded (live) reefers
        /// should be added to <see cref="TeuFull"/> as well.
        /// </remarks>
        [JsonProperty(PropertyName = "reefers")]
        public int? Reefers { get; set; }
    }
}