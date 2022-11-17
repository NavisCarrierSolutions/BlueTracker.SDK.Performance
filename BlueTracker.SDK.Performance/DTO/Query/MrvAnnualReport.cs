using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class MrvAnnualReport : MrvAnnualBase
    {
        /// <summary>
        /// Plausibility result.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PlausibilityResultOptions? Plausibility { get; set; }

        /// <summary>
        /// MRV voyages
        /// </summary>
        public List<MrvVoyage> Voyages { get; set; }

        /// <summary>
        /// MRV port stays
        /// </summary>
        public List<MrvPortStay> PortStays { get; set; }
    }
}
