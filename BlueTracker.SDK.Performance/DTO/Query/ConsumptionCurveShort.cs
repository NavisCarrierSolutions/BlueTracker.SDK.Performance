using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A charter curve.
    /// </summary>
    public class ConsumptionCurveShort
    {
        /// <summary>
        /// ID of consumption curve.
        /// </summary>
        public int Id { get; set; }

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
        public ConsumptionCurveType Type { get; set; }
    }
}
