using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;

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
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public OnboardSampleSourceValueRangeClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new OnboardSampleSourceValueRangeClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public OnboardSampleSourceValueRangeClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get a sample source value ranges for source identified by name
        /// </summary>
        /// <param name="sourceName">Name of sample source</param>
        /// <returns>List of all sample source value ranges</returns>
        public List<OnboardSampleSourceValueRange> GetAll(string sourceName)
        {
            return GetObject<List<OnboardSampleSourceValueRange>>($"/api/v1/onboardSamples/sources/{sourceName}/valueRanges");
        }

        /// <summary>
        /// Get a sample source value ranges for source identified by id
        /// </summary>
        /// <param name="sourceId">The ID of the sample source</param>
        /// <returns>List of all sample source value ranges</returns>
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
        public OnboardSampleSourceValueRange Get(string sourceName, int imoNumber)
        {
            return GetObject<OnboardSampleSourceValueRange>($"/api/v1/ships/{imoNumber}/onboardSamples/{sourceName}/valueRange");
        }

        /// <summary>
        /// Returns a list of all sample source value ranges associated with your particular ship in your account identified by ImoNumber
        /// </summary>
        /// <param name="imoNumber">ImoNumber of the ship</param>
        /// <returns>List of value ranges associated with ship</returns>
        public List<OnboardSampleSourceValueRange> Get(int imoNumber)
        {
            return GetObject<List<OnboardSampleSourceValueRange>>($"/api/v1/ships/{imoNumber}/onboardSampleValueRanges");
        }
    }
}
