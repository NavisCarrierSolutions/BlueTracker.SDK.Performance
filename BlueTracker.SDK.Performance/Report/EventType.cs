using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Report
{
    // WARNING! Do not change the number assignment, because it is used in the DB.

    public enum EventType
    {
        [JsonProperty(PropertyName = "undefined")]
        Undefined = 0,

        [JsonProperty(PropertyName = "departure")]
        Departure = 1,

        [JsonProperty(PropertyName = "arrival")]
        Arrival = 2,

        [JsonProperty(PropertyName = "beginOfSeaPassage")]
        BeginOfSeaPassage = 3,

        [JsonProperty(PropertyName = "endOfSeaPassage")]
        EndOfSeaPassage = 4,

        [JsonProperty(PropertyName = "dropAnchor")]
        DropAnchor = 5,

        [JsonProperty(PropertyName = "awayAnchor")]
        AwayAnchor = 6,

        [JsonProperty(PropertyName = "startDrifting")]
        StartDrifting = 7,

        [JsonProperty(PropertyName = "endDrifting")]
        EndDrifting = 8,

        [JsonProperty(PropertyName = "pilotBoarded")]
        PilotBoarded = 9,

        [JsonProperty(PropertyName = "pilotOff")]
        PilotOff = 10,

        [JsonProperty(PropertyName = "noon")]
        Noon = 11
    }
}