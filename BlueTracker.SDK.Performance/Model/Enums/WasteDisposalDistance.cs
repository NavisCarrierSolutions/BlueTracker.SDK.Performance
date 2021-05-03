namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Provides an enumeration of distances from the nearest land where the disposal took place.
    /// </summary>
    public enum WasteDisposalDistance
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// The disposal took place more than three nautical miles away from the nearest land.
        /// </summary>
        ThreeNauticalMiles = 1,

        /// <summary>
        /// The disposal took place more than twelve nautical miles away from the nearest land.
        /// </summary>
        TwelveNauticalMiles = 2
    }
}
