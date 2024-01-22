using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class ChartererLegEmissions
    {
        /// <summary>
        /// Port of departure UNLOC.
        /// </summary>
        public string PortOfDeparture { get; set; }

        /// <summary>
        /// Name of departure port.
        /// </summary>
        public string PortOfDepartureName { get; set; }

        /// <summary>
        /// Port of arrival UNLOC.
        /// </summary>
        public string PortOfDestination { get; set; }

        /// <summary>
        /// Name of destination port.
        /// </summary>
        public string PortOfDestinationName { get; set; }

        /// <summary>
        /// UTC timestamp of departure time.
        /// </summary>
        public DateTimeOffset DepartureTimeUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC departure time.
        /// </summary>
        public double DepartureTimeLocalOffset { get; set; }

        /// <summary>
        /// UTC timestamp of arrival time.
        /// </summary>
        public DateTimeOffset? ArrivalTimeUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC arrival time.
        /// </summary>
        public double ArrivalTimeLocalOffset { get; set; }

        /// <summary>
        /// Total cargo weight.
        /// </summary>
        public double? CargoWeight { get; set; }

        /// <summary>
        /// Total transport work.
        /// </summary>
        public double? TransportWork { get; set; }

        /// <summary>
        /// Distance sailed over ground in nautical miles.
        /// </summary>
        public double? DistanceOverGround { get; set; }

        /// <summary>
        /// Total fuel oil consumption during leg.
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total CO2 consumed during leg.
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total HFO consumption during leg.
        /// </summary>
        public double? TotalHfo { get; set; }

        /// <summary>
        /// Total LFO consumption during leg.
        /// </summary>
        public double? TotalLfo { get; set; }

        /// <summary>
        /// Total LNG consumption during leg.
        /// </summary>
        public double? TotalLng { get; set; }

        /// <summary>
        /// Total MDO consumption during leg.
        /// </summary>
        public double? TotalMdo { get; set; }

        /// <summary>
        /// Total MGO consumed during leg.
        /// </summary>
        public double? TotalMgo { get; set; }

        /// <summary>
        /// Total weight of all parcels of the charterer transported during this leg.
        /// </summary>
        public double? ChartererParcelWeight { get; set; }

        /// <summary>
        /// Transport work associated with the charterer.
        /// </summary>
        public double? ChartererTransportWork { get; set; }

        /// <summary>
        /// Total fuel oil consumption during the leg by charterer.
        /// </summary>
        public double? ChartererFoc { get; set; }

        /// <summary>
        /// Total CO2 consumed by charterer during leg.
        /// </summary>
        public double? ChartererCo2 { get; set; }

        /// <summary>
        /// Total HFO consumed by charterer during leg.
        /// </summary>
        public double? ChartererHfo { get; set; }

        /// <summary>
        /// Total LFO consumed by charterer during leg.
        /// </summary>
        public double? ChartererLfo { get; set; }

        /// <summary>
        /// Total LNG consumed by charterer during leg.
        /// </summary>
        public double? ChartererLng { get; set; }

        /// <summary>
        /// Total MDO consumed by charterer during leg.
        /// </summary>
        public double? ChartererMdo { get; set; }

        /// <summary>
        /// Total MGO consumed by charterer during leg.
        /// </summary>
        public double? ChartererMgo { get; set; }

        /// <summary>
        /// Cargo parcels that have contributed to the total cargo weight in this leg.
        /// </summary>
        public List<CargoParcelExtraShort> CargoParcels { get; set; }
    }
}
