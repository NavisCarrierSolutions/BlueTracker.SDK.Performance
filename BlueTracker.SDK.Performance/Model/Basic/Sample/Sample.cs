using Newtonsoft.Json;
using System;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    /// Onboard sample.
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// IMO number of ship.
        /// </summary>
        [JsonProperty(PropertyName = "imoNumber")]
        public int ImoNumber { get; set; }

        /// <summary>
        /// Custom ID.
        /// </summary>
        /// <remarks>
        /// The custom ID can be used to identify a specific sample with an ID provided from the client.
        /// If a sample is send with an already exsiting custom ID, the respective sample will be
        /// replaced.
        /// </remarks>
        [JsonProperty(PropertyName = "customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Time stamp of sample.
        /// </summary>
        [JsonProperty(PropertyName = "timestampUtc")]
        public DateTime? TimeStampUtc { get; set; }

        /// <summary>
        /// Navigational data.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public Navigation Navigation { get; set; }

        /// <summary>
        /// Environmental data.
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public Environment Environment { get; set; }

        /// <summary>
        /// Engine data.
        /// </summary>
        [JsonProperty(PropertyName = "engine")]
        public Engine Engine { get; set; }

        /// <summary>
        /// Deck equipment
        /// </summary>
        [JsonProperty(PropertyName = "deckEquipment")]
        public DeckEquipment DeckEquipment { get; set; }

        /// <summary>
        /// Tank data
        /// </summary>
        public Tanks Tanks { get; set; }
    }
}