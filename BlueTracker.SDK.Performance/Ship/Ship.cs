namespace BlueTracker.SDK.Performance.Ship
{
    /// <summary>
    /// A ship class.
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// Service speed of vessel (design speed). (knots)
        /// </summary>
        public double? ServiceSpeed { get; set; }

        /// <summary>
        /// Ship type. (enumeration)
        /// </summary>
        /// <seealso cref="ShipType"/>
        public ShipType? ShipType { get; set; }

        /// <summary>
        /// Hull type. (enumeration)
        /// </summary>
        /// <seealso cref="Hull"/>
        public Hull Hull { get; set; }

        /// <summary>
        /// Cargo related information.
        /// </summary>
        /// <seealso cref="Cargo"/>
        public Cargo Cargo { get; set; }

        /// <summary>
        /// Engine related information.
        /// </summary>
        /// <seealso cref="Engine"/>
        public Engine Engine { get; set; }

        /// <summary>
        /// Id of hull model.
        /// </summary>
        public int? HullModelId { get; set; }
    }
}
