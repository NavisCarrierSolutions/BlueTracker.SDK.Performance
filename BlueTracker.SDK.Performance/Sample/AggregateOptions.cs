using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
{
    /// <summary>
    /// Types of aggregates.
    /// </summary>
    public enum AggregateOptions
    {
        /// <summary>
        /// Main engine of a vessel (used for propulsion), which may be fitted with a shaft generator.
        /// </summary>
        [JsonProperty(PropertyName = "mainEngine")]
        [EnumMember(Value = "mainEngine")]
        MainEngine,

        /// <summary>
        /// Auxilliary engine of a vessel (used for electrical power generation).
        /// </summary>
        [JsonProperty(PropertyName = "auxEngine")]
        [EnumMember(Value = "auxEngine")]
        AuxEngine,

        /// <summary>
        /// Auxilliary boiler of a vessel (with own fuel burner, no exhaust gas boiler).
        /// </summary>
        /// [EnumMember(Value = "boiler")]
        [JsonProperty(PropertyName = "boiler")]
        Boiler
    }
}
