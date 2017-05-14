namespace BlueTracker.SDK.Performance.Core
{
    /// <summary>
    /// Values describing a point in hull model.
    /// </summary>
    public class HullPoint
    {
        /// <summary>
        /// Speed over ground. [kn]
        /// </summary>
        public double? Speed { get; set; }

        /// <summary>
        /// Mean draft. [m]
        /// </summary>
        public double? Draft { get; set; }

        /// <summary>
        /// Trim of vessel. [m]
        /// </summary>
        public double? Trim { get; set; }

        /// <summary>
        /// Delivered power. [kW]
        /// </summary>
        public double? Power { get; set; }
    }
}