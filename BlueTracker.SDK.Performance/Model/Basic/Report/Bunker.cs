using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class Bunker
    {
        /// <summary>
        /// List of fuel oil quantities bunkered.
        /// </summary>
        [JsonProperty(PropertyName = "fuelOil")]
        public List<BunkerFuel> FuelOil { get; set; }

        /// <summary>
        /// List of lub oil quantities bunkered.
        /// </summary>
        [JsonProperty(PropertyName = "lubOil")]
        public List<BunkerLubOil> LubOil { get; set; }

        /// <summary>
        /// List of fresh water bunkered.
        /// </summary>
        [JsonProperty(PropertyName = "freshWater")]
        public List<BunkerFreshWater> FreshWater { get; set; }
    }
}
