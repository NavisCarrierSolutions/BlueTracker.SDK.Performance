using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class LubOilPumps
    {
        /// <summary>
        ///     circulation pumps
        /// </summary>
        [JsonProperty("circulationLubOilPumps")]
        public List<Pump> CirculationLubOilPumps { get; set; }

        /// <summary>
        ///     Cylinder lub oil pumps
        /// </summary>
        [JsonProperty("cylinderLubOilPumps")]
        public List<Pump> CylinderLubOilPumps { get; set; }
    }
}