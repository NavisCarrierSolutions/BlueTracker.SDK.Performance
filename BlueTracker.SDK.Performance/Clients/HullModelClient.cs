using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating hull models.
    /// </summary>
    public class HullModelClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new HullModelClient instance.
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
        public HullModelClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific hull model.
        /// </summary>
        /// <param name="id">ID of the hull model.</param>
        /// <returns>
        /// The hull model.
        /// </returns>
        public Query.HullModel GetSpecific(int id)
        {
            var route = $"/api/v1/hullModels/{id}";
            var ret = GetObject<Query.HullModel>(route);
            return ret;
        }

        /// <summary>
        /// Returns a paged list of hull models metadata.
        /// </summary>
        /// <param name="page">Page of the result (default: 0).</param>
        /// <param name="pageSize">Size of the page (default: 20).</param>
        /// <returns>
        /// A paged list of hull model metadata.
        /// </returns>
        public PagedSearchResult<Query.HullModel> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/hullModels?page={page}&pageSize={pageSize}";
            var ret = GetObject<PagedSearchResult<Query.HullModel>>(route);
            return ret;
        }

        /// <summary>
        /// Create a hull model.
        /// </summary>
        /// <param name="hullModel">The detailed hull model.</param>
        /// <returns>
        /// The newly created hull model.
        /// </returns>
        public Query.HullModel Create(HullModelData hullModel)
        {
            const string route = "/api/v1/hullModels";
            return PostObject<Query.HullModel, HullModelData>(hullModel, route);
        }

        /// <summary>
        /// Update a hull model.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <param name="hullModel">The detailed hull model.</param>
        /// <returns>
        /// The updated hull model.
        /// </returns>
        public Query.HullModel Update(int id, HullModelData hullModel)
        {
            var route = $"/api/v1/hullModels/{id}";
            return PutObject<Query.HullModel, HullModelData>(hullModel, route);
        }

        /// <summary>
        /// Deletes a hull model.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <returns>
        /// The deleted hull model.
        /// </returns>
        public Query.HullModel Delete(int id)
        {
            var route = $"/api/v1/hullModels/{id}";
            return DeleteObject<Query.HullModel>(route);
        }
    }
}