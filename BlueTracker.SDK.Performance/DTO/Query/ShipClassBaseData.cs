using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Base data for ship class level.
    /// </summary>
    public class ShipClassBaseData
    {
        /// <summary>
        /// ID of ship class base data definition.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Timestamp when the definition was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        public ShipClassShort ShipClass { get; set; }

        /// <summary>
        /// Hull model info.
        /// </summary>
        public ShipHullModelShort HullModel { get; set; }

        /// <summary>
        /// Base data details (actual base data).
        /// </summary>
        public Model.Basic.Ship.Ship Details { get; set; }
    }
}