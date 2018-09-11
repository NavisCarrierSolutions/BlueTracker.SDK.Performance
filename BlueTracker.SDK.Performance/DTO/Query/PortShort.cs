using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Short description of port
    /// </summary>
    public class PortShort
    {
        /// <summary>
        /// Id (given by bluetracker.one)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// UNLOC of Port
        /// </summary>
        [JsonProperty("unloc")]
        public string UNLOC { get; set; }

        /// <summary>
        /// Port Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}