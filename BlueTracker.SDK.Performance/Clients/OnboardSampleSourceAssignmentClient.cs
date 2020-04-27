using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;

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
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public OnboardSampleSourceAssignmentClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new OnboardSampleSourceAssignmentClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public OnboardSampleSourceAssignmentClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get a sample source value ranges for source identified by name
        /// </summary>
        /// <param name="imoNumber">IMO number of ship.</param>
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
