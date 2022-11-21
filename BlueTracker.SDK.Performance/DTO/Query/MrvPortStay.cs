using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class MrvPortStay
    {
        public int Id { get; set; }

        public DateTimeOffset DepartureTimeUtc { get; set; }

        public DateTimeOffset DepartureTimeLocal { get; set; }

        public DateTimeOffset? ArrivalTimeUtc { get; set; }

        public DateTimeOffset? ArrivalTimeLocal { get; set; }

        public string PortUnloc { get; set; }

        public string PortName { get; set; }

        public double? PortStayPeriod { get; set; }

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

        public double? TotalCo2Mgo { get; set; }

        public double? TotalCo2Mdo { get; set; }

        public double? TotalCo2Propane { get; set; }

        public double? TotalCo2Butane { get; set; }

        public double? TotalCo2Lng { get; set; }

        public double? TotalCo2Methanol { get; set; }

        public double? TotalCo2Ethanol { get; set; }

        public double? TotalCo2Undef { get; set; }

        public double? TotalCo2Emission { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PlausibilityResultOptions? Plausibility { get; set; }

        public double? Period { get; set; }

        public double? PeriodGap { get; set; }

        public double? PeriodOverlap { get; set; }
    }
}
