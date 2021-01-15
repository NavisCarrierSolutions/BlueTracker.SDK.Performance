using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Source for NavSamples
    /// </summary>
    public class NavSampleSource
    {
        /// <summary>
        /// The Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the NavSampleSource
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of NavSampleSource
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Is NavSampleSource system reserved
        /// </summary>
        public bool SystemReserved { get; set; }

        /// <summary>
        /// Type of NavSampleSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public NavSampleSourceType SourceType { get; set; }

        /// <summary>
        /// Visibility of NavSampleValues
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SampleVisibility Visibility { get; set; }
    }
}
