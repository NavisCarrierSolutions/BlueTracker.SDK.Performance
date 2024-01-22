using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class ChartererPortCallEmissions
    {
        /// <summary>
        /// UNLOC of port.
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// UTC timestamp of arrival in port.
        /// </summary>
        public DateTimeOffset? ArrivalTimeUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC arrival time.
        /// </summary>
        public double ArrivalTimeLocalOffset { get; set; }

        /// <summary>
        /// UTC timestamp of departure from port.
        /// </summary>
        public DateTimeOffset? DepartureTimeUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC departure time.
        /// </summary>
        public double DepartureTimeLocalOffset { get; set; }

        /// <summary>
        /// Hours spent in port.
        /// </summary>
        public double? Period { get; set; }

        /// <summary>
        /// Total cargo weight in port.
        /// </summary>
        public double? TotalCargoWeight { get; set; }

        /// <summary>
        /// Total fuel oil consumption in port.
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total CO2 consumed in port.
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total HFO consumption in port.
        /// </summary>
        public double? TotalHfo { get; set; }

        /// <summary>
        /// Total LFO consumption in port.
        /// </summary>
        public double? TotalLfo { get; set; }

        /// <summary>
        /// Total LNG consumption in port.
        /// </summary>
        public double? TotalLng { get; set; }

        /// <summary>
        /// Total MDO consumption in port.
        /// </summary>
        public double? TotalMdo { get; set; }

        /// <summary>
        /// Total MGO consumed in port.
        /// </summary>
        public double? TotalMgo { get; set; }

        /// <summary>
        /// Total weight of cargo associated with charterer carried in port.
        /// </summary>
        public double? ChartererParcelWeight { get; set; }

        /// <summary>
        /// Total fuel oil consumption by charterer in port.
        /// </summary>
        public double? ChartererFoc { get; set; }

        /// <summary>
        /// Total CO2 consumed by charterer in port.
        /// </summary>
        public double? ChartererCo2 { get; set; }

        /// <summary>
        /// Total HFO consumed by charterer in port.
        /// </summary>
        public double? ChartererHfo { get; set; }

        /// <summary>
        /// Total LFO consumed by charterer in port.
        /// </summary>
        public double? ChartererLfo { get; set; }

        /// <summary>
        /// Total LNG consumed by charterer in port.
        /// </summary>
        public double? ChartererLng { get; set; }

        /// <summary>
        /// Total MDO consumed by charterer in port.
        /// </summary>
        public double? ChartererMdo { get; set; }

        /// <summary>
        /// Total MGO consumed by charterer in port.
        /// </summary>
        public double? ChartererMgo { get; set; }

        /// <summary>
        /// Indicates whether the port is time-wise after the ballast leg.
        /// </summary>
        public bool IsAfterBallastLeg { get; set; }

        /// <summary>
        /// Cargo parcels that have contributed to the total cargo weight in this leg.
        /// </summary>
        public List<CargoParcelExtraShort> CargoParcels { get; set; }

    }
}
