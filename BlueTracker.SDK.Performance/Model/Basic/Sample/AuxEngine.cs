using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    ///     Auxilliary engine of vessel, used for electrical power generation.
    /// </summary>
    public class AuxEngine : InternalCombustionEngine
    {
        /// <summary>
        ///     Power produced by generator. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "generatorPower")]
        public double? GeneratorPower { get; set; }

        /// <summary>
        ///     Power produced by engine. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }
    }
}