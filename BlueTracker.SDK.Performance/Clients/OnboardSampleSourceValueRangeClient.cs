using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting onboard sample source value ranges.
    /// </summary>
    public class OnboardSampleSourceValueRangeClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new OnboardSampleSourceValueRangeClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// Instead of specifying the server address and the API token with constructur parameters,
        /// they can be set in the appSettings section of the app.config. The key BlueCloud_ApiKey
        /// is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is neither specified as constructor parameter,
        /// nor in the app settings, the default service address will be used.
        /// </remarks>
        public OnboardSampleSourceValueRangeClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get a sample source value ranges for source identified by name
        /// </summary>
        /// <param name="sourceName">Name of sample source</param>
        /// <returns>List of all sample sources value ranges</returns>
        public List<OnboardSampleSourceValueRange> GetAll(string sourceName)
        {
            return GetObject<List<OnboardSampleSourceValueRange>>($"/api/v1/onboardSamples/sources/{sourceName}/valueRanges");
        }

        /// <summary>
        /// Get a sample source value ranges for source identified by id
        /// </summary>
        /// <param name="sourceId">The ID of the sample source</param>
        /// <returns>List of all sample sources value ranges</returns>
        public List<OnboardSampleSourceValueRange> GetAll(int sourceId)
        {
            return GetObject<List<OnboardSampleSourceValueRange>>($"/api/v1/onboardSamples/sources/{sourceId}/valueRanges");
        }

        /// <summary>
        /// Get a single sample source value range for sample source identified by name and vessel identified by ImoNumber 
        /// </summary>
        /// <param name="sourceName">The name of the sample source</param>
        /// <param name="imoNumber">The Imo Number of the vessel</param>
        /// <returns>Sample sources value range for specific ship (single entry in array)</returns>
        public List<OnboardSampleSourceValueRange> Get(string sourceName, int imoNumber)
        {
            return GetObject<List<OnboardSampleSourceValueRange>>($"/api/v1/ships/{imoNumber}/onboardSamples/{sourceName}/valueRanges");
        }
    }
}
