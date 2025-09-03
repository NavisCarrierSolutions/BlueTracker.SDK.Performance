using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class Consumption
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FuelKindOptions Kind { get; set; }

        public double? Amount { get; set; }
        public double? AmountIso { get; set; }

        public double? AmountCo2 { get; set; }

        public double? Volume { get; set; }

        public double? Density { get; set; }

        public double? Temp { get; set; }

        public FuelType Type { get; set; }

        /// <summary>
        /// Percentage of biofuel in the fuel blend, if applicable (used only for old ROB based systems).
        /// </summary>
        public double? PercentageOfBioFuelInBlend { get; set; }
    }
}