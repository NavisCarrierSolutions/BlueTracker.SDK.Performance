using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// Main Engine of the vessel used for propulsion, which may be fitted with a shaft generator.
    /// </summary>
    public class MainEngine: InternalCombustionEngine
    {
        /// <summary>
        /// Power produced by shaft generator. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "generatorPower")]
        public double? GeneratorPower { get; set; }

        /// <summary>
        /// Indication if generator is running.
        /// </summary>
        [JsonProperty(PropertyName = "generatorRunning")]
        public bool? GeneratorRunning { get; set; }

        /// <summary>
        /// Power produced by engine. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }

        /// <summary>
        /// Propeller pitch. (%)
        /// </summary>
        [JsonProperty(PropertyName = "propellerPitch")]
        public double? PropellerPitch { get; set; }

        /// <summary>
        /// Power on propeller shaft. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "shaftPower")]
        public double? ShaftPower { get; set; }

        /// <summary>
        /// RPM of engine.
        /// </summary>
        [JsonProperty(PropertyName = "shaftRpm")]
        public double? ShaftRpm { get; set; }

        /// <summary>
        /// Auxiliary blowers
        /// </summary>
        public List<AuxiliaryBlower> AuxBlowers { get; set; }

        /// <summary>
        /// Cylinder lub oil flow
        /// </summary>
        public CylLubOilFlow CylLubOilFlow { get; set; }
    }
}