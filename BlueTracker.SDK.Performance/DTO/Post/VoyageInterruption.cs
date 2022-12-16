using BlueTracker.SDK.Performance.Model.Enums;
using System;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// Voyage interruption
    /// </summary>
    public class VoyageInterruption
    {
        /// <summary>
        /// Custom ID of hull interruption (maximum lenght: 50).
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// 7-digit IMO-number of ship relating to hull interruption.
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// Start date of hull interruption in local time.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End date of hull interruption in local time.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Type of hull interruption.
        /// </summary>
        public VoyageInterruptionType Type { get; set; }

        /// <summary>
        /// Remarks of hull interruption.
        /// </summary>
        public string Remarks { get; set; }
    }
}
