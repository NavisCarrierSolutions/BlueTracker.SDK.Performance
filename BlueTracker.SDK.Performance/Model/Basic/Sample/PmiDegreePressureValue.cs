using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Engine revolution pressure value for degree between -180° to 180° and pressure in pascal
    /// </summary>
    public class PmiDegreePressureValue
    {
        /// <summary>
        /// Degree -180° to 180°
        /// </summary>
        [JsonProperty(PropertyName = "degree")]
        public float Degree { get; set; }

        /// <summary>
        /// Pressure (pascal)
        /// </summary>
        [JsonProperty(PropertyName = "pressure")]
        public float Pressure { get; set; }
    }
}