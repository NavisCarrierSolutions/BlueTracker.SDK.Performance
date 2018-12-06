using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class ElectricalMotor : EnergyConsumer
    {
        /// <summary>
        /// Load of motor (%).
        /// </summary>
        [JsonProperty("load")]
        public double? Load { get; set; }
    }
}