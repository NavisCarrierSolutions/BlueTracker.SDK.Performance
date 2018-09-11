namespace BlueTracker.SDK.Performance.Model.Basic.Ship
{
    /// <summary>
    /// Main engine definition.
    /// </summary>
    public class MainEngine : InternalCombustionEngine
    {
        /// <summary>
        /// Maximum RPM. (1/min)
        /// </summary>
        public double? MaxRpm { get; set; }

        /// <summary>
        /// Maximum continuous power (at 100% load). (kW)
        /// </summary>
        public double? MaxPower { get; set; }

        /// <summary>
        /// Generator definition.
        /// </summary>
        public Generator Generator { get; set; }

        /// <summary>
        /// Propeller definition.
        /// </summary>
        public Propeller Propeller { get; set; }
    }
}
