using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Represents a fan in the sense of air moving device
    /// </summary>
    public abstract class Fan : ElectricalDevice
    {
        /// <summary>
        /// Set to true if fan is blowing air in (supplying air)
        /// </summary>
        [JsonProperty("supplySignal")]
        public bool? SupplySignal { get; set; }

        /// <summary>
        /// Set to true if fan is sucking air to blow out (venting)
        /// </summary>
        [JsonProperty("exhaustSignal")]
        public bool? ExhaustSignal { get; set; }

        /// <summary>
        /// Speed of fan in (RPM)
        /// </summary>
        [JsonProperty("speed")]
        public int? Speed { get; set; }
    }
}
