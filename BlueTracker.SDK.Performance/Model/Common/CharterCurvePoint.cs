namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Defines a point on the consumption (charter) curve
    /// </summary>
    public class CharterCurvePoint
    {
        /// <summary>
        /// Speed through water.
        /// </summary>
        public double Stw { get; set; }

        /// <summary>
        /// Daily fuel oil consumption
        /// </summary>
        public double DailyFoc { get; set; }

        /// <summary>
        /// Draft at which this point shall be used.
        /// </summary>
        public double? Draft { get; set; }
    }
}