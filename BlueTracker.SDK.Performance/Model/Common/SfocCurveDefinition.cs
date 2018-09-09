namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Definition of sfoc curve
    /// </summary>
    public class SfocCurveDefinition
    {
        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Points of load vs sfoc curve.
        /// </summary>
        public SfocCurvePoint[] CurvePoints { get; set; }
    }
}
