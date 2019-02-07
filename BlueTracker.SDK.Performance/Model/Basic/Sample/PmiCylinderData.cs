using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    ///     PMI information for a cylinder
    /// </summary>
    public class PmiCylinderData : PmiData
    {
        /// <summary>
        ///     List of pressure values (degree, pascal)
        /// </summary>
        [JsonProperty(PropertyName = "pressureValues")]
        public List<PmiDegreePressureValue> PressureValues { get; set; }
    }
}