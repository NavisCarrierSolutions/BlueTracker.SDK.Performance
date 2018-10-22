using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Represents a thruster 
    /// </summary>
    public class Thruster : Aggregate
    {
        /// <summary>
        /// The thuster pitch
        /// </summary>
        [JsonProperty("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// Room bilge alarm
        /// </summary>
        [JsonProperty("roomBilgeAlarm")]
        public bool? RoomBilgeAlarm { get; set; }

        /// <summary>
        /// The main load
        /// </summary>
        [JsonProperty("mainLoad")]
        public bool? MainLoad { get; set; }
    }
}
