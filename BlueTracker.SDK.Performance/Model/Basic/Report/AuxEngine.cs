using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Auxilliary Engine of vessel, used for electrical power generation.
    /// </summary>
    public class AuxEngine : FuelConsumer
    {
        /// <summary>
        /// The average electrical power of the generator during reporting period. (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "averageGeneratorPower")]
        public double? AverageGeneratorPower { get; set; }

        /// <summary>
        /// The total generated electrical power of the generator during reporting period. (Unit: kJ)
        /// </summary>
        [JsonProperty(PropertyName = "generatedGeneratorEnergy")]
        public double? GeneratedGeneratorEnergy { get; set; }
    }
}