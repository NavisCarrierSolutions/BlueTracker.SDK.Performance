namespace BlueTracker.SDK.Performance.Core
{
    /// <summary>
    /// Operational reference point for engine.
    /// </summary>
    public class EngineOpsPoint
    {
        /// <summary>
        /// Relative engine load. (%)
        /// </summary>
        public double Load { get; set; }

        /// <summary>
        /// Engine speed. (1/min)
        /// </summary>
        public double? Speed { get; set; }

        /// <summary>
        /// Specific fuel oil consumption. (g/kWh)
        /// </summary>
        public double? Sfoc { get; set; }

        /// <summary>
        /// Mean effective pressure. (bar)
        /// </summary>
        public double? Pme { get; set; }

        /// <summary>
        /// Compression pressure. (bar)
        /// </summary>
        public double? Pcomp { get; set; }

        /// <summary>
        /// Maximum pressure. (bar)
        /// </summary>
        public double? Pmax { get; set; }

        /// <summary>
        /// Scavanging air pressure. (bar)
        /// </summary>
        public double? ScavAirPress { get; set; }

        /// <summary>
        /// Exhaust gas temperature. (°C)
        /// </summary>
        public double? ExhaustTemp { get; set; }
    }
}
