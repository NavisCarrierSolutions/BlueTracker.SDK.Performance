namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum WeatherSourceOptions
    {
        /// <summary>
        /// Weather source is not specified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Weather information comes from vessel reports.
        /// </summary>
        VesselReports = 1,

        /// <summary>
        /// Weather information comes from weather provider.
        /// </summary>
        WeatherProvider = 2
    }
}
