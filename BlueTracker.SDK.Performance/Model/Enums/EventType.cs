using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Enums
{
    /// <summary>
    /// Types of navigational events.
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// Unspecific event
        /// </summary>
        [JsonProperty(PropertyName = "undefined")]
        Undefined,

        /// <summary>
        /// Departure from port.
        /// </summary>
        [JsonProperty(PropertyName = "departure")]
        Departure,

        /// <summary>
        /// Arrival in port.
        /// </summary>
        [JsonProperty(PropertyName = "arrival")]
        Arrival,

        /// <summary>
        /// Begin of sea passage.
        /// </summary>
        [JsonProperty(PropertyName = "beginOfSeaPassage")]
        BeginOfSeaPassage,

        /// <summary>
        /// End of sea passage.
        /// </summary>
        [JsonProperty(PropertyName = "endOfSeaPassage")]
        EndOfSeaPassage,

        /// <summary>
        /// Drop anchor (start of anchor period).
        /// </summary>
        [JsonProperty(PropertyName = "dropAnchor")]
        DropAnchor,

        /// <summary>
        /// Away anchor (end of anchor period).
        /// </summary>
        [JsonProperty(PropertyName = "awayAnchor")]
        AwayAnchor,

        /// <summary>
        /// Start of drifting period.
        /// </summary>
        [JsonProperty(PropertyName = "startDrifting")]
        StartDrifting,

        /// <summary>
        /// End of drifting period.
        /// </summary>
        [JsonProperty(PropertyName = "endDrifting")]
        EndDrifting,

        /// <summary>
        /// Pilot boarded.
        /// </summary>
        [JsonProperty(PropertyName = "pilotBoarded")]
        PilotBoarded,

        /// <summary>
        /// Pilot disembarked.
        /// </summary>
        [JsonProperty(PropertyName = "pilotOff")]
        PilotOff,

        /// <summary>
        /// Ships noon event.
        /// </summary>
        [JsonProperty(PropertyName = "noon")]
        Noon
    }
}