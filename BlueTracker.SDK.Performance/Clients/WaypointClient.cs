using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;
using BlueTracker.SDK.Performance.DTO.Query.Routing;
using ActiveRoute = BlueTracker.SDK.Performance.DTO.Post.Routing.ActiveRoute;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating voyage information.
    /// </summary>
    /// <remarks>
    /// A voyage is defined as an aggregation of adjacent legs with a common name.
    /// </remarks>
    public class WaypointClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new VoyageClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public WaypointClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new VoyageClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public WaypointClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Creates the active route for a specific ship (and overwrites the current active route)
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship</param>
        /// <param name="activeRoute">ActiveRoute</param>
        /// <returns>Short description of posted route</returns>
        public ActiveRouteShort CreateActiveRoute(int imoNumber, ActiveRoute activeRoute)
        {
            return PostObject<ActiveRouteShort, ActiveRoute>(activeRoute, $"/api/v1/ships/{imoNumber}/activeRoute");
        }

        /// <summary>
        /// Get the currently active route for a ship
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship</param>
        /// <returns></returns>
        public DTO.Query.Routing.ActiveRoute GetActiveRoute(int imoNumber)
        {
            return GetObject<DTO.Query.Routing.ActiveRoute>($"/api/v1/ships/{imoNumber}/activeRoute");
        }
    }
}
