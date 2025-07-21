using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.Model.Basic.Report
{
    public class BunkerFuel
    {
        /// <summary>
        /// Unique ID of bunker charge in reporting system.
        /// </summary>
        [JsonProperty(PropertyName = "bunkerChargeId")]
        public string BunkerChargeId { get; set; }

        /// <summary>
        /// Unique name of bunker charge.
        /// </summary>
        [JsonProperty(PropertyName = "bunkerChargeName")]
        public string BunkerChargeName { get; set; }

        /// <summary>
        /// Kind of fuel. (enumeration)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        /// <summary>
        /// Fuel Category eg Residual or Distillate
        /// </summary>
        [JsonProperty(PropertyName = "fuelCategory")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelCategory FuelCategory { get; set; }

        /// <summary>
        /// Amount of fuel bunkered. (tons)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Fuel type details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FuelType Type { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        [JsonProperty("bdnNumber")]
        public string BdnNumber { get; set; }

        /// <summary>
        /// Reference to recognized certification schemes (ISSC, RSB, etc.) or Unique numbers of the Proof of Sustainability. 
        /// </summary>
        [JsonProperty("posNumbers")]
        public List<Pos> PosNumbers { get; set; }

        /// <summary>
        /// Indicates whether no POS certificate has been issued.
        /// </summary>
        [JsonProperty("noPosIssued")]
        public bool? NoPosIssued { get; set; }

        /// <summary>
        /// Indicates whether this is an initial bunker charge.
        /// </summary>
        [JsonProperty("initial")]
        public bool Initial { get; set; }

        /// <summary>
        /// The percentage of biofuel used in blend. (%)
        /// </summary>
        [JsonProperty(PropertyName = "percentageOfBioFuelInBlend")]
        public double? PercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        /// Fossil component of biofuel blend.
        /// </summary>
        [JsonProperty(PropertyName = "fossilComponent")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions? FossilComponent { get; set; }

        /// <summary>
        /// Date and time when the hose was connected.
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeHoseConnected")]
        public DateTime? DateTimeHoseConnected { get; set; }

        /// <summary>
        /// Date and time when the hose was disconnected.
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeHoseDisconnected")]
        public DateTime? DateTimeHoseDisconnected { get; set; }

        /// <summary>
        /// Date and time when pumping fuel started.
        /// </summary>
        [JsonProperty(PropertyName = "startPumpingFuel")]
        public DateTime? StartPumpingFuel { get; set; }

        /// <summary>
        /// Date and time when pumping fuel stopped.
        /// </summary>
        [JsonProperty(PropertyName = "stopPumpingFuel")]
        public DateTime? StopPumpingFuel { get; set; }

        /// <summary>
        /// Method of delivery.
        /// </summary>
        [JsonProperty(PropertyName = "deliveredVia")]
        public string DeliveredVia { get; set; }

        /// <summary>
        /// Name of the barge.
        /// </summary>
        [JsonProperty(PropertyName = "bargeName")]
        public string BargeName { get; set; }

        /// <summary>
        /// Date and time when the barge was alongside.
        /// </summary>
        [JsonProperty(PropertyName = "bargeAlongside")]
        public DateTime? BargeAlongside { get; set; }

        /// <summary>
        /// Date and time when the barge left.
        /// </summary>
        [JsonProperty(PropertyName = "bargeAway")]
        public DateTime? BargeAway { get; set; }

        /// <summary>
        /// Seal number of the sample.
        /// </summary>
        [JsonProperty(PropertyName = "sampleSealNumber")]
        public string SampleSealNumber { get; set; }

        /// <summary>
        /// Description of the sample.
        /// </summary>
        [JsonProperty(PropertyName = "sampleDescription")]
        public string SampleDescription { get; set; }

    }
}
