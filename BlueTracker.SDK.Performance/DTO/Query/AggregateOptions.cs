using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public enum AggregateOptions
    {
        [JsonProperty(PropertyName = "mainEngine")]
        MainEngine,

        [JsonProperty(PropertyName = "auxEngine")]
        AuxEngine,

        [JsonProperty(PropertyName = "boiler")]
        Boiler,

        [JsonProperty(PropertyName = "inertGasGenerator")]
        InertGasGenerator,

        [JsonProperty(PropertyName = "incinerator")]
        Incinerator,
    }
}