namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Location
    /// </summary>
    public class Location
    {
        /// <summary>
        /// UN/LOCODE (United Nations code for trade and transport locations)
        /// </summary>
        public string Unloc { get; set; }

        /// <summary>
        /// Latitude. Positive values are north of the equator.
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// Longitude. Positive values are east of the prime meridian.
        /// </summary>
        public double Lng { get; set; }
    }
}
