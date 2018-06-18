using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;

namespace BlueTracker.SDK.Performance.Ship
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
    }
}