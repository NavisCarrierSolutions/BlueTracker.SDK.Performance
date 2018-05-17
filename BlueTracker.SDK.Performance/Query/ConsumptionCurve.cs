using System;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// Represents a consumption curve
    /// </summary>
    public class ConsumptionCurve
    {
        /// <summary>
        /// Id of consumption curve
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of consumption curve
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of consumption curve
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Definition of consumption curve
        /// </summary>
        [JsonProperty("definition")]
        public CharterPartyDefinition Definition { get; set; }
        
        /// <summary>
        /// Reason of change
        /// </summary>
        [JsonProperty("changeReason")]
        public string ChangeReason { get; set; }

        /// <summary>
        /// Ship id created from
        /// </summary>
        [JsonProperty("createdFromShipId")]
        public int? CreatedFromShipId { get; set; }

        /// <summary>
        /// Created from start
        /// </summary>
        [JsonProperty("createdFromDateStart")]
        public DateTime? CreatedFromDateStart { get; set; }

        /// <summary>
        /// Created from end
        /// </summary>
        [JsonProperty("createdFromDateEnd")]
        public DateTime? CreatedFromDateEnd { get; set; }

        /// <summary>
        /// The revision
        /// </summary>
        [JsonProperty("revision")]
        public int Revision { get; set; }

        /// <summary>
        /// Time created
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Type of consumption curve
        /// </summary>
        [JsonProperty("consumptionCurveType")]
        public ConsumptionCurveType ConsumptionCurveType { get; set; }
    }
}
