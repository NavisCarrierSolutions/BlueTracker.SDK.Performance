using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ScrubberSystems
    {
        /// <summary>
        ///     Total power produced by all scrubber systems. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "totalPower")]
        public double? TotalPower { get; set; }

        /// <summary>
        ///     Total load of all scrubber systems. (%)
        /// </summary>
        [JsonProperty(PropertyName = "totalLoad")]
        public double? TotalLoad { get; set; }

        /// <summary>
        ///     Set point of emissions [%S]
        /// </summary>
        [JsonProperty(PropertyName = "emissionSetPoint")]
        public double? EmissionSetPoint { get; set; }

        /// <summary>
        ///     Information about chemicals used in scrubber systems
        /// </summary>
        [JsonProperty(PropertyName = "chemicals")]
        public ScrubberChemicals Chemicals { get; set; }

        /// <summary>
        ///     Information about water in scrubber systems
        /// </summary>
        [JsonProperty(PropertyName = "waterMonitoring")]
        public List<ScrubberWaterMonitoring> WaterMonitoring { get; set; }

        /// <summary>
        ///     Scrubber Tanks
        /// </summary>
        [JsonProperty("tanks")]
        public List<ScrubberTank> ScrubberTanks { get; set; }

        /// <summary>
        ///     Dampers
        /// </summary>
        [JsonProperty("dampers")]
        public List<ScrubberDamper> Dampers { get; set; }

        /// <summary>
        ///     Valves
        /// </summary>
        [JsonProperty("valves")]
        public List<ScrubberValve> Valves { get; set; }

        /// <summary>
        ///     Exhaust Gas
        /// </summary>
        [JsonProperty("exhaustGases")]
        public List<ScrubberExhaustGas> ExhaustGases { get; set; }

        /// <summary>
        ///     Pumps
        /// </summary>
        [JsonProperty("pumps")]
        public List<ScrubberPump> Pumps { get; set; }

        /// <summary>
        ///     Main Scrubbers
        /// </summary>
        [JsonProperty(PropertyName = "mainScrubbers")]
        public List<Scrubber> MainScrubbers { get; set; }

        /// <summary>
        ///     Auxiliary Scrubbers
        /// </summary>
        [JsonProperty(PropertyName = "auxScrubbers")]
        public List<Scrubber> AuxScrubbers { get; set; }

    }
}