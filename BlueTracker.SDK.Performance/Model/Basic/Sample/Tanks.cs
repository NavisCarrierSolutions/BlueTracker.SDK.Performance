using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Tanks
    {
        /// <summary>
        ///     Water tanks
        /// </summary>
        public List<Tank> Water { get; set; }

        /// <summary>
        ///     Sludge tanks
        /// </summary>
        public List<Tank> Sludge { get; set; }

        /// <summary>
        ///     Lub oil tanks
        /// </summary>
        public List<LubOilTank> LubOilTank { get; set; }

        /// <summary>
        ///     Fuel oil tanks
        /// </summary>
        public List<FuelOilTank> FuelOilTank { get; set; }
    }
}