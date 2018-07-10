using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Report
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
