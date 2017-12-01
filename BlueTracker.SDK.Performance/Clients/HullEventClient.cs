using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating hull event information.
    /// </summary>
    public class HullEventClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="HullEventClient"/> instance.
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
        public HullEventClient(string serverAddress = null, string authorization = null)
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific hull event object.
        /// </summary>
        /// <param name="id">ID of the hull event to retrieve.</param>
        /// <returns>The retrieved hull event object.</returns>
        public HullEvent GetSpecific(int id)
        {
            var route = $"/api/v1/hullEvents/{id}";
            var ret = GetObject<HullEvent>(route);

            return ret;
        }

        /// <summary>
        /// Returns a paged list of hull events (with an optional time range filter).
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of hull event objects for the specified IMO number within the specified time range.
        /// </returns>
        public PagedSearchResult<HullEventShort> GetAll(int imoNumber, DateTime? start = null, DateTime? end = null,
            int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var requestString =
                $"/api/v1/ships/{imoNumber}/hullEvents?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<HullEventShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Returns a paged list of hull event objects since a specific version stamp.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="sinceVersion">Version stamp to filter the hull events.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of hull event objects for the specified IMO number, which have a version stamp above
        /// the specified sinceVersion parameter.
        /// </returns>
        /// <remarks>
        /// Whenever a ship related entity (report, leg, voyage etc.) is created or modified, a version counter is increased.
        /// The new or modified entity remembers the version at that moment. This allows the API client to get all
        /// modified entities since the last query.
        /// </remarks>
        public PagedSearchResult<HullEventShort> GetSinceVersion(int imoNumber, long sinceVersion, int page = 0, int pageSize = 20)
        {
            var requestString =
                $"/api/v1/ships/{imoNumber}/hullEvents?sinceVersion={sinceVersion}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<HullEventShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Creates or updates an hull event.
        /// </summary>
        /// <param name="hullEventData">The detailed hull event object.</param>
        /// <returns>
        /// The newly created or updated hull event.
        /// </returns>
        public HullEvent CreateOrUpdate(HullEventData hullEventData)
        {
            return PostObject<HullEvent, HullEventData>(hullEventData, "/api/v1/hullEvents");
        }

        /// <summary>
        /// Updates the hull event with the specified id.
        /// </summary>
        /// <param name="id">Id of hull event to update.</param>
        /// <param name="hullEventData">The detailed hull event object.</param>
        /// <returns>
        /// The updated hull event.
        /// </returns>
        public HullEvent Update(int id, HullEventData hullEventData)
        {
            return PutObject<HullEvent, HullEventData>(hullEventData, $"/api/v1/hullEvents/{id}");
        }
    }
}
