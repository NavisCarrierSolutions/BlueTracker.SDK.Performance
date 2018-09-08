using System;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Ship hull model definition.
    /// </summary>
    public class ShipHullModelShort
    {
        /// <summary>
        /// ID of hull model.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// CustomId of hull model.
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Name of hull model.
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
    }
}