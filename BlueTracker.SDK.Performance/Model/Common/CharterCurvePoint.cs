using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Defines a point on the consumption (charter) curve
    /// </summary>
    public class CharterCurvePoint
    {
        /// <summary>
        /// Speed through water.
        /// </summary>
        [JsonProperty("stw")]
        public double Stw { get; set; }

        /// <summary>
        /// Daily fuel oil consumption
        /// </summary>
        [JsonProperty("dailyFoc")]
        public double DailyFoc { get; set; }

        /// <summary>
        /// Draft at which this point shall be used.
        /// </summary>
        [JsonProperty("draft")]
        public double? Draft { get; set; }
    }
}