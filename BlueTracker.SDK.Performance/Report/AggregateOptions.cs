using System.Runtime.Serialization;

namespace BlueTracker.SDK.Performance.Report
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
        MainEngine,

        /// <summary>
        /// Auxilliary engine of a vessel (used for electrical power generation).
        /// </summary>
        [EnumMember(Value = "auxEngine")]
        AuxEngine,

        /// <summary>
        /// Auxilliary boiler of a vessel (with own fuel burner, no exhaust gas boiler).
        /// </summary>
        [EnumMember(Value = "boiler")]
        Boiler
    }
}