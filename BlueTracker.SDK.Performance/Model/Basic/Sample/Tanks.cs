using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Tanks
    {
        /// <summary>
        ///     Water tanks
        /// </summary>
        [JsonProperty("waterTanks")]
        public List<Tank> WaterTanks { get; set; }

        /// <summary>
        ///     Sludge tanks
        /// </summary>
        [JsonProperty("sludgeTanks")]
        public List<Tank> SludgeTanks { get; set; }

        /// <summary>
        ///     Lub oil tanks
        /// </summary>
        [JsonProperty("lubOilTanks")]
        public List<LubOilTank> LubOilTanks { get; set; }

        /// <summary>
        ///     Fuel oil tanks
        /// </summary>
        [JsonProperty("fuelOilTanks")]
        public List<FuelOilTank> FuelOilTanks { get; set; }
    }
}