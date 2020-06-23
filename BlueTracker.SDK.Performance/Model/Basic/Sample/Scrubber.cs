using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Scrubber : Aggregate
    {
        /// <summary>
        ///     Power produced scrubber system. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }

        /// <summary>
        ///     Kind of scrubber
        /// </summary>
        [JsonProperty("type")]
        public ScrubberTypeOptions Type { get; set; }

        /// <summary>
        ///     Open loop active? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "openLoopActive")]
        public bool? OpenLoopActive { get; set; }

        /// <summary>
        ///     Closed loop active? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "closedLoopActive")]
        public bool? ClosedLoopActive { get; set; }

        /// <summary>
        ///     Standby active? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "standByActive")]
        public bool? StandbyActive { get; set; }

        /// <summary>
        ///     EMU compliant? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "eMUCompliant")]
        public bool? EMUCompliant { get; set; }

        /// <summary>
        ///    Concentration of SO2 [ppm]
        /// </summary>
        [JsonProperty("SO2-Concentration")]
        public double? SO2Concentration{ get; set; }

        /// <summary>
        ///    Concentration of CO2 [%]
        /// </summary>
        [JsonProperty("CO2-Concentration")]
        public double? CO2Concentration { get; set; }

        /// <summary>
        ///    Ratio of SO2-CO2 [ppm/%]
        /// </summary>
        [JsonProperty("SO2CO2Ratio")]
        public double? SO2CO2Ratio { get; set; }

        /// <summary>
        ///    Seawater press (bar)
        /// </summary>
        [JsonProperty(PropertyName = "seawaterPressure")]
        public double? SeawaterPressure { get; set; }

        /// <summary>
        ///    Seawater flow (m3/h)
        /// </summary>
        [JsonProperty(PropertyName = "seawaterFlow")]
        public double? SeawaterFlow { get; set; }

        /// <summary>
        ///    Nozzlewater press (bar)
        /// </summary>
        [JsonProperty(PropertyName = "nozzlewaterPressure")]
        public double? NozzlewaterPressure { get; set; }

        /// <summary>
        ///    Demister press (mbar)
        /// </summary>
        [JsonProperty(PropertyName = "demisterPressure")]
        public double? DemisterPressure { get; set; }

        /// <summary>
        ///     Temperature of precooling. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "precoolingTemp")]
        public double? PrecoolingTemp { get; set; }
    }
}
