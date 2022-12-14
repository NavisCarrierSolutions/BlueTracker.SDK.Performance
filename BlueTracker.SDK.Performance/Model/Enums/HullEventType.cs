namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Type of hull event.
    /// </summary>
    public enum HullEventType
    {
        /// <summary>
        /// Unspecified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// New paint.
        /// </summary>
        NewPaint = 1,

        /// <summary>
        /// Hull cleaning.
        /// </summary>
        HullCleaning = 2,

        /// <summary>
        /// Hull modification.
        /// </summary>
        HullModification = 3,

        /// <summary>
        /// Propeller cleaning
        /// </summary>
        PropellerCleaning = 4
    }
}
