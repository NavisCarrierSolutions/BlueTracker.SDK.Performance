using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating ship information.
    /// </summary>
    public class ShipClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ShipClient instance.
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
        public ShipClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get a specific ship object.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <returns>The ship object.</returns>
        public Query.Ship GetSpecific(int imoNumber)
        {
            var route = $"/api/v1/ships/{imoNumber}";
            var ret = GetObject<Query.Ship>(route);
            return ret;
        }

        /// <summary>
        /// Returns a pages list of ships.
        /// </summary>
        /// <returns>
        /// A paged list of ship object, which belong to the company associated with the
        /// used API key.
        /// </returns>
        public PagedSearchResult<ShipShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/ships?page={page}&pageSize={pageSize}";
            var ret = GetObject<PagedSearchResult<ShipShort>>(route);
            return ret;
        }

        /// <summary>
        /// Creates or udpates a ship.
        /// </summary>
        /// <param name="shipData">The detailed ship object.</param>
        /// <returns>
        /// The newly created ship object.
        /// </returns>
        public Query.Ship CreateOrUpdate(ShipData shipData)
        {
            return PostObject<Query.Ship, ShipData>(shipData, "/api/v1/ships");
        }

        /// <summary>
        /// Enables or disables the batch mode of the ships data interface.
        /// </summary>
        /// <param name="imoNumber">IMO number of the vessel.</param>
        /// <param name="enableBatchMode">True to enable batch mode; false to disable batch mode.</param>
        /// <returns>The ship object.</returns>
        /// <remarks>
        /// When batch mode is enabled, data items pushed to the vessel do not trigger an immediate re-calculation.
        /// This is useful, if big amounts of items needs to be pushed. When the batch mode is disabled, a full
        /// re-calculation is triggered.
        /// </remarks>
        public Query.Ship SetBatchMode(int imoNumber, bool enableBatchMode)
        {
            var route = $"/api/v1/ships/{imoNumber}/batchMode";
            return PostObject<Query.Ship, bool>(enableBatchMode, route);
        }

        /// <summary>
        /// Triggers a re-calculation of the ship model.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <returns>The ship object.</returns>
        /// <remarks>
        /// Calling this method, will put the ship to <see cref="FeedState.Pending"/> mode, and a re-calulcation
        /// job is queued. The method call will then return. During execution of the re-calculation job, the ships
        /// feed state will be set to <see cref="FeedState.Calculation"/>. When the job is done, the ship feed 
        /// state will be set back to <see cref="FeedState.Online"/>.
        /// </remarks>
        public Query.Ship Calculate(int imoNumber)
        {
            var route = $"/api/v1/ships/{imoNumber}/batchMode";
            return PostEmpty<Query.Ship>(route);
        }
    }
}
