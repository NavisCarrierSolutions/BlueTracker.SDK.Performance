using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// OnboardSampleSourceValueRange represents a time range for a vessel (identified by ImoNumber) at which onboard sample values are available
    /// </summary>
    public class OnboardSampleSourceValueRange
    {
        /// <summary>
        /// ImoNumber of vessel
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// Oldest onboard sample value at this timestamp
        /// </summary>
        public DateTime MinimumTimeStamp { get; set; }

        /// <summary>
        /// Newest onboard sample value at this timestamp
        /// </summary>
        public DateTime MaximumTimeStamp { get; set; }
    }
}
