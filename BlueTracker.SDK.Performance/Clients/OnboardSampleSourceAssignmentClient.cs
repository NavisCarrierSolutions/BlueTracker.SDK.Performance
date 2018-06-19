using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for handling OnboardSampleSourceAssignments
    /// </summary>
    public class OnboardSampleSourceAssignmentClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new OnboardSampleSourceAssignmentClient instance.
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
        public OnboardSampleSourceAssignmentClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get a sample source value ranges for source identified by name
        /// </summary>
        /// <param name="sourceName">Name of sample source</param>
        /// <returns>List of all sample source value ranges</returns>
        public List<OnboardSampleSourceAssignment> GetAll(int imoNumber)
        {
            return GetObject<List<OnboardSampleSourceAssignment>>($"/api/v1/ships/{imoNumber}/onboardSampleSourceAssignments");
        }

        /// <summary>
        /// Creates an OnboardSampleSourceAssignment between a ship and a OnboardSampleSource
        /// </summary>
        /// <param name="imoNumber">imo number of ship</param>
        /// <param name="sourceName">name of OnboardSampleSource</param>
        /// <returns>created assignment</returns>
        public OnboardSampleSourceAssignment Post(int imoNumber, string sourceName)
        {
            return PostEmpty<OnboardSampleSourceAssignment>(
                $"/api/v1/ships/{imoNumber}/onboardSampleSourceAssignments?sourceName={sourceName}");
        }
    }
}
