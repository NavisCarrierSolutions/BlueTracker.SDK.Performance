using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Query
{
    public class OnboardSampleValueResult
    {
        public int InsertCount { get; set; }
        public long? ElapsedMillisecondsStoringOnboardSampleValue { get; set; }
        public long? ElapsedMillisecondsStoringNavSample { get; set; }
    }
}
