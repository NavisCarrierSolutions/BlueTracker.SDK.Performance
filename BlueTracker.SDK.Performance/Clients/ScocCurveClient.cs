using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating scoc curves.
    /// </summary>
    public class ScocCurveClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ScocCurveClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public ScocCurveClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new ScocCurveClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ScocCurveClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific scoc curve.
        /// </summary>
        /// <param name="id">ID of the scoc curve.</param>
        /// <returns>
        /// The scoc curve.
        /// </returns>
        public ScocCurve GetSpecific(int id)
        {
            var route = $"/api/v1/scocCurves/{id}";
            var result = GetObject<ScocCurve>(route);
            return result;
        }

        /// <summary>
        /// Returns a paged list of scoc curves metadata.
        /// </summary>
        /// <param name="page">Page of the result (default: 0).</param>
        /// <param name="pageSize">Size of the page (default: 20).</param>
        /// <returns>
        /// A paged list of scoc curves metadata.
        /// </returns>
        public PagedSearchResult<ScocCurveShort> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/scocCurves?page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<ScocCurveShort>>(route);
            return result;
        }

        /// <summary>
        /// Create a scoc curve model.
        /// </summary>
        /// <param name="scocCurve">The detailed scoc curve.</param>
        /// <returns>
        /// The newly created scoc curve.
        /// </returns>
        public ScocCurve Create(ScocCurveData scocCurve)
        {
            const string route = "/api/v1/scocCurves";
            return PostObject<ScocCurve, ScocCurveData>(scocCurve, route);
        }

        /// <summary>
        /// Update a scoc curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <param name="scocCurve">The detailed scoc curve.</param>
        /// <returns>
        /// The updated scoc curve.
        /// </returns>
        public ScocCurve Update(int id, ScocCurveData scocCurve)
        {
            var route = $"/api/v1/scocCurves/{id}";
            return PutObject<ScocCurve, ScocCurveData>(scocCurve, route);
        }

        /// <summary>
        /// Deletes a scoc curve.
        /// </summary>
        /// <param name="id">ID identifying the model.</param>
        /// <returns>
        /// The deleted scoc curve.
        /// </returns>
        public ScocCurveShort Delete(int id)
        {
            var route = $"/api/v1/scocCurves/{id}";
            return DeleteObject<ScocCurveShort>(route);
        }
    }
}
