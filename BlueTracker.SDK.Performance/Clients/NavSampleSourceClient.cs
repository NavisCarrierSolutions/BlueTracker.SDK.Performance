using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting onboard sample sources.
    /// </summary>
    public class NavSampleSourceClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new SampleClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public NavSampleSourceClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new SampleClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public NavSampleSourceClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get all NavSampleSources for the company
        /// </summary>
        /// <returns>List of all sample sources</returns>
        public List<NavSampleSource> GetAll()
        {
            return GetObject<List<NavSampleSource>>("/api/v1/navSamples/sources");
        }

        /// <summary>
        /// Get a specific NavSampleSource identified by name
        /// </summary>
        /// <param name="sourceName">The name of the sample source</param>
        /// <returns>The sample source</returns>
        public NavSampleSource Get(string sourceName)
        {
            return GetObject<NavSampleSource>($"/api/v1/navSamples/sources/{sourceName}");
        }

        /// <summary>
        /// Get a specific NavSampleSource identified by Id
        /// </summary>
        /// <param name="sourceId">The Id of the sample source</param>
        /// <returns>The sample source</returns>
        public NavSampleSource Get(int sourceId)
        {
            return GetObject<NavSampleSource>($"/api/v1/navSamples/sources/{sourceId}");
        }
    }
}
