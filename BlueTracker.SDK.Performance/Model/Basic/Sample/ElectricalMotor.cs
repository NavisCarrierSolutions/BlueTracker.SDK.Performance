using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class ElectricalMotor : EnergyConsumer
    {
        /// <summary>
        ///     Load of motor (%).
        /// </summary>
        [JsonProperty("load")]
        public double? Load { get; set; }
    }
}