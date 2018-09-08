namespace BlueTracker.SDK.Performance.Core
{
    /// <summary>
    /// Sfoc curve point
    /// </summary>
    public class SfocCurvePoint
    {
        /// <summary>
        /// X-Axis value ME load
        /// </summary>
        public double Load { get; set; }

        /// <summary>
        /// Y-Axis value specific fuel oil consumption limit
        /// </summary>
        public double Sfoc { get; set; }
    }
}
