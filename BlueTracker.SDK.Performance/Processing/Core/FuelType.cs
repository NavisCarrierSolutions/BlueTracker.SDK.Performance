using BlueTracker.SDK.Performance.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Processing.Core
{
    public class FuelType
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelGradeOptions? Grade { get; set; }

        public double? Density { get; set; }

        public double? LCV { get; set; }

        public double? Sulphur { get; set; }

        public double? Co2Factor { get; set; }
    }
}