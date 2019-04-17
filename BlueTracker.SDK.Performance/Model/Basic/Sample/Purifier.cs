using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Purifier : Aggregate
    {
        /// <summary>
        ///     Temperature (C°).
        /// </summary>
        [JsonProperty("temp")]
        public double? Temperature { get; set; }
    }
}