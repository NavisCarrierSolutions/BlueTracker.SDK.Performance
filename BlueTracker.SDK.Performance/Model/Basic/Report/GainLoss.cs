using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class GainLoss
    {
        /// <summary>
        /// List of fuel oil quantities Gain/Loss.
        /// </summary>
        [JsonProperty(PropertyName = "fuelOil")]
        public List<FuelQuantity> FuelOil { get; set; }

        /// <summary>
        /// List of lub oil quantities Gain/Loss.
        /// </summary>
        [JsonProperty(PropertyName = "lubOil")]
        public List<LubOilQuantity> LubOil { get; set; }
    }
}
