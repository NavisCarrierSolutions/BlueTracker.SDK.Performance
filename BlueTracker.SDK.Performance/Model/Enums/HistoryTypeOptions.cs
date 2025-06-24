namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum HistoryTypeOptions
    {
        /// <summary>
        /// Default. History entry is created due to a report creation or update.
        /// </summary>
        Default = 0,

        /// <summary>
        /// History entry is created because a user acknowledged some plausibility issues.
        /// </summary>
        Acknowledged = 1,

        /// <summary>
        /// History entry is created because a user dis-acknowledged some plausibility issues.
        /// </summary>
        DisAcknowledged = 2
    }
}
