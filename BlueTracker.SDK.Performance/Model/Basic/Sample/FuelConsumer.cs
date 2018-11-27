using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// A generic fuel consuming aggregate.
    /// </summary>
    public class FuelConsumer : Aggregate
    {
        /// <summary>
        /// Fuel flow of aggregate.
        /// </summary>
        [JsonProperty(PropertyName = "supplyFuelFlow")]
        public FuelFlow SupplyFuelFlow { get; set; }

        /// <summary>
        /// Fuel flow of aggregate.
        /// </summary>
        [JsonProperty(PropertyName = "returnFuelFlow")]
        public FuelFlow ReturnFuelFlow { get; set; }

        /// <summary>
        /// Used to support old schema, currently named ConsumptionFuelFlow
        /// </summary>
        [JsonProperty(PropertyName = "fuelFlow")]
        private FuelFlow FuelFlow { get; set; }
    }
}