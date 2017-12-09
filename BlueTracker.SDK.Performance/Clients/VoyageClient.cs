using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating voyage information.
    /// </summary>
    /// <remarks>
    /// A voyage is defined as an aggregation of adjacent legs with a common name.
    /// </remarks>
    public class VoyageClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new VoyageClient instance.
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
        public VoyageClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific voyage object.
        /// </summary>
        /// <param name="id">ID of the voyage.</param>
        /// <returns>The voyage object.</returns>
        public Voyage GetSpecific(int id)
        {
            var route = $"/api/v1/voyages/{id}";
            var ret = GetObject<Voyage>(route);
            return ret;
        }

        /// <summary>
        /// Gets the performance summary for a specific voyage.
        /// </summary>
        /// <param name="voyageId">ID of the voyage.</param>
        /// <returns>The voyage performance summary.</returns>
        public VoyageSummary GetSummary(int voyageId)
        {
            var route = $"/api/v1/voyages/{voyageId}/summary";
            var ret = GetObject<VoyageSummary>(route);
            return ret;
        }

        /// <summary>
        /// Returns a paged list of voyages.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of voyage objects for the specified IMO number.
        /// </returns>
        public PagedSearchResult<VoyageShort> GetAll(int imoNumber, int page = 0, int pageSize = 20)
        {
            var request = $"/api/v1/ships/{imoNumber}/voyages?page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<VoyageShort>>(request);

            return result;
        }

        /// <summary>
        /// Returns a pages list of voyage objects since a specific version stamp.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="sinceVersion">Version stamp to filter the voyages.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A pages list of voyage objects for specified IMO number, which have a version stamp above
        /// the specified sinceVersion parameter.
        /// </returns>
        /// <remarks>
        /// Whenever a ship related entity (report, leg, voyage etc.) is created or modified, a version counter is increased.
        /// The new or modified entity remembers the version at that moment. This allows the API client to get all
        /// modified entities since the last query.
        /// </remarks>
        public PagedSearchResult<VoyageShort> GetSinceVersion(int imoNumber, long sinceVersion, int page = 0, int pageSize = 20)
        {
            var request = $"/api/v1/ships/{imoNumber}/voyages?sinceVersion={sinceVersion}&page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<VoyageShort>>(request);

            return result;
        }

        /// <summary>
        /// Creates or updates a voyage.
        /// </summary>
        /// <param name="voyageData">The detailed voyage object.</param>
        /// <returns>
        /// The voyage object returned from the service (including ID).
        /// </returns>
        public Voyage CreateOrUpdate(VoyageData voyageData)
        {
            return PostObject<Voyage, VoyageData>(voyageData, "/api/v1/voyages");
        }

        /// <summary>
        /// Creates or updates multiple voyages.
        /// </summary>
        /// <param name="voyageData">List of voyages to be updated or created.</param>
        /// <returns>
        /// The newly created or updated voyages.
        /// </returns>
        /// <remarks>
        /// Uploads of multiple items must refer to the same IMO number. The maximum number
        /// of items is 25. Further it is required to enable the batch mode for the ship.
        /// </remarks>
        public List<Voyage> CreateOrUpdate(List<VoyageData> voyageData)
        {
            return PostObject<List<Voyage>, List<VoyageData>>(voyageData, "/api/v1/voyages/batch");
        }
    }
}
