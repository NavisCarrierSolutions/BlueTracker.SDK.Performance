using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    /// <summary>
    /// Represents a generic aggregate.
    /// </summary>
    public class Aggregate
    {
        /// <summary>
        /// Number (or position) of aggregate within aggregate group (e.g. auxilliary engine).
        /// </summary>
        /// <remarks>
        /// To denote the auxilliary engine number 2 on the vessel, the value 2 should be used here.
        /// </remarks>
        [JsonProperty(PropertyName = "no")]
        public int No { get; set; }

        /// <summary>
        /// Running hours of aggregate within the reporting period.
        /// </summary>
        /// <remarks>
        /// The value used here should be equal or smaller than the value of <see cref="PerformanceReport.Period"/>.
        /// </remarks>
        [JsonProperty(PropertyName = "runningHours")]
        public double? RunningHours { get; set; }
    }
}