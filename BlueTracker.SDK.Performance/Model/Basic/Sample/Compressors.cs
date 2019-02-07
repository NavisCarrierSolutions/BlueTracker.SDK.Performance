using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Compressors
    {
        /// <summary>
        ///    Starting air compressors
        /// </summary>
        [JsonProperty("startingAir")]
        public List<Compressor> StartingAir { get; set; }

        /// <summary>
        ///    Service air compressors
        /// </summary>
        [JsonProperty("serviceAir")]
        public List<Compressor> ServiceAir { get; set; }

        /// <summary>
        ///    Emergency air compressors
        /// </summary>
        [JsonProperty("emergencyAir")]
        public List<Compressor> EmergencyAir { get; set; }
    }
}
