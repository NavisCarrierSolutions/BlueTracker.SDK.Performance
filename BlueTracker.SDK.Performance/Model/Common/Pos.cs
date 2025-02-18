using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class Pos
    {
        /// <summary>
        /// Identifier of the Proof of Sustainability.
        /// </summary>
        public Guid Uid { get; set; }

        /// <summary>
        /// Bio component of the fuel.
        /// </summary>
        [JsonProperty(PropertyName = "bioComponent")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BioBlendOptions BioComponent { get; set; }

        /// <summary>
        /// Amount of bio component in the fuel. (tons)
        /// </summary>
        public double? BioComponentAmount { get; set; }

        /// <summary>
        /// Measurement unit of the bio component.
        /// </summary>
        [JsonProperty(PropertyName = "bioMeasure")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ComponentMeasurementUnit BioMeasure { get; set; }

        /// <summary>
        /// Bio grade of the fuel.
        /// </summary>
        public double? FameBioGrade { get; set; }

        /// <summary>
        /// Fossil component of the fuel.
        /// </summary>
        [JsonProperty(PropertyName = "fossilComponent")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions FossilComponent { get; set; }

        /// <summary>
        /// Fossil component amount in the fuel. (tons)
        /// </summary>
        public double? FossilComponentAmount { get; set; }

        /// <summary>
        /// Measurement unit of the fossil component.
        /// </summary>
        [JsonProperty(PropertyName = "fossilMeasure")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ComponentMeasurementUnit FossilMeasure { get; set; }

        /// <summary>
        /// Fossil grade of the fuel.
        /// </summary>
        public double? FossilGrade { get; set; }

        /// <summary>
        /// Energy content of the fuel. (MJ)
        /// </summary>
        public double? Energy { get; set; }

        /// <summary>
        /// GHG emissions factor. (gCO2eq/MJ)
        /// </summary>
        public double? EFactor { get; set; }

        /// <summary>
        /// Indicates whether the Red II regulation has been applied.
        /// </summary>
        public bool RedTwoApplied { get; set; }

        /// <summary>
        /// Unique number of the Proof of Sustainability certificate.
        /// </summary>
        public string PosNumber { get; set; }
    }
}
