using Newtonsoft.Json;
using System;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Represents details about on-shore power supply usage, including energy consumption and associated EDN file
    /// information.
    /// </summary>
    /// <remarks>This class is used to capture and transfer information related to the consumption of on-shore
    /// electrical power and its corresponding documentation. It is typically used in scenarios where tracking or
    /// reporting of shore power usage is required.</remarks>
    public class OnShorePowerSupplyDetail
    {
        /// <summary>
        /// Gets or sets the total amount of energy consumed, in kilowatt-hours.
        /// </summary>
        [JsonProperty("consumedEnergy")]
        public double? ConsumedEnergy { get; set; }

        /// <summary>
        /// Gets or sets the name of the EDN file associated with this object.
        /// </summary>
        [JsonProperty("ednFile")]
        public string EdnFile { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (UID) of the EDN file.
        /// </summary>
        [JsonProperty("ednFileUid")]
        public Guid? EdnFileUid { get; set; }
    }
}
