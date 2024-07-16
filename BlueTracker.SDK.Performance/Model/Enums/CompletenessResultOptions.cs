namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Provides an enumeration to distinguish completeness results.
    /// </summary>
    public enum CompletenessResultOptions
    {
        /// <summary>
        /// Indicates that some relevant data points have not been reported.
        /// </summary>
        Incomplete = 0,

        /// <summary>
        /// Indicates that all relevant data points have been reported.
        /// </summary>
        Complete = 1,

        /// <summary>
        /// Indicates that the corresponding completeness area is not licensed.
        /// </summary>
        NotLicensed = 2,

        /// <summary>
        /// Indicates that at the current state there are no completeness checks for the completeness area.
        /// </summary>
        NoChecks = 3
    }
}
