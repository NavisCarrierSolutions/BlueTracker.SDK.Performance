using System;
using BlueTracker.SDK.Performance.Model.Common;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Details of sfoc curve
    /// </summary>
    public class SfocCurveDetails
    {
        /// <summary>
        /// The id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The definition
        /// </summary>
        [JsonProperty("definition")]
        public SfocCurveDefinition Definition { get; set; }

        /// <summary>
        /// The reason for change 
        /// </summary>
        [JsonProperty("changeReason")]
        public string ChangeReason { get; set; }

        /// <summary>
        /// The revision
        /// </summary>
        [JsonProperty("revision")]
        public int Revision { get; set; }

        /// <summary>
        /// Created by
        /// </summary>
        [JsonProperty("createdById")]
        public int? CreatedById { get; set; }

        /// <summary>
        /// Created on
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
    }
}
