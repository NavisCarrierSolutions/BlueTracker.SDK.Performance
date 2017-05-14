using BlueTracker.SDK.Performance.Core;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating ship classes.
    /// </summary>
    public class ShipClassClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ShipClassClient instance.
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
        public ShipClassClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific ship class.
        /// </summary>
        /// <param name="id">ID of the ship class.</param>
        /// <returns>
        /// The ship class.
        /// </returns>
        public Query.ShipClass GetSpecific(int id)
        {
            var route = $"/api/v1/shipClasses/{id}";
            var ret = GetObject<Query.ShipClass>(route);
            return ret;
        }

        /// <summary>
        /// Returns a paged list of ship classes.
        /// </summary>
        /// <param name="page">Page of the result (default: 0).</param>
        /// <param name="pageSize">Size of the page (default: 20).</param>
        /// <returns>
        /// A paged list of ship classes.
        /// </returns>
        public PagedSearchResult<Query.ShipClassShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/shipClasses?page={page}&pageSize={pageSize}";
            var ret = GetObject<PagedSearchResult<Query.ShipClassShort>>(route);
            return ret;
        }

        /// <summary>
        /// Creates a ship class.
        /// </summary>
        /// <param name="shipClass">The detailed ship class.</param>
        /// <returns>
        /// The newly created ship class.
        /// </returns>
        public Query.ShipClass Create(Post.ShipClassData shipClass)
        {
            const string route = "/api/v1/shipClasses";
            return PostObject<Query.ShipClass, Post.ShipClassData>(shipClass, route);
        }

        /// <summary>
        /// Updates a ship class.
        /// </summary>
        /// <param name="id">ID identifying the ship class.</param>
        /// <param name="shipClass">The detailed ship class.</param>
        /// <returns>
        /// The updated ship class.
        /// </returns>
        public Query.ShipClass Update(int id, Post.ShipClassData shipClass)
        {
            var route = $"/api/v1/shipClasses/{id}";
            return PutObject<Query.ShipClass, Post.ShipClassData>(shipClass, route);
        }

        /// <summary>
        /// Deletes a ship class.
        /// </summary>
        /// <param name="id">ID identifying the ship class.</param>
        /// <returns>
        /// The deleted ship class.
        /// </returns>
        public Query.ShipClass Delete(int id)
        {
            var route = $"/api/v1/shipClasses/{id}";
            return DeleteObject<Query.ShipClass>(route);
        }
    }
}