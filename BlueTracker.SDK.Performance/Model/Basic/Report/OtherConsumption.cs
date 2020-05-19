using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Information about consumptions other than fuel oil.
    /// </summary>
    public class OtherConsumption
    {
        /// <summary>
        /// List of lub oil volumes consumed.
        /// </summary>
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilAggregateConsumption> LubOil { get; set; }

        /// <summary>
        /// List of fresh water quantities consumed.
        /// </summary>
        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterConsumption> FreshWater { get; set; }
    }
}
