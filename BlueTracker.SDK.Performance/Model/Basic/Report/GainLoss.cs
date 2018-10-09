using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class GainLoss
    {
        /// <summary>
        /// List of fuel oil quantities gained or lost.
        /// </summary>
        [JsonProperty(PropertyName = "fuelOil")]
        public List<FuelQuantity> FuelOil { get; set; }

        /// <summary>
        /// List of lub oil quantities gained or lost.
        /// </summary>
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilQuantity> LubOil { get; set; }

        /// <summary>
        /// List of fresh water quantities gained or lost.
        /// </summary>
        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterQuantity> FreshWater { get; set; }
    }
}
