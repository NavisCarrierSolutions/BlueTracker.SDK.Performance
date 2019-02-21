using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    ///     A generic fuel consuming aggregate.
    /// </summary>
    public class FuelConsumer : Aggregate
    {
        /// <summary>
        ///     FuelFlows
        /// </summary>
        [JsonProperty(PropertyName = "fuelFlows")]
        public List<FuelFlow> FuelFlows { get; set; }

        /// <summary>
        ///     FuelCounters
        /// </summary>
        [JsonProperty(PropertyName = "fuelCounters")]
        public List<FuelCounter> FuelCounters { get; set; }
    }
}