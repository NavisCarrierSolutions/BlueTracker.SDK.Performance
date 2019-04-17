using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class SeaWaterPumps
    {
        /// <summary>
        ///     Cooling pumps harbor
        /// </summary>
        [JsonProperty("coolingHarborPumps")]
        public List<Pump> CoolingHarborPumps { get; set; }

        /// <summary>
        ///     Cooling pumps sea
        /// </summary>
        [JsonProperty("coolingSeaPumps")]
        public List<Pump> CoolingSeaPumps { get; set; }

        /// <summary>
        ///     Fire pumps
        /// </summary>
        [JsonProperty("firePumps")]
        public List<Pump> FirePumps { get; set; }

        /// <summary>
        ///     Fire emergency pumps
        /// </summary>
        [JsonProperty("fireEmergencyPumps")]
        public List<Pump> FireEmergencyPumps { get; set; }

        /// <summary>
        ///     Ballast pumps
        /// </summary>
        [JsonProperty("ballastPumps")]
        public List<Pump> BallastPumps { get; set; }

        /// <summary>
        ///     Bilge pumps
        /// </summary>
        [JsonProperty("bilgePumps")]
        public List<Pump> BilgePumps { get; set; }
    }
}