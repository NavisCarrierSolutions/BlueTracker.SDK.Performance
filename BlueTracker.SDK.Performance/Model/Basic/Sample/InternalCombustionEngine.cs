using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// A generic fuel consumer with internal combustion.
    /// </summary>
    public abstract class InternalCombustionEngine : FuelConsumer
    {
        /// <summary>
        /// List of information for cylinders
        /// </summary>
        public List<Cylinder> Cylinders { get; set; }

        /// <summary>
        /// List of information for turbo chargers
        /// </summary>
        public List<TurboCharger> TurboChargers { get; set; }

        /// <summary>
        /// Cylinder pressure measurement interface 
        /// </summary>
        [JsonProperty(PropertyName = "pmi")]
        public PmiAvgData Pmi { get; set; }

        /// <summary>
        ///     Pressure of starting air (bar)
        /// </summary>
        [JsonProperty(PropertyName = "startAirPressure")]
        public double? StartAirPressure { get; set; }

        /// <summary>
        ///     Pressure of scavenging air (bar)
        /// </summary>
        [JsonProperty(PropertyName = "scavengingAirPressure")]
        public double? ScavengingAirPressure { get; set; }

        /// <summary>
        ///     Temperature of scavenging air before air cooler (°C)
        /// </summary>
        [JsonProperty(PropertyName = "scavengingAirTempBeforeAirCooler")]
        public double? ScavengingAirTempBeforeAirCooler { get; set; }

        /// <summary>
        ///     Temperature of scavenging air behind air cooler (°C)
        /// </summary>
        [JsonProperty(PropertyName = "scavengingAirTempBehindAirCooler")]
        public double? ScavengingAirTempBehindAirCooler { get; set; }

        /// <summary>
        ///     Jacket cooling water inlet temperature common (°C)
        /// </summary>
        [JsonProperty(PropertyName = "jacketCoolingWaterInletTemp")]
        public double? JacketCoolingWaterInletTemp { get; set; }

        /// <summary>
        ///     Jacket cooling water pre-heater running signal
        /// </summary>
        [JsonProperty(PropertyName = "jacketCoolingWaterPreHeaterRunningSignal")]
        public bool? JacketCoolingWaterPreHeaterRunningSignal { get; set; }

        /// <summary>
        ///     Cooling water air cooler inlet temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "coolingWaterAirCoolerInletTemp")]
        public double? CoolingWaterAirCoolerInletTemp { get; set; }

        /// <summary>
        ///     Cooling water air cooler outlet temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "coolingWaterAirCoolerOutletTemp")]
        public double? CoolingWaterAirCoolerOutletTemp { get; set; }

        /// <summary>
        ///     Engine ready to start
        /// </summary>
        [JsonProperty(PropertyName = "readyToStart")]
        public bool? ReadyToStart { get; set; }
    }
}