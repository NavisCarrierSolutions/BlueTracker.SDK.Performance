using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Common;

namespace BlueTracker.SDK.Performance.Model.Basic.Ship
{
    /// <summary>
    /// Internal combustion engine
    /// </summary>
    public abstract class InternalCombustionEngine : FuelConsumer
    {
        /// <summary>
        /// Engine operational reference.
        /// </summary>
        public List<EngineOpsPoint> OperationReference { get; set; }

        /// <summary>
        /// The average NOx value taken from the EIAPP Certificate
        /// if no value is set a fallback of 22 will be taken representing a max value of Tier 1 engines + 30 %
        /// (number between 0.00 and 25.00) (g NOx / kWh)
        /// </summary>
        public double? AverageNOx { get; set; }
    }
}