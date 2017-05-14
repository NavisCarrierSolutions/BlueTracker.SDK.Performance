namespace BlueTracker.SDK.Performance.Ship
{
    /// <summary>
    /// Propeller definition.
    /// </summary>
    public class Propeller
    {
        /// <summary>
        /// Propeller pitch (max pitch when variable). (m) 
        /// </summary>
        public double? Pitch { get; set; }

        /// <summary>
        /// Is pitch variable?
        /// </summary>
        public bool? IsPitchVariable { get; set; }
    }
}