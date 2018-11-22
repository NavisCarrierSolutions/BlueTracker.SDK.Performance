using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public abstract class Cylinder
    {
        /// <summary>
        /// Cylinder number
        /// </summary>
        [JsonProperty(PropertyName = "no")]
        public int No { get; set; }

        /// <summary>
        /// Jacket cooling water outlet temperature
        /// </summary>
        [JsonProperty(PropertyName = "jacketCoolingWaterOutletTemperature")]
        public double? JacketCoolingWaterOutletTemperature { get; set; }

        /// <summary>
        /// Exhaust gas temperature
        /// </summary>
        [JsonProperty(PropertyName = "exhaustGasTemperature")]
        public double? ExhaustGasTemperature { get; set; }

        /// <summary>
        /// The deviation of the cylinder exhaust gas temperature from the exhaust gas temperature average over all cylinders
        /// </summary>
        [JsonProperty(PropertyName = "exhaustGasTemperatureDeviation")]
        public double? ExhaustGasTemperatureDeviation { get; set; }

        /// <summary>
        /// Cylinder pressure measurement interface
        /// </summary>
        [JsonProperty(PropertyName = "pmi")]
        public PmiCylinderData Pmi { get; set; }
    }
}