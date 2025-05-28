using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Types of aggregates.
    /// </summary>
    public enum AggregateOptions
    {
        /// <summary>
        /// Main engine of a vessel (used for propulsion), which may be fitted with a shaft generator.
        /// </summary>
        [EnumMember(Value = "mainEngine")]
        [JsonProperty(PropertyName = "mainEngine")]
        MainEngine,

        /// <summary>
        /// Auxiliary engine of a vessel (used for electrical power generation).
        /// </summary>
        [EnumMember(Value = "auxEngine")]
        [JsonProperty(PropertyName = "auxEngine")]
        AuxEngine,

        /// <summary>
        /// Auxiliary boiler of a vessel (with own fuel burner, no exhaust gas boiler).
        /// </summary>
        [EnumMember(Value = "boiler")]
        [JsonProperty(PropertyName = "boiler")]
        Boiler,

        /// <summary>
        /// Inert Gas Generator
        /// </summary>
        [EnumMember(Value = "inertGasGenerator")]
        [JsonProperty(PropertyName = "inertGasGenerator")]
        InertGasGenerator,

        /// <summary>
        /// Incinerator
        /// </summary>
        [EnumMember(Value = "incinerator")]
        [JsonProperty(PropertyName = "incinerator")]
        Incinerator,

        /// <summary>
        /// Cargo Boiler
        /// </summary>
        [EnumMember(Value = "cargoBoiler")]
        [JsonProperty(PropertyName = "cargoBoiler")]
        CargoBoiler
    }
}
