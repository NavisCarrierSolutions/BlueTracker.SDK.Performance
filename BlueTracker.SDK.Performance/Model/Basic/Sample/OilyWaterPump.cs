using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class OilyWaterPump : Pump
    {
        /// <summary>
        ///     15ppm alarm (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "15ppmAlarm")]
        public bool? Ppm15Alarm { get; set; }
    }
}