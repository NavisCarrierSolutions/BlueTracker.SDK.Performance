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
        /// Cooling low temperature water pumps
        /// </summary>
        public List<Pump> CoolingPumpLts { get; set; }

        /// <summary>
        /// Cooling jacket water pumps
        /// </summary>
        public List<Pump> CoolingPumpJackets { get; set; }

        /// <summary>
        /// Circulation lube oil pumps
        /// </summary>
        public List<Pump> CircLubOilPumps { get; set; }

        /// <summary>
        /// Cylinder pressure measurement interface 
        /// </summary>
        [JsonProperty(PropertyName = "pmi")]
        public PmiData Pmi { get; set; }
    }
}