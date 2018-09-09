using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

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
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public SfocCurveClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new SfocCurveClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
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
        public SfocCurve GetSpecific(int id)
        {
            var route = $"/api/v1/sfocCurves/{id}";
            var result = GetObject<SfocCurve>(route);
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
        public SfocCurve Create(SfocCurveData sfocCurve)
        {
            const string route = "/api/v1/sfocCurves";
            return PostObject<SfocCurve, SfocCurveData>(sfocCurve, route);
        }

        /// <summary>
        /// Update a sfoc curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <param name="sfocCurve">The detailed sfoc curve.</param>
        /// <returns>
        /// The updated sfoc curve.
        /// </returns>
        public SfocCurve Update(int id, SfocCurveData sfocCurve)
        {
            var route = $"/api/v1/sfocCurves/{id}";
            return PutObject<SfocCurve, SfocCurveData>(sfocCurve, route);
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