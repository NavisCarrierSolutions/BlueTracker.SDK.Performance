using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueTracker.SDK.Performance.Model.Common;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// The scoc curve
    /// </summary>
    public class ScocCurveData
    {
        /// <summary>
        /// The name of scoc curve
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The description of scoc curve
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The definition of scoc curve
        /// </summary>
        [JsonProperty("definition")]
        public ScocCurveDefinition Definition { get; set; }

        /// <summary>
        /// Reason of change
        /// </summary>
        [JsonProperty("changeReason")]
        public string ChangeReason { get; set; }
    }
}
