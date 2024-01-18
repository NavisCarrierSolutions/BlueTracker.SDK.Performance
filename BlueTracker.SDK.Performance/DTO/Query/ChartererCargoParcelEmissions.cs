using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class ChartererCargoParcelEmissions
    {
        /// <summary>
        /// Id of cargo parcel.
        /// </summary>
        public Guid CargoParcelId { get; set; }

        /// <summary>
        /// Custom Id of cargo parcel.
        /// </summary>
        public string CargoCustomId { get; set; }

        /// <summary>
        /// Name of cargo.
        /// </summary>
        public string CargoName { get; set; }

        /// <summary>
        /// Custom Id of charterer.
        /// </summary>
        public string ChartererCustomId { get; set; }

        /// <summary>
        /// Name of charterer.
        /// </summary>
        public string ChartererName { get; set; }

        /// <summary>
        /// Port of loading UNLOC.
        /// </summary>
        public string Pol { get; set; }

        /// <summary>
        /// Port of discharge UNLOC.
        /// </summary>
        public string Pod { get; set; }

        /// <summary>
        /// UTC timestamp of departure.
        /// </summary>
        public DateTimeOffset? DepartureTimestampUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC departure time.
        /// </summary>
        public double DepartureTimestampLocalOffset { get; set; }

        /// <summary>
        /// UTC timestamp of arrival.
        /// </summary>
        public DateTimeOffset? ArrivalTimestampUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC arrival time.
        /// </summary>
        public double ArrivalTimestampLocalOffset { get; set; }

        /// <summary>
        /// Parcel weight in metric tons.
        /// </summary>
        public double? ParcelWeight { get; set; }

        /// <summary>
        /// Total CO2 consumed by parcel in port.
        /// </summary>
        public double? TotalCo2InPort { get; set; }

        /// <summary>
        /// Total CO2 consumed by parcel during laden legs.
        /// </summary>
        public double? TotalCo2Laden { get; set; }

        /// <summary>
        /// Total CO2 consumed by parcel.
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total distance sailed over ground by cargo parcel. 
        /// </summary>
        public double? DistanceOverGround { get; set; }

        /// <summary>
        /// Total transport work associated with the cargo parcel.
        /// </summary>
        public double? TotalTransportWork { get; set; }

        /// <summary>
        /// COA id.
        /// </summary>
        public string ContractOfAffreightmentCustomId { get; set; }
    }
}
