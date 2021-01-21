using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Deviation percentages. 
    /// </summary>
    public class Deviation
    {
        /// <summary>
        /// Minor deviation [%]. Defaults to 5%.
        /// </summary>
        [JsonProperty("minor")]
        public double Minor { get; set; }

        /// <summary>
        /// Major deviation [%]. Defaults to 10%.
        /// </summary>
        [JsonProperty("major")]
        public double Major { get; set; }
    }
}