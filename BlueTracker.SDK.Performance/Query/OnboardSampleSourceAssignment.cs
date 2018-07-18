using System;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    ///     Assignment of a vessel to a onboard sample source
    /// </summary>
    public class OnboardSampleSourceAssignment
    {
        /// <summary>
        /// The id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// OnboardSampleSource
        /// </summary>
        public virtual OnboardSampleSource Source { get; set; }

        /// <summary>
        /// OnboardSampleSource Id
        /// </summary>
        public int SourceId { get; set; }

        /// <summary>
        /// The ship
        /// </summary>
        public virtual Ship Ship { get; set; }

        /// <summary>
        /// The shipId
        /// </summary>
        public int ShipId { get; set; }

        /// <summary>
        /// Valid since
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Valid until
        /// </summary>
        public DateTime? ValidUntil { get; set; }
    }
}