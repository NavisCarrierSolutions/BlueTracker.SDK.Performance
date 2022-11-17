using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class MrvVoyage
    {
        public int Id { get; set; }

        public int ShipId { get; set; }

        public string OriginPort { get; set; }

        public string OriginPortName { get; set; }

        public string DestinationPort { get; set; }

        public string DestinationPortName { get; set; }

        public bool IsOriginMrvState { get; set; }

        public bool IsDestinationMrvState { get; set; }

        public bool IsOriginMrvUkState { get; set; }

        public bool IsDestinationMrvUkState { get; set; }

        public DateTimeOffset DepartureTimeUtc { get; set; }

        public DateTimeOffset DepartureTimeLocal { get; set; }

        public DateTimeOffset? ArrivalTimeUtc { get; set; }

        public DateTimeOffset? ArrivalTimeLocal { get; set; }

        public bool IsEmptyVoyage { get; set; }

        public double? CargoWeight { get; set; }

        public double? CargoVolume { get; set; }

        public double? CargoPax { get; set; }

        public double? TotalDistance { get; set; }

        public double? TotalTimeAtSea { get; set; }

        public double? TotalTimeAtAnchor { get; set; }

        public double? Co2EmissionTotal { get; set; }

        public double? Co2EmissionAtSea { get; set; }

        public double? Co2EmissionInEeaPort { get; set; }

        public double? TransportWorkWeight { get; set; }

        public double? TransportWorkVolume { get; set; }

        public double? TransportWorkPax { get; set; }

        public double? TransportWorkDeadweight { get; set; }

        public double? EnergyEfficiencyDistance { get; set; }

        public double? EnergyEfficiencyTransportWork { get; set; }

        public double? Co2EmissionsDistance { get; set; }

        public double? Co2EmissionsTransportWork { get; set; }

        public double? FuelConsumptionPerDistance { get; set; }

        public double? FuelConsPerTransportWorkWeight { get; set; }

        public double? FuelConsPerTransportWorkVolume { get; set; }

        public double? FuelConsPerTransportWorkPax { get; set; }

        public int? Plausibility { get; set; }

        public string MrvPlausibility { get; set; }

        public double? TotalFuelConsumedHfo { get; set; }

        public double? TotalFuelConsumedLfo { get; set; }

        public double? TotalFuelConsumedMdo { get; set; }

        public double? TotalFuelConsumedMgo { get; set; }

        public double? TotalFuelConsumedPropane { get; set; }

        public double? TotalFuelConsumedButane { get; set; }

        public double? TotalFuelConsumedLng { get; set; }

        public double? TotalFuelConsumedMethanol { get; set; }

        public double? TotalFuelConsumedEthanol { get; set; }

        public double? TotalFuelConsumedUndef { get; set; }

        public double? TotalFuelConsumed { get; set; }

        public double? TotalCo2Hfo { get; set; }

        public double? TotalCo2Lfo { get; set; }

        public double? TotalCo2Mdo { get; set; }

        public double? TotalCo2Mgo { get; set; }

        public double? TotalCo2Propane { get; set; }

        public double? TotalCo2Butane { get; set; }

        public double? TotalCo2Lng { get; set; }

        public double? TotalCo2Methanol { get; set; }

        public double? TotalCo2Ethanol { get; set; }

        public double? TotalCo2Undef { get; set; }

        public double? TotalCo2Emission { get; set; }

        public double? PeriodGap { get; set; }

        public double? PeriodOverlap { get; set; }
    }
}
