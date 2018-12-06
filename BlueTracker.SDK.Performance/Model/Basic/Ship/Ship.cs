using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Ship
{
    /// <summary>
    /// A ship class.
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// Service speed of vessel (design speed). (knots)
        /// </summary>
        public double? ServiceSpeed { get; set; }

        /// <summary>
        /// Estimated Index Value (EIV) according IMO Resolution MEPC.215 (63) (grams CO2/tonne-mile)
        /// </summary>
        public double? EstimatedIndexValue { get; set; }

        /// <summary>
        /// Energy Efficiency Design Index (EEDI) according MARPOL Annex VI, Chapter 4, Reg. 19 (grams CO2/tonne-mile)
        /// </summary>
        public double? EnergyEfficiencyDesignIndex { get; set; }

        /// <summary>
        /// Ship type. (enumeration)
        /// </summary>
        /// <seealso cref="ShipType"/>
        [JsonConverter(typeof(StringEnumConverter))]
        public ShipType? ShipType { get; set; }

        /// <summary>
        /// Ice class. (enumeration)
        /// </summary>
        /// <seealso cref="IceClass"/>
        [JsonConverter(typeof(StringEnumConverter))]
        public IceClass? IceClass { get; set; }

        /// <summary>
        /// Hull type. (enumeration)
        /// </summary>
        /// <seealso cref="Hull"/>
        public Hull Hull { get; set; }

        /// <summary>
        /// Cargo related information.
        /// </summary>
        /// <seealso cref="Cargo"/>
        public Cargo Cargo { get; set; }

        /// <summary>
        /// Engine related information.
        /// </summary>
        /// <seealso cref="Engine"/>
        public Engine Engine { get; set; }

        /// <summary>
        /// Id of hull model.
        /// </summary>
        public int? HullModelId { get; set; }

        /// <summary>
        /// Id of consumption curve
        /// </summary>
        public int? ConsumptionCurveId { get; set; }

        /// <summary>
        /// Id of main engine SFOC curve.
        /// </summary>
        public int? SfocCurveId { get; set; }

        /// <summary>
        /// Id of average SFOC curves of auxiliary engines (AE).
        /// </summary>
        public int? AeSfocCurveId { get; set; }
    }
}
