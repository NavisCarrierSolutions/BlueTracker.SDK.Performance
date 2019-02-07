using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class FreshWaterPumps
    {
        /// <summary>
        ///     Boiler feed pumps
        /// </summary>
        [JsonProperty("boilerFeedPumps")]
        public List<Pump> BoilerFeedPumps { get; set; }

        /// <summary>
        ///     Drinking water pumps
        /// </summary>
        [JsonProperty("drinkingWaterPumps")]
        public List<Pump> DrinkingWaterPumps { get; set; }

        /// <summary>
        ///     Cooling pumps low temperature
        /// </summary>
        [JsonProperty("coolingPumpsLt")]
        public List<Pump> CoolingPumpsLt { get; set; }

        /// <summary>
        ///     Jacket cooling pumps
        /// </summary>
        [JsonProperty("coolingPumpsJacket")]
        public List<Pump> CoolingPumpsJacket { get; set; }
    }
}