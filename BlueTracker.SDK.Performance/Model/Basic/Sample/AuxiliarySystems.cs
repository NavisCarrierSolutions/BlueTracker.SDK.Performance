using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Auxiliary Systems
    /// </summary>
    public class AuxiliarySystems
    {
        /// <summary>
        ///     Pressure of main air reservoir (bar)
        /// </summary>
        [JsonProperty("mainAirReservoirPressure")]
        public double? MainAirReservoirPressure { get; set; }

        /// <summary>
        ///     Pressure of auxiliary air reservoir (bar)
        /// </summary>
        [JsonProperty("auxAirReservoirPressure")]
        public double? AuxAirReservoirPressure { get; set; }

        /// <summary>
        ///     Emergency generator running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "emergencyGeneratorRunningSignal")]
        public bool? EmergencyGeneratorRunningSignal { get; set; }

        /// <summary>
        ///     Jacket cooling water pre heater pump running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "jacketCoolingWaterPreHeaterPumpRunningSignal")]
        public bool? JacketCoolingWaterPreHeaterPumpRunningSignal { get; set; }

        /// <summary>
        ///     Fresh water generator running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "freshWaterGeneratorRunningSignal")]
        public bool? FreshWaterGeneratorRunningSignal { get; set; }

        /// <summary>
        ///     Galley air conditioning running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "galleyAirConditionRunningSignal")]
        public bool? GalleyAirConditionRunningSignal { get; set; }

        /// <summary>
        ///     Work shop air conditioning running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "workShopAirConditionRunningSignal")]
        public bool? WorkShopAirConditionRunningSignal { get; set; }

        /// <summary>
        ///     Cargo hold sprinkler system running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "cargoHoldSprinklerSystemRunningSignal")]
        public bool? CargoHoldSprinklerSystemRunningSignal { get; set; }

        /// <summary>
        ///     Sewage treat unit running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "sewageTreatUnitRunningSignal")]
        public bool? SewageTreatUnitRunningSignal { get; set; }

        /// <summary>
        ///     Shore connection live? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "shoreConnectionLiveSignal")]
        public bool? ShoreConnectionLiveSignal { get; set; }

        /// <summary>
        ///     Oily water separator running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "oilyWaterSeparatorRunningSignal")]
        public bool? OilyWaterSeparatorRunningSignal { get; set; }

        /// <summary>
        ///     Ballast water treatment running? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "ballastWaterTreatmentRunningSignal")]
        public bool? BallastWaterTreatmentRunningSignal { get; set; }

        /// <summary>
        ///     Cooling sea water three-way-valve position (%)
        /// </summary>
        [JsonProperty("coolingSeaWaterThreeWayValvePosition")]
        public double? CoolingSeaWaterThreeWayValvePosition { get; set; }

        /// <summary>
        ///     Sea water cooler system
        /// </summary>
        [JsonProperty("seaWaterCooler")]
        public SeaWaterCooler SeaWaterCooler { get; set; }

        /// <summary>
        ///     Pump information
        /// </summary>
        [JsonProperty("pumps")]
        public Pumps Pumps { get; set; }

        /// <summary>
        ///     Engine Room Fans
        /// </summary>
        [JsonProperty("engineRoomFans")]
        public List<Fan> EngineRoomFans { get; set; }

        /// <summary>
        ///     Purifiers
        /// </summary>
        [JsonProperty("purifiers")]
        public Purifiers Purifiers { get; set; }

        /// <summary>
        ///     Purifiers
        /// </summary>
        [JsonProperty("compressors")]
        public Compressors Compressors { get; set; }

        /// <summary>
        ///     Steering Gears
        /// </summary>
        [JsonProperty("steeringGears")]
        public List<SteeringGear> SteeringGears { get; set; }
    }
}