using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class Cylinder
    {
        /// <summary>
        /// Cylinder Number
        /// </summary>
        [JsonProperty(PropertyName = "cylinderNumber")]
        public int CylinderNumber { get; set; }
    }
}