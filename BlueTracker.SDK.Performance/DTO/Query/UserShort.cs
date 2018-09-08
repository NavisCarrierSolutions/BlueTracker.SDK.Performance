using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Query
{
    public class UserShort
    {
        /// <summary>
        /// Id (given by bluetracker.one)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Family Name
        /// </summary>
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        /// Given Name or First Name
        /// </summary>
        [JsonProperty("givenName")]
        public string GivenName { get; set; }
    }
}