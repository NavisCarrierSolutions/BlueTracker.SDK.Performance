using System;

namespace BlueTracker.SDK.Performance.Query
{
    public class ShipBaseDataShort
    {
        /// <summary>
        /// ID of ship base data definition.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship.
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// Timestamp when the definition was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Date and time from which definition is effective.
        /// </summary>
        public DateTime EffectiveFrom { get; set; }
    }
}