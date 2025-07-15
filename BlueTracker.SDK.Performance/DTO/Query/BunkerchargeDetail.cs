using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Model.Common;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    /// Bunker charge details.
    /// </summary>
    public class BunkerChargeDetail
    {
        /// <summary>
        /// Bunker date.
        /// </summary>
        [JsonProperty("bunkerDate")]
        public DateTime BunkerDate { get; set; }

        /// <summary>
        /// Name of bunker charge.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Fuel kind bunkered.
        /// </summary>
        [JsonProperty("fuelKind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions FuelKind { get; set; }

        /// <summary>
        /// Amount bunkered. (metric tonnes)
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// ISO grade.
        /// </summary>
        [JsonProperty("isoGrade")]
        public string IsoGrade { get; set; }

        /// <summary>
        /// Year of ISO grade version.
        /// </summary>
        [JsonProperty("isoVersion")]
        public string IsoVersion { get; set; }

        /// <summary>
        /// Density. (kg/m3)
        /// </summary>
        [JsonProperty("density")]
        public double? Density { get; set; }

        /// <summary>
        /// Viscosity. (cSt)
        /// </summary>
        [JsonProperty("viscosity")]
        public double? Viscosity { get; set; }

        /// <summary>
        /// Sulphur content. (%)
        /// </summary>
        [JsonProperty("sulphurContent")]
        public double? SulphurContent { get; set; }

        /// <summary>
        /// Lower calorific value. (kJ/kg)
        /// </summary>
        [JsonProperty("lcv")]
        public double? Lcv { get; set; }

        /// <summary>
        /// Bunker delivery note number.
        /// </summary>
        [JsonProperty("bdn")]
        public string Bdn { get; set; }

        /// <summary>
        /// Indicates whether the fuel is a biofuel.
        /// </summary>
        [JsonProperty("isBioFuel")]
        public bool IsBioFuel { get; set; }

        /// <summary>
        /// Indicates whether the fuel is a biofuel blend.
        /// </summary>
        [JsonProperty("isBioFuelBlend")]
        public bool IsBioFuelBlend { get; set; }

        /// <summary>
        /// Indicates whether a bunker delivery note is available.
        /// </summary>
        [JsonProperty("isBdnAvailable")]
        public bool IsBdnAvailable { get; set; }

        /// <summary>
        /// Bunker charge ID.
        /// </summary>
        [JsonProperty("bunkerChargeId")]
        public string BunkerChargeId { get; set; }

        /// <summary>
        /// Proof of sustainability information.
        /// </summary>
        [JsonProperty("posNumbers")]
        public List<Pos> PosNumbers { get; set; }

        /// <summary>
        /// Indicates whether no POS certificate was issued.
        /// </summary>
        [JsonProperty("noPosIssued")]
        public bool? NoPosIssued { get; set; }

        /// <summary>
        /// The percentage of biofuel used in blend. (%)
        /// </summary>
        [JsonProperty("percentageOfBioFuelInBlend")]
        public double? PercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        /// Fossil component of bio fuel blend.
        /// </summary>
        [JsonProperty("fossilComponent")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions? FossilComponent { get; set; }

        /// <summary>
        /// Bunker report ID.
        /// </summary>
        [JsonProperty("bunkerReportId")]
        public int BunkerReportId { get; set; }

        /// <summary>
        /// Date and time hose was connected.
        /// </summary>
        [JsonProperty("dateTimeHoseConnected")]
        public DateTime? DateTimeHoseConnected { get; set; }

        /// <summary>
        /// Date and time hose was disconnected.
        /// </summary>
        [JsonProperty("dateTimeHoseDisconnected")]
        public DateTime? DateTimeHoseDisconnected { get; set; }

        /// <summary>
        /// Start time of pumping fuel.
        /// </summary>
        [JsonProperty("startPumpingFuel")]
        public DateTime? StartPumpingFuel { get; set; }

        /// <summary>
        /// Stop time of pumping fuel.
        /// </summary>
        [JsonProperty("stopPumpingFuel")]
        public DateTime? StopPumpingFuel { get; set; }

        /// <summary>
        /// Delivery method.
        /// </summary>
        [JsonProperty("deliveredVia")]
        public string DeliveredVia { get; set; }

        /// <summary>
        /// Name of the barge.
        /// </summary>
        [JsonProperty("bargeName")]
        public string BargeName { get; set; }

        /// <summary>
        /// Date and time barge was alongside.
        /// </summary>
        [JsonProperty("bargeAlongside")]
        public DateTime? BargeAlongside { get; set; }

        /// <summary>
        /// Date and time barge left.
        /// </summary>
        [JsonProperty("bargeAway")]
        public DateTime? BargeAway { get; set; }

        /// <summary>
        /// Sample seal number.
        /// </summary>
        [JsonProperty("sampleSealNumber")]
        public string SampleSealNumber { get; set; }

        /// <summary>
        /// Sample description.
        /// </summary>
        [JsonProperty("sampleDescription")]
        public string SampleDescription { get; set; }

        /// <summary>
        /// Fuel category.
        /// </summary>
        [JsonProperty("fuelCategory")]
        public FuelCategory? FuelCategory { get; set; }

        /// <summary>
        /// CO2 factor.
        /// </summary>
        [JsonProperty("co2Factor")]
        public double? Co2Factor { get; set; }

        /// <summary>
        /// Bunker date in local time zone.
        /// </summary> 
        [JsonProperty("bunkerDateLocal")]
        public DateTimeOffset BunkerDateLocal { get; set; }
    }
}
