namespace BlueTracker.SDK.Performance.Ship
{
    /// <summary>
    /// Auxilliary engine definition.
    /// </summary>
    public class AuxEngine : InternalCombustionEngine
    {
        /// <summary>
        /// Maximum continuous power of engine (at 100% load). (kW)
        /// </summary>
        public double? MaxPower { get; set; }

        /// <summary>
        /// Generator definition.
        /// </summary>
        public Generator Generator { get; set; }
    }
}