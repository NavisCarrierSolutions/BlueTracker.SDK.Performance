using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Sample
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
        /// A list of fuel flows on measured at timestamp.
        /// </summary>
        /// <remarks>
        /// Fuel flows can be added globally (here) or aggregate specific. If the
        /// flow can be collated to a specific aggregate (e.g. main engine #2), 
        /// it should be added to the fuel flow list of the specific aggregate. If 
        /// the flow can only be collated to the aggregate type 
        /// (<see cref="AggregateOptions"/>), it should be added here.
        /// </remarks>
        [JsonProperty(PropertyName = "consumption")]
        public List<AggregateFuelFlow> Consumptions { get; set; }
    }
}
