using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// A generic fuel consuming aggregate.
    /// </summary>
    public class FuelConsumer : Aggregate
    {
        /// <summary>
        /// A list of consumptions, which were consumed during reporting period.
        /// </summary>
        /// <remarks>
        /// A consumer might consume different fuel kinds/types within a reporting period.
        /// For each type/kind a separate <see cref="Consumption"/> should be added here.
        /// </remarks>
        [JsonProperty(PropertyName = "consumption")]
        public List<Consumption> Consumptions { get; set; }
    }
}