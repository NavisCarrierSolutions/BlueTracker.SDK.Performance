using BlueTracker.SDK.Performance.Model.Enums;
using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// IMO DCS annual report for a specific year and ship.
    /// </summary>
    public class DcsReport
    {
        /// <summary>
        /// Id of annual report.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// IMO number of ship.
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// Year of report.
        /// </summary>
        public int Year { get; set; }

        public DateTime StartTimeUtc { set; get; }

        public DateTime StartTimeLocal { get; set; }

        public DateTime EndTimeUtc { get; set; }

        public DateTime EndTimeLocal { get; set; }


        public double? TotalDistanceTraveled { get; set; }

        public double? TotalHoursUnderway { get; set; }


        public double? TotalFuelConsumptionHfo { get; set; }

        public double? TotalFuelConsumptionLfo { get; set; }

        public double? TotalFuelConsumptionMdo { get; set; }

        public double? TotalFuelConsumptionMgo { get; set; }

        public double? TotalFuelConsumptionLng { get; set; }

        public double? TotalFuelConsumptionPropane { get; set; }

        public double? TotalFuelConsumptionButane { get; set; }

        public double? TotalFuelConsumptionMethanol { get; set; }

        public double? TotalFuelConsumptionEthanol { get; set; }

        public double? TotalFuelConsumptionUndef { get; set; }


        public double? TotalBdnFuelConsumptionHfo { get; set; }

        public double? TotalBdnFuelConsumptionLfo { get; set; }

        public double? TotalBdnFuelConsumptionMdo { get; set; }

        public double? TotalBdnFuelConsumptionMgo { get; set; }

        public double? TotalBdnFuelConsumptionLng { get; set; }

        public double? TotalBdnFuelConsumptionPropane { get; set; }

        public double? TotalBdnFuelConsumptionButane { get; set; }

        public double? TotalBdnFuelConsumptionMethanol { get; set; }

        public double? TotalBdnFuelConsumptionEthanol { get; set; }


        public PlausibilityResultOptions? Plausibility { get; set; }

        public int RelevantReportsCount { get; set; }

        public int PlausibilityCountMajor { get; set; }

        public int PlausibilityCountMinor { get; set; }


        public DateTime? InitialRobTimeUtc { get; set; }

        public DateTime? FinalRobTimeUtc { get; set; }

        public bool? InterpolatedInitialRob { get; set; }

        public bool? InterpolatedFinalRob { get; set; }


        public double? InitialRobFuelHfo { get; set; }

        public double? InitialRobFuelLfo { get; set; }

        public double? InitialRobFuelMdo { get; set; }

        public double? InitialRobFuelMgo { get; set; }

        public double? InitialRobFuelLng { get; set; }

        public double? InitialRobFuelPropane { get; set; }

        public double? InitialRobFuelButane { get; set; }

        public double? InitialRobFuelMethanol { get; set; }

        public double? InitialRobFuelEthanol { get; set; }


        public double? FinalRobFuelHfo { get; set; }

        public double? FinalRobFuelLfo { get; set; }

        public double? FinalRobFuelMdo { get; set; }

        public double? FinalRobFuelMgo { get; set; }

        public double? FinalRobFuelLng { get; set; }

        public double? FinalRobFuelPropane { get; set; }

        public double? FinalRobFuelButane { get; set; }

        public double? FinalRobFuelMethanol { get; set; }

        public double? FinalRobFuelEthanol { get; set; }
    }
}
