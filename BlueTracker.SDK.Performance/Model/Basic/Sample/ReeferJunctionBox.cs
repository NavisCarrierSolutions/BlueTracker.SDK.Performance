namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    public class ReeferJunctionBox : EnergyConsumer
    {
        /// <summary>
        ///     Winding Temperature T
        /// </summary>
        public double? WindingTemperatureT { get; set; }
        /// <summary>
        ///     Winding Temperature R
        /// </summary>
        public double? WindingTemperatureR { get; set; }
        /// <summary>
        ///     Winding Temperature S
        /// </summary>
        public double? WindingTemperatureS { get; set; }
    }
}