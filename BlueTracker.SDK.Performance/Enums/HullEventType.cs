namespace BlueTracker.SDK.Performance.Enums
{
    /// <summary>
    /// Type of hull event.
    /// </summary>
    public enum HullEventType
    {
        // WARNING! Do not change the number assignment, because it is used in the DB.

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
