using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the pumps on board.
    /// </summary>
    public class Pumps
    {
        /// <summary>
        /// Fuel pumps
        /// </summary>
        [JsonProperty("fuelPumps")]
        public FuelPumps FuelPumps { get; set; }
    }
}
