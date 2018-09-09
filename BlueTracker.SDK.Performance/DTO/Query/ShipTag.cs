namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A tag/ship association.
    /// </summary>
    public class ShipTag
    {
        /// <summary>
        /// ID of association.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ship of association.
        /// </summary>
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Tag of association.
        /// </summary>
        public TagShort Tag { get; set; }
    }
}