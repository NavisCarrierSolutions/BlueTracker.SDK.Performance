using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class NavSampleSource
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool SystemReserved { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public NavSampleSourceType SourceType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public SampleVisibility Visibility { get; set; }
    }
}
