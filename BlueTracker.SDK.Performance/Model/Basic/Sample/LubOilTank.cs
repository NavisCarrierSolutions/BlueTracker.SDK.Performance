using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     Tank for lub oil
    /// </summary>
    public class LubOilTank : Tank
    {
        /// <summary>
        ///     Kind of lub oil
        /// </summary>
        [JsonProperty("lubOilKind")]
        public LubOilKindOptions LubOilKind { get; set; }
    }
}