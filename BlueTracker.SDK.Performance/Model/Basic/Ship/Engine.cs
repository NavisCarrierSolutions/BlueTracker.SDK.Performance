using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Ship
{
    /// <summary>
    /// Engine related ship data.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Collection of main engines.
        /// </summary>
        public List<MainEngine> MainEngines { get; set; }

        /// <summary>
        /// Collection of aux engines.
        /// </summary>
        public List<AuxEngine> AuxEngines { get; set; }
    }
}