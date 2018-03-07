using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Query
{
    public class OnboardSampleSourceValueRange
    {
        public int ImoNumber { get; set; }

        public DateTime MinimumTimeStamp { get; set; }

        public DateTime MaximumTimeStamp { get; set; }
    }
}
