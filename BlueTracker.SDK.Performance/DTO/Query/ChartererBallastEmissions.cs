using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class ChartererBallastEmissions
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
        /// Port of destination UNLOC.
        /// </summary>
        public string PortOfDestination { get; set; }

        /// <summary>
        /// Name of destination port.
        /// </summary>
        public string PortOfDestinationName { get; set; }

        /// <summary>
        /// UTC timestamp of the departure time.
        /// </summary>
        public DateTimeOffset DepartureTimeUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC departure time.
        /// </summary>
        public double DepartureTimeLocalOffset { get; set; }

        /// <summary>
        /// UTC timestamp of the arrival time.
        /// </summary>
        public DateTimeOffset? ArrivalTimeUtc { get; set; }

        /// <summary>
        /// Offset in minutes to UTC arrival time.
        /// </summary>
        public double ArrivalTimeLocalOffset { get; set; }

        /// <summary>
        /// Period of the ballast leg in hours.
        /// </summary>
        public double? Period { get; set; }

        /// <summary>
        /// Distance sailed over ground in nautical miles.
        /// </summary>
        public double? DistanceOverGround { get; set; }

        /// <summary>
        /// Total fuel oil consumption during ballast leg in metric tons.
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        /// Total CO2 consumed during ballast leg in metric tons.
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        /// Total HFO consumption during ballast leg in metric tons.
        /// </summary>
        public double? TotalHfo { get; set; }

        /// <summary>
        /// Total HFO consumption during ballast leg in metric tons.
        /// </summary>
        public double? TotalLfo { get; set; }

        /// <summary>
        /// Total LNG consumption during ballast leg in metric tons.
        /// </summary>
        public double? TotalLng { get; set; }

        /// <summary>
        /// Total MDO consumption during ballast leg in metric tons.
        /// </summary>
        public double? TotalMdo { get; set; }

        /// <summary>
        /// Total MGO consumption during ballast leg in metric tons.
        /// </summary>
        public double? TotalMgo { get; set; }

        /// <summary>
        /// Share of charterer in ballast emissions in metric tons.
        /// </summary>
        public double? BallastEmissionShare { get; set; }

        /// <summary>
        /// Share of charterer in ballast emissions in %.
        /// </summary>
        public double? BallastEmissionSharePercentage { get; set; }

        /// <summary>
        /// Cargo parcels that have contributed to the total cargo weight in this leg.
        /// </summary>
        public List<CargoParcelExtraShort> CargoParcels { get; set; }
    }
}
