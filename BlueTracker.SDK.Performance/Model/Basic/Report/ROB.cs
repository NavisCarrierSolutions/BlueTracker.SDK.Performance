using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class ROB
    {
        /// <summary>
        /// List of fuel oil quantities remain on board.
        /// </summary>
        [JsonProperty(PropertyName = "fuelOil")]
        public List<FuelQuantity> FuelOil { get; set; }

        /// <summary>
        /// List of luboil quantities remain on board.
        /// </summary>
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilQuantity> LubOil { get; set; }

        /// <summary>
        /// List of fresh water quantities remain on board.
        /// </summary>
        [JsonProperty(PropertyName = "freshWater")]
        public List<FreshWaterQuantity> FreshWater { get; set; }
    }
}