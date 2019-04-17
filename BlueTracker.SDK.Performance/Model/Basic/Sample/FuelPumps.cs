using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class FuelPumps
    {
        /// <summary>
        ///     Mgo transfer pumps
        /// </summary>
        [JsonProperty("mgoTransferPumps")]
        public List<Pump> MgoTransferPumps { get; set; }

        /// <summary>
        ///     Hfo transfer pumps
        /// </summary>
        [JsonProperty("hfoTransferPumps")]
        public List<Pump> HfoTransferPumps { get; set; }

        /// <summary>
        ///     Sludge pumps
        /// </summary>
        [JsonProperty("sludgePumps")]
        public List<Pump> SludgePumps { get; set; }
    }
}