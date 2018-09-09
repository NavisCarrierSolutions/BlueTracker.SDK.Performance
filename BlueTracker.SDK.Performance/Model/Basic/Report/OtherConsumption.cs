using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Information about consumptions other than fueloil.
    /// </summary>
    public class OtherConsumption
    {
        /// <summary>
        /// List of luboil volumes consumed.
        /// </summary>
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilConsumption> LubOil { get; set; }

        /// <summary>
        /// List of fresh water quantities consumed.
        /// </summary>
        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterConsumption> FreshWater { get; set; }
    }
}
