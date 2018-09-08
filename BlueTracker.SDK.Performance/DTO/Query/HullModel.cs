using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// A hull model.
    /// </summary>
    public class HullModel
    {
        /// <summary>
        /// ID of hull model.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID of hull model.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Time stamp of hull model creation.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Type of hull model.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public HullModelType Type { get; set; }

        /// <summary>
        /// List of hull points describing the model.
        /// </summary>
        public List<HullPoint> Points { get; set; }
    }
}