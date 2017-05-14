using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// General informations.
    /// </summary>
    public class General
    {
        /// <summary>
        /// Name of captain.
        /// </summary>
        [JsonProperty(PropertyName = "captain")]
        public string Captain { get; set; }

        /// <summary>
        /// Name of chief engineer.
        /// </summary>
        [JsonProperty(PropertyName = "chiefEng")]
        public string ChiefEng { get; set; }
    }
}