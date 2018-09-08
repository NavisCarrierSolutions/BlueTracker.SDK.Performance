using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Query
{
    public class OnboardSampleSource
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public OnboardSampleSourceType SourceType { get; set; }
    }
}
