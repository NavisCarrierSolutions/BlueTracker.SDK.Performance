﻿using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// Main Engine of the vessel used for propulsion, which may be fitted with a shaft generator.
    /// </summary>
    public class MainEngine: InternalCombustionEngine
    {
        /// <summary>
        /// Power of generator (Unit: kW)
        /// </summary>
        [JsonProperty(PropertyName = "generatorPower")]
        public double? GeneratorPower { get; set; }

        /// <summary>
        /// Indication if generator is running.
        /// </summary>
        [JsonProperty(PropertyName = "generatorRunning")]
        public bool? GeneratorRunning { get; set; }

        /// <summary>
        /// Power produced by engine. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }

        /// <summary>
        /// Propeller pitch. (meters)
        /// </summary>
        [JsonProperty(PropertyName = "propellerPitch")]
        public double? PropellerPitch { get; set; }

        /// <summary>
        /// Power on propeller shaft. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "shaftPower")]
        public double? ShaftPower { get; set; }

        /// <summary>
        /// RPMs of shaft (Unit 1/min)
        /// </summary>
        [JsonProperty(PropertyName = "shaftRpm")]
        public double? ShaftRpm { get; set; }

        /// <summary>
        /// Cylinder Pressure Measurement Interface
        /// </summary>
        [JsonProperty(PropertyName = "pmi")]
        public PmiEngine Pmi { get; set; }
    }
}
