using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// A scoc curve.
    /// </summary>
    public class ScocCurveShort
    {
        /// <summary>
        /// ID of scoc curve.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of scoc curve.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Time stamp of creation of scoc curve.
        /// </summary>
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
    }
}
