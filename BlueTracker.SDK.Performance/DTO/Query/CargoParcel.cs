using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Describes a cargo movement from POL to POD.
    /// </summary>
    public class CargoParcel
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
        /// Contracting partner (charterer) for the cargo parcel (full).
        /// </summary>
        public string CounterPartyFullName { get; set; }

        /// <summary>
        /// Contracting partner custom ID or custom number
        /// </summary>
        public string CounterPartyCustomId { get; set; }

        /// <summary>
        /// Contract of affreightment id or custom number
        /// </summary>
        public string ContractOfAffreightmentCustomId { get; set; }

        /// <summary>
        /// Cargo parcel weight.
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// UNLOCODE for port of loading.
        /// </summary>
        public string PolUnloc { get; set; }

        /// <summary>
        /// UTC time of the departure event for the POL (port of loading).
        /// </summary>
        public DateTimeOffset PolTimeStampUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC time of the departure event.
        /// </summary>
        public double PolTimeStampLocalOffset { get; set; }

        /// <summary>
        /// UNLOCODE for the port of discharge.
        /// </summary>
        public string PodUnloc { get; set; }

        /// <summary>
        /// UTC time of the arrival event for the POD (port of discharge).
        /// </summary>
        public DateTimeOffset PodTimeStampUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC time of the arrival event.
        /// </summary>
        public double PodTimeStampLocalOffset { get; set; }

        public int? VoyageId { get; set; }

        /// <summary>
        /// Name of voyage.
        /// </summary>
        public string VoyageName { get; set; }

        /// <summary>
        /// Gets or sets whether the parcel data can be linked to an existing voyage.
        /// </summary>
        public bool HasVoyage { get; set; }

        /// <summary>
        /// Gets or sets whether the parcel data can be linked to an existing leg.
        /// </summary>
        public bool HasLeg { get; set; }
    }
}
