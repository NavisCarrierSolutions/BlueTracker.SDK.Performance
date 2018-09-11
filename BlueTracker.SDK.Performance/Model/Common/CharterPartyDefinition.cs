using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Definition of consumption (charter) party
    /// </summary>
    public class CharterPartyDefinition
    {
        /// <summary>
        /// Major-/Minor- deviation limits.
        /// </summary>
        public Deviation Deviations { get; set; }

        /// <summary>
        /// Sea state limit.
        /// </summary>
        public double? SeaState { get; set; }

        /// <summary>
        /// Wind speed limit.
        /// </summary>
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the maximal wave height in meters.
        /// </summary>
        public double? WaveHeight { get; set; }

        /// <summary>
        /// Issues to be excluded.
        /// </summary>
        public ExcludedIssues ExcludedIssues { get; set; }

        /// <summary>
        /// Points of speed vs consumption curve.
        /// </summary>
        public CharterCurvePoint[] CurvePoints { get; set; }

        /// <summary>
        /// Gets or sets the maximum allowed daily consumption [t/d].
        /// </summary>
        public double? ConsumptionCap { get; set; }

        /// <summary>
        /// Gets or sets the maximum allowed speed [kn].
        /// </summary>
        public double? SpeedCap { get; set; }

        /// <summary>
        /// Gets or sets the minimum required spped [kn].
        /// </summary>
        public double? MinimumSpeed { get; set; }

        /// <summary>
        /// Gets or sets the charter party type.
        /// </summary>
        public CharterPartyType Type { get; set; }
    }
}
