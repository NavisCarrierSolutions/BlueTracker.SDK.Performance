using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Core
{
    /// <summary>
    /// Geographical position information.
    /// </summary>
    /// <remarks>
    /// The position is represented in full degrees with fractions, where the 
    /// sign represents the hemisphere.
    /// </remarks>
    /// <example>
    /// 53° 12.7' N; 008° 34.7' E
    ///   -> Latitude:  +53.211678
    ///   -> Longitude:  +8.578333
    /// 
    /// 12° 43.3' S; 127° 12.1' W
    ///   -> Latitude:   -12.721667
    ///   -> Longitude: -127.201667 
    /// </example>
    public class Position
    {
        /// <summary>
        /// Geographical latitude. (Unit: deg; Range: -90 ... +90)
        /// </summary>
        /// <remarks>
        /// A negative value represents the southern hemisphere, a postive value
        /// represents the nothern hemisphere.
        /// </remarks>
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Geographical longitude. (Unit: deg; Range: -180 ... +180)
        /// </summary>
        /// <remarks>
        /// A negative value represents the western hemisphere, a positive value
        /// represents the eastern hemisphere.
        /// </remarks>
        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; set; }
    }
}