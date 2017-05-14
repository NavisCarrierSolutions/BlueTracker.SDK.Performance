using System;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Ship hull model definition.
    /// </summary>
    public class ShipHullModelShort
    {
        /// <summary>
        /// ID of ship hull model.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Timestamp when the definition was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
}