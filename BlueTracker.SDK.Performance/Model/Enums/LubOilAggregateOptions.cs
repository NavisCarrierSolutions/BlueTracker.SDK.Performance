using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum LubOilAggregateOptions
    {
        /// <summary>
        /// Main engine of a vessel (used for propulsion), which may be fitted with a shaft generator.
        /// </summary>
        [EnumMember(Value = "mainEngine")]
        [JsonProperty(PropertyName = "mainEngine")]
        MainEngine,

        /// <summary>
        /// Auxilliary engine of a vessel (used for electrical power generation).
        /// </summary>
        [EnumMember(Value = "auxEngine")]
        [JsonProperty(PropertyName = "auxEngine")]
        AuxEngine,

        /// <summary>
        /// Auxilliary boiler of a vessel (with own fuel burner, no exhaust gas boiler).
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
        /// Undefined
        /// </summary>
        Undefined
    }
}
