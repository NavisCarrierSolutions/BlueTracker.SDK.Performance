using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     Represents deck equipment
    /// </summary>
    public class DeckEquipment
    {
        /// <summary>
        ///     List of cargohold fans
        /// </summary>
        [JsonProperty("cargoHoldFans")]
        public List<Fan> CargoHoldFans { get; set; }

        /// <summary>
        ///     List of passageway fans
        /// </summary>
        [JsonProperty("passageWayFans")]
        public List<Fan> PassageWayFans { get; set; }

        /// <summary>
        ///     List of winches
        /// </summary>
        [JsonProperty("winches")]
        public List<Winch> Winches { get; set; }

        /// <summary>
        ///     List of thrusters
        /// </summary>
        [JsonProperty("thrusters")]
        public List<Thruster> Thrusters { get; set; }
    }
}