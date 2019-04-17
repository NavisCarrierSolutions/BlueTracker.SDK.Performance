using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class SeaWaterCooler
    {
        /// <summary>
        ///     Inlet Temperature (C°).
        /// </summary>
        [JsonProperty("inletTemp")]
        public double? InletTemperature { get; set; }

        /// <summary>
        ///     Inlet pressure (bar).
        /// </summary>
        [JsonProperty("inletPressure")]
        public double? InletPressure { get; set; }

        /// <summary>
        ///     Outlet Temperature (C°).
        /// </summary>
        [JsonProperty("outletTemp")]
        public double? OutletTemperature { get; set; }

        /// <summary>
        ///     Outlet pressure (bar).
        /// </summary>
        [JsonProperty("outletPressure")]
        public double? OutletPressure { get; set; }
    }
}