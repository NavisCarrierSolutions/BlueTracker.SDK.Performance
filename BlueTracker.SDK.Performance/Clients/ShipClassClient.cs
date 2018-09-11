using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating ship classes.
    /// </summary>
    public class ShipClassClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ShipClassClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public ShipClassClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new ShipClassClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ShipClassClient(string serverAddress, string authorization) :
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
        public ShipClass GetSpecific(int id)
        {
            var route = $"/api/v1/shipClasses/{id}";
            var ret = GetObject<ShipClass>(route);
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
        public PagedSearchResult<ShipClassShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/shipClasses?page={page}&pageSize={pageSize}";
            var ret = GetObject<PagedSearchResult<ShipClassShort>>(route);
            return ret;
        }

        /// <summary>
        /// Creates a ship class.
        /// </summary>
        /// <param name="shipClass">The detailed ship class.</param>
        /// <returns>
        /// The newly created ship class.
        /// </returns>
        public ShipClass Create(ShipClassData shipClass)
        {
            const string route = "/api/v1/shipClasses";
            return PostObject<ShipClass, ShipClassData>(shipClass, route);
        }

        /// <summary>
        /// Updates a ship class.
        /// </summary>
        /// <param name="id">ID identifying the ship class.</param>
        /// <param name="shipClass">The detailed ship class.</param>
        /// <returns>
        /// The updated ship class.
        /// </returns>
        public ShipClass Update(int id, ShipClassData shipClass)
        {
            var route = $"/api/v1/shipClasses/{id}";
            return PutObject<ShipClass, ShipClassData>(shipClass, route);
        }

        /// <summary>
        /// Deletes a ship class.
        /// </summary>
        /// <param name="id">ID identifying the ship class.</param>
        /// <returns>
        /// The deleted ship class.
        /// </returns>
        public ShipClass Delete(int id)
        {
            var route = $"/api/v1/shipClasses/{id}";
            return DeleteObject<ShipClass>(route);
        }
    }
}