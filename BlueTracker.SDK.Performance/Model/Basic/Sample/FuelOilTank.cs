using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Tank for fuel oil
    /// </summary>
    public class FuelOilTank : Tank
    {
        /// <summary>
        /// Kind of fuel
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelKindOptions FuelType { get; set; }
    }
}
