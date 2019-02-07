using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     Pumps
    /// </summary>
    public class Pumps
    {
        /// <summary>
        ///     Sea water pumps
        /// </summary>
        [JsonProperty("seaWaterPumps")]
        public SeaWaterPumps SeaWaterPumps { get; set; }

        /// <summary>
        ///     Fresh water pumps
        /// </summary>
        [JsonProperty("freshWaterPumps")]
        public FreshWaterPumps FreshWaterPumps { get; set; }

        /// <summary>
        ///     Fuel pumps
        /// </summary>
        [JsonProperty("fuelPumps")]
        public FuelPumps FuelPumps { get; set; }

        /// <summary>
        ///     Lub oil pumps
        /// </summary>
        [JsonProperty("lubOilPumps")]
        public LubOilPumps LubOilPumps { get; set; }

        /// <summary>
        ///     Oily water pumps
        /// </summary>
        [JsonProperty("oilyWaterPumps")]
        public List<OilyWaterPump> OilyWaterPumps { get; set; }
    }
}