using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating consumption curves.
    /// </summary>
    public class ConsumptionCurveClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ConsumptionCurveClient instance.
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
        public ConsumptionCurveClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific consumption curve.
        /// </summary>
        /// <param name="id">ID of the consumption curve.</param>
        /// <returns>
        /// The consumption curve.
        /// </returns>
        public Query.ConsumptionCurve GetSpecific(int id)
        {
            var route = $"/api/v1/consumptionCurves/{id}";
            var result = GetObject<Query.ConsumptionCurve>(route);
            return result;
        }

        /// <summary>
        /// Returns a paged list of consumption curves metadata.
        /// </summary>
        /// <param name="page">Page of the result (default: 0).</param>
        /// <param name="pageSize">Size of the page (default: 20).</param>
        /// <returns>
        /// A paged list of consumption curves metadata.
        /// </returns>
        public PagedSearchResult<CharterCurveShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/consumptionCurves?page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<CharterCurveShort>>(route);
            return result;
        }

        /// <summary>
        /// Create a consumption curve.
        /// </summary>
        /// <param name="consumptionCurve">The detailed consumption curve.</param>
        /// <returns>
        /// The newly created consumption curve.
        /// </returns>
        public Query.ConsumptionCurve Create(Post.ConsumptionCurve consumptionCurve)
        {
            const string route = "/api/v1/consumptionCurves";
            return PostObject<Query.ConsumptionCurve, Post.ConsumptionCurve>(consumptionCurve, route);
        }

        /// <summary>
        /// Update a consumption curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <param name="consumptionCurve">The detailed consumption curve.</param>
        /// <returns>
        /// The updated consumption curve.
        /// </returns>
        public Query.ConsumptionCurve Update(int id, Post.ConsumptionCurve consumptionCurve)
        {
            var route = $"/api/v1/consumptionCurves/{id}";
            return PutObject<Query.ConsumptionCurve, Post.ConsumptionCurve>(consumptionCurve, route);
        }

        /// <summary>
        /// Deletes a consumption curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <returns>
        /// The deleted consumption curve.
        /// </returns>
        public CharterCurveShort Delete(int id)
        {
            var route = $"/api/v1/consumptionCurves/{id}";
            return DeleteObject<CharterCurveShort>(route);
        }
    }
}