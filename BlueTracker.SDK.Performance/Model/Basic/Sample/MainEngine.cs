using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <inheritdoc />
    /// <summary>
    /// Main Engine of the vessel used for propulsion, which may be fitted with a shaft generator.
    /// </summary>
    public class MainEngine: InternalCombustionEngine
    {
        /// <summary>
        /// Power produced by shaft generator. (kW)
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
        ///     Sea mode enabled? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "seaMode")]
        public bool? SeaMode { get; set; }

        /// <summary>
        ///     Engine ind StandBy? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "standBy")]
        public bool? StandBy { get; set; }

        /// <summary>
        ///     Turning gear engaged? (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "turningGearEngaged")]
        public bool? TurningGearEngaged { get; set; }

        /// <summary>
        /// Propeller pitch. (%)
        /// </summary>
        [JsonProperty(PropertyName = "propellerPitch")]
        public double? PropellerPitch { get; set; }

        /// <summary>
        /// Power on propeller shaft. (kW)
        /// </summary>
        [JsonProperty(PropertyName = "shaftPower")]
        public double? ShaftPower { get; set; }

        /// <summary>
        /// RPM of engine.
        /// </summary>
        [JsonProperty(PropertyName = "shaftRpm")]
        public double? ShaftRpm { get; set; }

        /// <summary>
        ///     Torque of shaft. (kN)
        /// </summary>
        [JsonProperty(PropertyName = "shaftTorque")]
        public double? ShaftTorque { get; set; }

        /// <summary>
        ///     Revolutions of shaft (#)
        /// </summary>
        [JsonProperty(PropertyName = "shaftRevolutionCounter")]
        public int? ShaftRevolutionCounter { get; set; }

        /// <summary>
        ///     Energy counter of shaft. (kWh)
        /// </summary>
        [JsonProperty(PropertyName = "shaftEnergyCounter")]
        public double? ShaftEnergyCounter { get; set; }

        /// <summary>
        ///     Temperature of luboil shaft bearing. (C°)
        /// </summary>
        [JsonProperty(PropertyName = "shaftBearingLubOilTemperature")]
        public double? ShaftBearingLubOilTemperature { get; set; }

        /// <summary>
        ///     Temperature of stern tube bearing. (C°)
        /// </summary>
        [JsonProperty(PropertyName = "sternTubeBearingTemperature")]
        public double? SternTubeBearingTemperature { get; set; }

        /// <summary>
        ///     Temperature of thrust bearing (C°)
        /// </summary>
        [JsonProperty(PropertyName = "thrustBearingTemperature")]
        public double? ThrustBearingTemperature { get; set; }

        /// <summary>
        ///     Pressure of control air (bar)
        /// </summary>
        [JsonProperty(PropertyName = "controlAirPressure")]
        public double? ControlAirPressure { get; set; }

        /// <summary>
        /// Auxiliary blowers
        /// </summary>
        public List<AuxiliaryBlower> AuxBlowers { get; set; }

        /// <summary>
        /// Cylinder lub oil flow
        /// </summary>
        public CylLubOilFlow CylLubOilFlow { get; set; }
    }
}