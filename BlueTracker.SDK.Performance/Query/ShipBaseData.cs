using System;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Ship base data definition.
    /// </summary>
    public class ShipBaseData
    {
        /// <summary>
        /// ID of ship base data definition.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Version Stamp when the definition was created or changed.
        /// </summary>
        public long VersionStamp { get; set; }

        /// <summary>
        /// Ship info.
        /// </summary>
        public ShipShort Ship { get; set; }

        /// <summary>
        /// Timestamp when the definition was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Date and time from which definition is effective.
        /// </summary>
        public DateTime EffectiveFrom { get; set; }

        /// <summary>
        /// Hull model info.
        /// </summary>
        public virtual ShipHullModelShort HullModel { get; set; }

        /// <summary>
        /// Base data details (actual base data).
        /// </summary>
        public Performance.Ship.Ship Details { get; set; }
    }
}