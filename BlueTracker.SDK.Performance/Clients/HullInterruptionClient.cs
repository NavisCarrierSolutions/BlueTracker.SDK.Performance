using System;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating hull interruption information.
    /// </summary>
    public class HullInterruptionClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="HullInterruptionClient"/> instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public HullInterruptionClient(string authorization)
            : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="HullInterruptionClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter, the default service address will be used.
        /// </remarks>
        public HullInterruptionClient(string serverAddress, string authorization)
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific hull interruption object.
        /// </summary>
        /// <param name="id">ID of the hull interruption to retrieve.</param>
        /// <returns>The retrieved hull interruption object.</returns>
        public HullInterruption GetSpecific(int id)
        {
            var route = $"/api/v1/hullInterruptions/{id}";
            var ret = GetObject<HullInterruption>(route);

            return ret;
        }

        /// <summary>
        /// Returns a paged list of hull interruptions (with an optional time range filter).
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of hull interruption objects for the specified IMO number within the specified time range.
        /// </returns>
        public PagedSearchResult<HullInterruptionShort> GetAll(int imoNumber, DateTime? start = null, DateTime? end = null,
            int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var requestString =
                $"/api/v1/ships/{imoNumber}/hullInterruptions?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<HullInterruptionShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Returns a paged list of hull interruption objects since a specific version stamp.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="sinceVersion">Version stamp to filter the hull interruptions.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of hull interruption objects for the specified IMO number, which have a version stamp above
        /// the specified sinceVersion parameter.
        /// </returns>
        /// <remarks>
        /// Whenever a ship related entity (report, leg, voyage etc.) is created or modified, a version counter is increased.
        /// The new or modified entity remembers the version at that moment. This allows the API client to get all
        /// modified entities since the last query.
        /// </remarks>
        public PagedSearchResult<HullInterruptionShort> GetSinceVersion(int imoNumber, long sinceVersion, int page = 0, int pageSize = 20)
        {
            var requestString =
                $"/api/v1/ships/{imoNumber}/hullInterruptions?sinceVersion={sinceVersion}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<HullInterruptionShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Creates or updates a hull interruption.
        /// </summary>
        /// <param name="hullInterruptionData">The detailed hull interruption object.</param>
        /// <returns>
        /// The newly created or updated hull interruption.
        /// </returns>
        public HullInterruption CreateOrUpdate(HullInterruptionData hullInterruptionData)
        {
            return PostObject<HullInterruption, HullInterruptionData>(hullInterruptionData, "/api/v1/hullInterruptions");
        }

        /// <summary>
        /// Updates the hull interruption with the specified id.
        /// </summary>
        /// <param name="id">Id of hull interruption to update.</param>
        /// <param name="hullInterruptionData">The detailed hull interruption object.</param>
        /// <returns>
        /// The updated hull interruption.
        /// </returns>
        public HullInterruption Update(int id, HullInterruptionData hullInterruptionData)
        {
            return PutObject<HullInterruption, HullInterruptionData>(hullInterruptionData, $"/api/v1/hullInterruptions/{id}");
        }

        /// <summary>
        /// Deletes a hull interruption.
        /// </summary>
        /// <param name="id">ID identifying the hull interruption.</param>
        /// <returns>
        /// The deleted hull interruption.
        /// </returns>
        public HullInterruption Delete(int id)
        {
            var route = $"/api/v1/hullInterruptions/{id}";
            return DeleteObject<HullInterruption>(route);
        }
    }
}
