using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A ship class.
    /// </summary>
    public class ShipClass
    {
        /// <summary>
        /// ID of ship class.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of ship class.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of ship yard.
        /// </summary>
        public string YardName { get; set; }

        /// <summary>
        /// Time stamp of ship class creation.
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
}