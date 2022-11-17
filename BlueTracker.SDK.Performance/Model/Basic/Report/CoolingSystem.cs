using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents a cooling system
    /// </summary>
    public class CoolingSystem : EnergyConsumer
    {
        /// <summary>
        /// Name of the cooling system.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
