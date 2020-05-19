using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Main Engine of the vessel used for propulsion, which may be fitted with a shaft generator.
    /// </summary>
    public class MainEngine : InternalCombustionEngine
    {
        /// <summary>
        /// Running hours of shaft generator during reporting period. (Unit: hours)
        /// </summary>
        [JsonProperty(PropertyName = "runningHoursShaftGenerator")]
        public double? RunningHoursShaftGenerator { get; set; }

        /// <summary>
        /// Total number of shaft revolutions during reporting period.
        /// </summary>
        [JsonProperty(PropertyName = "shaftRevolutions")]
        public double? ShaftRevolutions { get; set; }

        /// <summary>
        /// Average shaft RPM over reporting period. (Unit: 1/min)
        /// </summary>
        [JsonProperty(PropertyName = "averageShaftRpm")]
        public double? AverageShaftRpm { get; set; }

        /// <summary>
        /// Average shaft power (measured behind shaft generator) over reporting period. (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "averageShaftPower")]
        public double? AverageShaftPower { get; set; }

        /// <summary>
        /// Generated shaft energy (measured behind shaft generator) during reporting period. (Unit: kJ)
        /// </summary>
        [JsonProperty(PropertyName = "generatedShaftEnergy")]
        public double? GeneratedShaftEnergy { get; set; }

        /// <summary>
        /// Average generator power (electrical) over reporting period. (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "averageGeneratorPower")]
        public double? AverageGeneratorPower { get; set; }

        /// <summary>
        /// Generated generator energy (electrical) during reporting period. (Unit: kJ)
        /// </summary>
        [JsonProperty(PropertyName = "generatedGeneratorEnergy")]
        public double? GeneratedGeneratorEnergy { get; set; }

        /// <summary>
        /// Pitch of propeller. (Unit: %)
        /// </summary>
        [JsonProperty(PropertyName = "propellerPitch")]
        public double? PropellerPitch { get; set; }

        /// <summary>
        /// Engine specific list of lub oil quantities consumed.
        /// </summary>
        [JsonProperty(PropertyName = "lubOilConsumptions")]
        public List<LubOilConsumption> LubOilConsumptions { get; set; }
    }
}