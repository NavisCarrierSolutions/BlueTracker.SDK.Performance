namespace BlueTracker.SDK.Performance.Enums
{
    /// <summary>
    /// Type of hull model.
    /// </summary>
    public enum HullModelType
    {
        /// <summary>
        /// One-dimensional model (power vs. speed).
        /// </summary>
        SpeedPower = 0,

        /// <summary>
        /// Two-dimensional model (power vs. speed/draft).
        /// </summary>
        SpeedDraftPower = 1,

        /// <summary>
        /// Three-dimensional model (power vs. speed/draft/trim).
        /// </summary>
        SpeedDraftTrimPower = 2
    }
}
