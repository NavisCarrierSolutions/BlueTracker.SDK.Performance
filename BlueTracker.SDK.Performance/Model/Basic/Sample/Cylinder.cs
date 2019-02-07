using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class Cylinder
    {
        /// <summary>
        ///     Cylinder number
        /// </summary>
        [JsonProperty(PropertyName = "no")]
        public int No { get; set; }

        /// <summary>
        ///     Jacket cooling water outlet temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "jacketCoolingWaterOutletTemp")]
        public double? JacketCoolingWaterOutletTemp { get; set; }

        /// <summary>
        ///     Exhaust gas temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "exhaustGasTemp")]
        public double? ExhaustGasTemp { get; set; }

        /// <summary>
        ///     The deviation of the cylinder exhaust gas temperature from the exhaust gas temperature average over all cylinders
        ///     (°C)
        /// </summary>
        [JsonProperty(PropertyName = "exhaustGasTempDeviation")]
        public double? ExhaustGasTempDeviation { get; set; }

        /// <summary>
        ///     Piston cooling oil outlet temperature (°C)
        /// </summary>
        [JsonProperty(PropertyName = "pistonCoolingOilOutletTemp")]
        public double? PistonCoolingOilOutletTemp { get; set; }

        /// <summary>
        ///     Cylinder pressure measurement interface
        /// </summary>
        [JsonProperty(PropertyName = "pmi")]
        public PmiCylinderData Pmi { get; set; }

        /// <summary>
        ///     Cylinder lub oil flow
        /// </summary>
        public CylLubOilFlow CylLubOilFlow { get; set; }
    }
}