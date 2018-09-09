using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

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
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey
        /// is used to specify the API token.
        /// </remarks>
        public ConsumptionCurveClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new ConsumptionCurveClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey
        /// is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ConsumptionCurveClient(string serverAddress, string authorization) :
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
        public ConsumptionCurve GetSpecific(int id)
        {
            var route = $"/api/v1/consumptionCurves/{id}";
            var result = GetObject<ConsumptionCurve>(route);
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
        public PagedSearchResult<ConsumptionCurveShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/consumptionCurves?page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<ConsumptionCurveShort>>(route);
            return result;
        }

        /// <summary>
        /// Create a consumption curve.
        /// </summary>
        /// <param name="consumptionCurve">The detailed consumption curve.</param>
        /// <returns>
        /// The newly created consumption curve.
        /// </returns>
        public ConsumptionCurve Create(ConsumptionCurveData consumptionCurve)
        {
            const string route = "/api/v1/consumptionCurves";
            return PostObject<ConsumptionCurve, ConsumptionCurveData>(consumptionCurve, route);
        }

        /// <summary>
        /// Update a consumption curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <param name="consumptionCurve">The detailed consumption curve.</param>
        /// <returns>
        /// The updated consumption curve.
        /// </returns>
        public ConsumptionCurve Update(int id, ConsumptionCurveData consumptionCurve)
        {
            var route = $"/api/v1/consumptionCurves/{id}";
            return PutObject<ConsumptionCurve, ConsumptionCurveData>(consumptionCurve, route);
        }

        /// <summary>
        /// Deletes a consumption curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <returns>
        /// The deleted consumption curve.
        /// </returns>
        public ConsumptionCurveShort Delete(int id)
        {
            var route = $"/api/v1/consumptionCurves/{id}";
            return DeleteObject<ConsumptionCurveShort>(route);
        }
    }
}