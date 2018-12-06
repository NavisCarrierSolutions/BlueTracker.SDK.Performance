using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Pumps
    /// </summary>
    public class Pumps
    {
        /// <summary>
        /// Sea water pumps
        /// </summary>
        public List<Pump> SeaWaterPumps { get; set; }

        /// <summary>
        /// Fresh water pumps
        /// </summary>
        public List<Pump> FreshWaterPumps { get; set; }

        /// <summary>
        /// Fuel pumps
        /// </summary>
        public List<Pump> FuelPumps { get; set; }
    }
}