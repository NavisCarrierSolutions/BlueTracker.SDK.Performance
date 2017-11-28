using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    [ExcludeFromCodeCoverage]
    /// <summary>
    /// Main Engine of the vessel used for propulsion, which may be fitted with a shaft generator.
    /// </summary>
    public class MainEngine: InternalCombustionEngine
    {
        ///// <summary>
        ///// Fuel flow details
        ///// </summary>
        //[JsonProperty(PropertyName = "fuelFlow")]
        //public FuelFlow FuelFlow { get; set; }

        /// <summary>
        /// Efficiency of generator
        /// </summary>
        [JsonProperty(PropertyName = "generatorEfficiency")]
        public double? GeneratorEfficiency { get; set; }

        /// <summary>
        /// Power of generator (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "generatorPower")]
        public double? GeneratorPower { get; set; }

        /// <summary>
        /// Is generator running
        /// </summary>
        [JsonProperty(PropertyName = "generatorRunning")]
        public bool? GeneratorRunning { get; set; }

        /// <summary>
        /// Power of main engine (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }

        /// <summary>
        /// Pitch of attached propeller. (Unit: m)
        /// </summary>
        [JsonProperty(PropertyName = "propellerPitch")]
        public double? PropellerPitch { get; set; }

        /// <summary>
        /// Is engine running?
        /// </summary>
        [JsonProperty(PropertyName = "running")]
        public bool? Running { get; set; }

        /// <summary>
        /// Power of shaft (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "shaftPower")]
        public double? ShaftPower { get; set; }

        /// <summary>
        /// RPMs of shaft (Unit 1/min)
        /// </summary>
        [JsonProperty(PropertyName = "shaftRpm")]
        public double? ShaftRpm { get; set; }
    }
}
