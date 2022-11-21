namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class MrvAnnualBase
    {
        /// <summary>
        /// MRV ship.
        /// </summary>
        public MrvShipShort Ship { get; set; }

        /// <summary>
        /// Total HFO consumed [t] 
        /// </summary>
        public double? TotalFuelConsumedHfo { get; set; }

        /// <summary>
        /// Total LFO consumed [t]
        /// </summary>
        public double? TotalFuelConsumedLfo { get; set; }

        /// <summary>
        /// Total MDO consumd [t]
        /// </summary>
        public double? TotalFuelConsumedMdo { get; set; }

        /// <summary>
        /// Total MGO consumed [t]
        /// </summary>
        public double? TotalFuelConsumedMgo { get; set; }

        /// <summary>
        /// Total propane consumed [t]
        /// </summary>
        public double? TotalFuelConsumedPropane { get; set; }

        /// <summary>
        /// Total butane consumed [t]
        /// </summary>
        public double? TotalFuelConsumedButane { get; set; }

        /// <summary>
        /// Total LNG consumed [t]
        /// </summary>
        public double? TotalFuelConsumedLng { get; set; }

        /// <summary>
        /// Total methanol consumed [t]
        /// </summary>
        public double? TotalFuelConsumedMethanol { get; set; }

        /// <summary>
        /// Total ethanol consumed [t]
        /// </summary>
        public double? TotalFuelConsumedEthanol { get; set; }

        /// <summary>
        /// Total fuel (of unknown kind) consumed [t]
        /// </summary>
        public double? TotalFuelConsumedUndef { get; set; }

        /// <summary>
        /// Total fuel consumed [t]
        /// </summary>
        public double? TotalFuelConsumed { get; set; }

        /// <summary>
        /// Total CO2 HFO emissions [t]
        /// </summary>

        public double? TotalCo2Hfo { get; set; }

        /// <summary>
        /// Total CO2 LFO emissions [t]
        /// </summary>
        public double? TotalCo2Lfo { get; set; }

        /// <summary>
        /// Total CO2 MDO emissions [t]
        /// </summary>
        public double? TotalCo2Mdo { get; set; }

        /// <summary>
        /// Total CO2 MGO emissions [t]
        /// </summary>
        public double? TotalCo2Mgo { get; set; }

        /// <summary>
        /// Total CO2 propane emissions [t]
        /// </summary>
        public double? TotalCo2Propane { get; set; }

        /// <summary>
        /// Total CO2 butane emissions [t]
        /// </summary>
        public double? TotalCo2Butane { get; set; }

        /// <summary>
        /// Total CO2 LNG emissions [t]
        /// </summary>
        public double? TotalCo2Lng { get; set; }

        /// <summary>
        /// Total CO2 methanol emissions [t]
        /// </summary>
        public double? TotalCo2Methanol { get; set; }

        /// <summary>
        /// Total CO2 ethanol emissions [t]
        /// </summary>
        public double? TotalCo2Ethanol { get; set; }

        /// <summary>
        /// Total CO2 emissions of unknown kind [t]
        /// </summary>
        public double? TotalCo2Undef { get; set; }

        /// <summary>
        /// Total CO2 emissions [t]
        /// </summary>
        public double? TotalCo2Emission { get; set; }

        /// <summary>
        /// Total distance sailed [nm]
        /// </summary>
        public double? TotalDistanceSailed { get; set; }

        /// <summary>
        /// Total time at sea [h]
        /// </summary>
        public double? TotalTimeAtSea { get; set; }

        /// <summary>
        /// Total time at anchor [h]
        /// </summary>
        public double? TotalTimeAtAnchor { get; set; }

        /// <summary>
        /// Total CO2 emissions at sea [t]
        /// </summary>
        public double? Co2EmissionAtSea { get; set; }

        /// <summary>
        /// Total CO2 emissions in EEA port [t]
        /// </summary>
        public double? Co2EmissionInEeaPort { get; set; }

        /// <summary>
        /// Total CO2 emissions in UK port [t]
        /// </summary>
        public double? Co2EmissionInUkPort { get; set; }

        /// <summary>
        /// Total CO2 emissions from voyages leaving an EEA port [t]
        /// </summary>
        public double? TotalCo2EmissionFromVoyagesLeavingEea { get; set; }

        /// <summary>
        /// Total CO2 emissions from voyages to an EEA port [t]
        /// </summary>
        public double? TotalCo2EmissionFromVoyagesToEea { get; set; }

        /// <summary>
        /// Total CO2 emissions on EEA voyages [t]
        /// </summary>
        public double? TotalCo2EmissionOnEeaVoyages { get; set; }

        /// <summary>
        /// Total CO2 emissions from voyages leafing an UK port [t]
        /// </summary>
        public double? TotalCo2EmissionFromVoyagesLeavingUk { get; set; }

        /// <summary>
        /// Total CO2 emissions from voyages to an UK port [t]
        /// </summary>
        public double? TotalCo2EmissionFromVoyagesToUk { get; set; }

        /// <summary>
        /// Total CO2 emissions on UK voyages [t]
        /// </summary>
        public double? TotalCo2EmissionOnUkVoyages { get; set; }

        /// <summary>
        /// Tonne-nautical miles [t-nm]
        /// </summary>
        public double? TransportWorkWeight { get; set; }

        /// <summary>
        /// Cubic meter-nautical miles [m3-nm]
        /// </summary>
        public double? TransportWorkVolume { get; set; }

        /// <summary>
        /// Passenger-nautical miles [pax*nm] 
        /// </summary>
        public double? TransportWorkPax { get; set; }

        /// <summary>
        /// Deadweight-nautical miles [t-nm]
        /// </summary>
        public double? TransportWorkDeadweight { get; set; }

        /// <summary>
        /// CO2 per distance [kg/nm]
        /// </summary>
        public double? Co2EmissionsDistance { get; set; }

        /// <summary>
        /// CO2 emissions per transport work [g/t-nm]
        /// </summary>
        public double? Co2EmissionsTransportWorkWeight { get; set; }

        /// <summary>
        /// CO2 emissions per transport work volume [g/m3-nm]
        /// </summary>
        public double? Co2EmissionsTransportWorkVolume { get; set; }

        /// <summary>
        /// CO2 emissions per transport work pax [g/pax-nm]
        /// </summary>
        public double? Co2EmissionsTransportWorkPax { get; set; }

        /// <summary>
        /// Fuel consumption per distance [kg/nm]
        /// </summary>
        public double? FuelConsumptionPerDistance { get; set; }

        /// <summary>
        /// Fuel consumption per transport work [g/t-nm]
        /// </summary>
        public double? FuelConsPerTransportWorkWeight { get; set; }

        /// <summary>
        /// Fuel consumption per transport work volume [g/m3-nm]
        /// </summary>
        public double? FuelConsPerTransportWorkVolume { get; set; }

        /// <summary>
        /// Fuel consumption per transport work pax [g/pax-nm]
        /// </summary>
        public double? FuelConsPerTransportWorkPax { get; set; }
    }
}
