using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{

    /// <summary>
    /// Cylinder lub oil flow
    /// </summary>
    public class CylLubOilFlow
    {
        /// <summary>
        /// Volume flow of the consumed fuel. (l/h)
        /// </summary>
        [JsonProperty(PropertyName = "volumeFlow")]
        public double? VolumeFlow { get; set; }

        /// <summary>
        /// Nominal feed rate (l/h)
        /// </summary>
        [JsonProperty(PropertyName = "nominalFeedRate")]
        public double? NominalFeedRate { get; set; }

        /// <summary>
        /// Inlet temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "inletTemp")]
        public double? InletTemp { get; set; }
    }
}