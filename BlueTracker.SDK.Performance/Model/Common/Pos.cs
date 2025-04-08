using System;
using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class Pos
    {
        /// <summary>
        /// Identifier of the Proof of Sustainability.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
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
        [JsonProperty(PropertyName = "bioComponentAmount")]
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
        [JsonProperty(PropertyName = "fameBioGrade")]
        public double? FameBioGrade { get; set; }

        /// <summary>
        /// Fossil grade of the fuel.
        /// </summary>
        [JsonProperty(PropertyName = "fossilGrade")]
        public double? FossilGrade { get; set; }

        /// <summary>
        /// Energy content of the fuel. (MJ)
        /// </summary>
        [JsonProperty(PropertyName = "energy")]
        public double? Energy { get; set; }

        /// <summary>
        /// GHG emissions factor. (gCO2eq/MJ)
        /// </summary>
        [JsonProperty(PropertyName = "eFactor")]
        public double? EFactor { get; set; }

        /// <summary>
        /// Indicates whether the Red II regulation has been applied.
        /// </summary>
        [JsonProperty(PropertyName = "redTwoApplied")]
        public bool RedTwoApplied { get; set; }

        /// <summary>
        /// Unique number of the Proof of Sustainability certificate.
        /// </summary>
        [JsonProperty(PropertyName = "posNumber")]
        public string PosNumber { get; set; }

        /// <summary>
        /// Files associated with the Proof of Sustainability certificates.
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public List<string> Files { get; set; }
    }
}
