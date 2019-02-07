using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Purifiers
    {
        /// <summary>
        ///    MainEngine LubOil purifiers
        /// </summary>
        [JsonProperty("meLubOil")]
        public List<Purifier> MeLubOil { get; set; }

        /// <summary>
        ///    MainEngine Mgo purifiers
        /// </summary>
        [JsonProperty("meMgo")]
        public List<Purifier> MeMgo { get; set; }

        /// <summary>
        ///    MainEngine Hfo purifiers
        /// </summary>
        [JsonProperty("meHfo")]
        public List<Purifier> MeHfo { get; set; }

        /// <summary>
        ///    AuxEngine LubOil purifiers
        /// </summary>
        [JsonProperty("aeLubOil")]
        public List<Purifier> AeLubOil { get; set; }

        /// <summary>
        ///    AuxEngine Mgo purifiers
        /// </summary>
        [JsonProperty("aeMgo")]
        public List<Purifier> AeMgo { get; set; }

        /// <summary>
        ///    AuxEngine Hfo purifiers
        /// </summary>
        [JsonProperty("aeHfo")]
        public List<Purifier> AeHfo { get; set; }
    }
}
