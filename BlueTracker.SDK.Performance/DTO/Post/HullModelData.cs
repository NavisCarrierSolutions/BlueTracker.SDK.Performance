using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// A hull model.
    /// </summary>
    public class HullModelData
    {
        /// <summary>
        /// ID of hull model.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of hull model.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public HullModelType Type { get; set; }

        /// <summary>
        /// Remarks for versioning.
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// List of hull points describing the model.
        /// </summary>
        public List<HullPoint> HullPoints { get; set; }
    }
}