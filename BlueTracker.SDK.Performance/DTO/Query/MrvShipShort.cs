using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class MrvShipShort
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// IMO number of vessel
        /// </summary>
        public int ImoNumber { get; set; }

        /// <summary>
        /// Name of vessel
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Estimated index value [g-CO2/t-nm]
        /// </summary>
        public double? EstimatedIndexValue { get; set; }

        /// <summary>
        /// Energy  efficiency design index [g-CO2/t-nm]
        /// </summary>
        public double? EnergyEfficiencyDesignIndex { get; set; }

        /// <summary>
        /// Monitoring method of main engines
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MrvMonitoringMethod? MethodMainEngines { get; set; }

        /// <summary>
        /// Monitoring method of auxiliary engines
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MrvMonitoringMethod? MethodAuxEngines { get; set; }

        /// <summary>
        /// Monitoring method of boilers
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MrvMonitoringMethod? MethodBoilers { get; set; }

        /// <summary>
        /// Monitoring method of gas turbines
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MrvMonitoringMethod? MethodGasTurbines { get; set; }

        /// <summary>
        /// Monitoring method of inert gas generators
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MrvMonitoringMethod? MethodInertGasGenerators { get; set; }

        /// <summary>
        /// Uncertainty of main engines
        /// </summary>
        public double? UncertaintyMainEngines { get; set; }

        /// <summary>
        /// Uncertainty of auxiliary engines
        /// </summary>
        public double? UncertaintyAuxEngines { get; set; }

        /// <summary>
        /// Uncertainty of boilers
        /// </summary>
        public double? UncertaintyBoilers { get; set; }

        /// <summary>
        /// Uncertainty of gas turbines
        /// </summary>
        public double? UncertaintyGasTurbines { get; set; }

        /// <summary>
        /// Uncertainty of inert gas generators
        /// </summary>
        public double? UncertaintyInertGasGenerators { get; set; }

        /// <summary>
        /// Indicates whether base data is complete
        /// </summary>
        public bool? BaseDataComplete { get; set; }
    }
}
