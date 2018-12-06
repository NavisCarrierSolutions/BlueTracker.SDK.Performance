using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Represents deck equipment
    /// </summary>
    public class DeckEquipment
    {
        /// <summary>
        /// List of cargohold fans
        /// </summary>
        public List<Fan> CargoHoldFans { get; set; }

        /// <summary>
        /// List of passageway fans
        /// </summary>
        public List<Fan> PassageWayFans { get; set; }

        /// <summary>
        /// List of winches
        /// </summary>
        public List<Winch> Winches { get; set; }

        /// <summary>
        /// List of thrusters
        /// </summary>
        public List<Thruster> Thrusters { get; set; }
    }
}
