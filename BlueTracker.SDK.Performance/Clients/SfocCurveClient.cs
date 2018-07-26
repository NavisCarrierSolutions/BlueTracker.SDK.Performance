using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating sfoc curves.
    /// </summary>
    public class SfocCurveClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new SfocCurveClient instance.
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
        public SfocCurveClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific sfoc curve.
        /// </summary>
        /// <param name="id">ID of the sfoc curve.</param>
        /// <returns>
        /// The sfoc curve.
        /// </returns>
        public SfocCurveDetails GetSpecific(int id)
        {
            var route = $"/api/v1/sfocCurves/{id}";
            var result = GetObject<SfocCurveDetails>(route);
            return result;
        }

        /// <summary>
        /// Returns a paged list of sfoc curves metadata.
        /// </summary>
        /// <param name="page">Page of the result (default: 0).</param>
        /// <param name="pageSize">Size of the page (default: 20).</param>
        /// <returns>
        /// A paged list of sfoc curves metadata.
        /// </returns>
        public PagedSearchResult<SfocCurveShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/sfocCurves?page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<SfocCurveShort>>(route);
            return result;
        }

        /// <summary>
        /// Create a sfoc curve model.
        /// </summary>
        /// <param name="sfocCurve">The detailed sfoc curve.</param>
        /// <returns>
        /// The newly created sfoc curve.
        /// </returns>
        public SfocCurveDetails Create(SfocCurve sfocCurve)
        {
            const string route = "/api/v1/sfocCurves";
            return PostObject<SfocCurveDetails, SfocCurve>(sfocCurve, route);
        }

        /// <summary>
        /// Update a sfoc curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <param name="sfocCurve">The detailed sfoc curve.</param>
        /// <returns>
        /// The updated sfoc curve.
        /// </returns>
        public SfocCurveDetails Update(int id, SfocCurve sfocCurve)
        {
            var route = $"/api/v1/sfocCurves/{id}";
            return PutObject<SfocCurveDetails, SfocCurve>(sfocCurve, route);
        }

        /// <summary>
        /// Deletes a sfoc curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <returns>
        /// The deleted sfoc curve.
        /// </returns>
        public SfocCurveShort Delete(int id)
        {
            var route = $"/api/v1/sfocCurves/{id}";
            return DeleteObject<SfocCurveShort>(route);
        }
    }
}