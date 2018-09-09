using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// A ship owner.
    /// </summary>
    public class OwnerData
    {
        /// <summary>
        /// ID of owner.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Custom ID of owner (maximum lenght: 50).
        /// </summary>
        [JsonProperty("customId")]
        public string CustomId { get; set; }

        /// <summary>
        /// Name of owner (maximum length: 254).
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Street the owner lives in (maximum length: 256).
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// City the owner lives in (maximum length: 50).
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Zip code of the city the owner lives in (maximum length: 20).
        /// </summary>
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Country code of the country the owner lives in (maximum length: 2).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
