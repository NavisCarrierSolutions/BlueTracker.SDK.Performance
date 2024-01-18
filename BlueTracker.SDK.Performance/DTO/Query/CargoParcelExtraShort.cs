using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Extra short description of a cargo parcel.
    /// </summary>
    public class CargoParcelExtraShort
    {
        /// <summary>
        /// Unique identifier of cargo parcel.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Unique identifier of cargo parcel used by customer.
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Name of cargo.
        /// </summary>
        public string CargoName { get; set; }

        /// <summary>
        /// Contracting partner (charterer) for the cargo parcel (short).
        /// </summary>
        public string CounterPartyName { get; set; }

        /// <summary>
        /// Contracting partner custom ID or custom number
        /// </summary>
        public string CounterPartyCustomId { get; set; }

        /// <summary>
        /// Cargo parcel weight.
        /// </summary>
        public double? Weight { get; set; }
    }
}
