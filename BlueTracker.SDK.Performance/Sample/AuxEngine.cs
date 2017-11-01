using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Auxilliary Engine of vessel, used for electrical power generation.
    /// </summary>
    public class AuxEngine:InternalCombustionEngine
    {
        /// <summary>
        /// The electrical power of the generator (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "generatorPower")]
        public double? GeneratorPower { get; set; }

        /// <summary>
        /// The power of the engine (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }
    }
}
