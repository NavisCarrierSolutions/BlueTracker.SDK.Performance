using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     A pump
    /// </summary>
    public class Pump : ElectricalMotor
    {
        /// <summary>
        ///     Frequency (Hz)
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public double? Frequency { get; set; }

        /// <summary>
        ///     Temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public double? Temperature { get; set; }

        /// <summary>
        ///     Inlet pressure (bar)
        /// </summary>
        [JsonProperty(PropertyName = "inletPress")]
        public double? InletPress { get; set; }

        /// <summary>
        ///     Outlet pressure (bar)
        /// </summary>
        [JsonProperty(PropertyName = "outletPress")]
        public double? OutletPress { get; set; }
    }
}