using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Query
{
    /// <summary>
    /// OnboardSampleValueResult is the return value for POSTing onboard sample values.
    /// </summary>
    public class OnboardSampleValueResult
    {
        /// <summary>
        /// Count of inserted items (into database)
        /// </summary>
        public int InsertCount { get; set; }
        /// <summary>
        /// Elapsed milliseconds storing onboard sample values
        /// </summary>
        public long? ElapsedMillisecondsStoringOnboardSampleValue { get; set; }
        /// <summary>
        /// Elapsed milliseconds storing nav sample values
        /// </summary>
        public long? ElapsedMillisecondsStoringNavSample { get; set; }
    }
}
