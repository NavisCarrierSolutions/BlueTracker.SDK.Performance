namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Specifies the reason why a vessel's connection to on-shore power supply was interrupted or lost.
    /// </summary>
    /// <remarks>Use this enumeration to indicate the cause of an on-shore power supply disconnection or interruption
    /// for a vessel that was previously connected. This information can be used for diagnostics, reporting, or to
    /// determine appropriate follow-up actions.</remarks>
    public enum OnShorePowerSupplyInterruptionReason
    {
        /// <summary>
        /// Indicates that no specific reason is set.
        /// </summary>
        /// <remarks>Use this value when the reason for the interruption is not specified or applicable. Typically used
        /// as a default or placeholder.</remarks>
        Unspecified = 0,
        /// <summary>
        /// Indicates that the connection was interrupted because there is not enough shore power available to meet the
        /// vessel's power demand.
        /// </summary>
        /// <remarks>This value identifies situations where external power supply limitations caused the vessel to lose
        /// its on-shore power connection.</remarks>
        InsufficientShorePowerAvailable = 1,
        /// <summary>
        /// Indicates that the vessel's on-board energy generation is required, causing the disconnection from shore power.
        /// </summary>
        OnBoardEnergyGenerationRequired = 2,
        /// <summary>
        /// Indicates that the connection was interrupted for conducting a functional test of the vessel's power systems.
        /// </summary>
        FunctionalTest = 3,
        /// <summary>
        /// Indicates that the connection was interrupted to perform a survey or inspection of the vessel.
        /// </summary>
        SurveyOrInspection = 4
    }
}
