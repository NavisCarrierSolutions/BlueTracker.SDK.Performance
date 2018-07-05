namespace BlueTracker.SDK.Performance.Enums
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
        PropellerCleaning = 4,
        
        /// <summary>
        /// Dry docking
        /// </summary>
        DryDocking = 5
    }
}
