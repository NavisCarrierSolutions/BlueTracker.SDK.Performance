using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents the engine area of a vessel.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Air temperature in engine room. (Unit: °C)
        /// </summary>
        [JsonProperty(PropertyName = "engineRoomTemp")]
        public double? EngineRoomTemp { get; set; }

        /// <summary>
        /// Temperature of LT cooling water. (Unit: °C)
        /// </summary>
        [JsonProperty(PropertyName = "coolingWaterTemp")]
        public double? CoolingWaterTemp { get; set; }

        /// <summary>
        /// Indication if main engines are operated with cut-off turbo chargers.
        /// </summary>
        [JsonProperty(PropertyName = "isTcCutout")]
        public bool? IsTcCutout { get; set; }

        /// <summary>
        /// Indication if main engines are operated in slow steaming.
        /// </summary>
        [JsonProperty(PropertyName = "isSlowSteaming")]
        public bool? IsSlowSteaming { get; set; }

        /// <summary>
        /// Indication if main engines are operated in combinator mode.
        /// </summary>
        [JsonProperty(PropertyName = "isCombinatorMode")]
        public bool? IsCombinatorMode { get; set; }

        /// <summary>
        /// A list of Main Engines, which are installed on the vessel.
        /// </summary>
        [JsonProperty(PropertyName = "mainEngines")]
        public List<MainEngine> MainEngines { get; set; }

        /// <summary>
        /// A list of Auxilliary Engines, which are installed on the vessel.
        /// </summary>
        [JsonProperty(PropertyName = "auxEngines")]
        public List<AuxEngine> AuxEngines { get; set; }

        /// <summary>
        /// A list of Auxilliary Boilers, which are installed on the vessel.
        /// </summary>
        [JsonProperty(PropertyName = "boilers")]
        public List<Boiler> Boilers { get; set; }

        /// <summary>
        /// A list of consumptions, which were consumed during reporting period.
        /// </summary>
        /// <remarks>
        /// Consumptions can be added globally (here) or aggregate specific. If the
        /// consumption can be collated to a specific aggregate (e.g. main engine #2), 
        /// it should be added to the consumption list of the specific aggregate. If 
        /// the consumption can only be collated to the aggregate type 
        /// (<see cref="AggregateOptions"/>), the consumption should be added here.
        /// </remarks>
        [JsonProperty(PropertyName = "consumption")]
        public List<AggregateConsumption> Consumptions { get; set; }

        /// <summary>
        /// Other non-fuel-oil consumptions such as luboil or freshwater.
        /// </summary>
        [JsonProperty(PropertyName = "otherConsumptions")]
        public OtherConsumption OtherConsumptions { get; set; }
    }
}