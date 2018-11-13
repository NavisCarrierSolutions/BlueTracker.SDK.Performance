using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a thruster 
    /// </summary>
    public class Thruster : ElectricalMotor
    {
        /// <summary>
        /// The thruster pitch.
        /// </summary>
        [JsonProperty("pitch")]
        public double? Pitch { get; set; }
    }
}