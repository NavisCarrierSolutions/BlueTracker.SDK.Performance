using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Engine related data.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Air temperature in engine room. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "engineRoomTemp")]
        public double? EngineRoomTemp { get; set; }

        /// <summary>
        /// Temperature of LT cooling water. (°C)
        /// </summary>
        [JsonProperty(PropertyName = "coolingWaterTemp")]
        public double? CoolingWaterTemp { get; set; }

        /// <summary>
        /// A list of Main Engines, which are installed on the vessel.
        /// </summary>
        [JsonProperty(PropertyName = "mainEngines")]
        public List<MainEngine> MainEngines { get; set; }

        /// <summary>
        /// A list of Auxiliary Engines, which are installed on the vessel.
        /// </summary>
        [JsonProperty(PropertyName = "auxEngines")]
        public List<AuxEngine> AuxEngines { get; set; }

        /// <summary>
        /// A list of Auxiliary Boilers, which are installed on the vessel.
        /// </summary>
        [JsonProperty(PropertyName = "boilers")]
        public List<Boiler> Boilers { get; set; }

        /// <summary>
        /// A list of measured fuel flows.
        /// </summary>
        /// <remarks>
        /// Fuel flows can be added globally (here) or aggregate specific. If the
        /// flow can be collated to a specific aggregate (e.g. main engine #2), 
        /// it should be added to the fuel flow list of the specific aggregate. If 
        /// the flow can only be collated to the aggregate type 
        /// (<see cref="AggregateOptions"/>), it should be added here.
        /// </remarks>
        [JsonProperty(PropertyName = "fuelFlows")]
        public List<AggregateFuelFlow> FuelFlows { get; set; }

        /// <summary>
        /// A list of Auxiliary Systems
        /// </summary>
        [JsonProperty(PropertyName = "auxiliarySystems")]
        public AuxiliarySystems AuxiliarySystems { get; set; }
    }
}
