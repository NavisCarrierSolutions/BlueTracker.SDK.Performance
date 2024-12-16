namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum VoyageInterruptionType
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Layup
        /// </summary>
        Layup = 1,

        /// <summary>
        /// Dry dock
        /// </summary>
        DryDock = 2,

        /// <summary>
        /// Emergency
        /// </summary>
        Emergency = 3,

        /// <summary>
        /// Ice
        /// </summary>
        Ice = 4,

        /// <summary>
        /// Maiden trip (voyage from new-building site to first load port).
        /// </summary>
        MaidenTrip = 5,

        /// <summary>
        /// Scrap trip (voyage from last discharge port to scrap site).
        /// </summary>
        ScrapTrip = 6
    }
}
