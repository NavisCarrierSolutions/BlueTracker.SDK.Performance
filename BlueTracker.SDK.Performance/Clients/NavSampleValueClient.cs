using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting and creating nav samples.
    /// </summary>
    public class NavSampleValueClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new <see cref="NavSampleValueClient"/> instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        public NavSampleValueClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Creates a new <see cref="NavSampleValueClient"/> instance.
        /// </summary>
        /// <param name="serverAddress"></param>
        /// <param name="authorization"></param>
        public NavSampleValueClient(string serverAddress, string authorization) : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets the nav sample for the specified source, imo and report.
        /// </summary>
        /// <param name="sourceName">Name of the nav sample source.</param>
        /// <param name="imoNumber">IMO number of ship to get nav sample for.</param>
        /// <param name="customId">Custom ID.</param>
        /// <returns>The nav sample object.</returns>
        public NavSample GetSpecific(string sourceName, int imoNumber, int customId)
        {
            var reqString = $"/api/v1/ships/{imoNumber}/navSamples/{sourceName}/{customId}";
            var ret = GetObject<NavSample>(reqString);
            return ret;
        }

        /// <summary>
        ///  Gets a <see cref="DateLimitedSearchResult{T}"/> list of <see cref="NavSample"/>s
        /// filtered by a time range for the nav sample source with the specified ID.
        /// </summary>
        /// <param name="sourceId">ID of the nav sample source.</param>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 100)</param>
        /// <returns></returns>
        public DateLimitedSearchResult<NavSample> GetAllBySourceId(int sourceId, int imoNumber,
            DateTime start, DateTime end, int page = 0, int pageSize = 100)
        {
            var reqString = $"/api/v1/ships/{imoNumber}/navSamples/{sourceId}?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";

            var ret = GetObject<DateLimitedSearchResult<NavSample>>(reqString);
            return ret;
        }

        /// <summary>
        /// Gets a <see cref="DateLimitedSearchResult{T}"/> list of <see cref="NavSample"/>s
        /// filtered by a time range for the nav sample source with the specified name.
        /// </summary>
        /// <param name="sourceName">Name of the nav sample source.</param>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 100)</param>
        /// <returns></returns>
        public DateLimitedSearchResult<NavSample> GetAllBySourceName(string sourceName, int imoNumber,
            DateTime start, DateTime end, int page = 0, int pageSize = 100)
        {
            var reqString = $"/api/v1/ships/{imoNumber}/navSamples/{sourceName}?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";

            var ret = GetObject<DateLimitedSearchResult<NavSample>>(reqString);
            return ret;
        }

        /// <summary>
        /// Creates new nav samples.
        /// </summary>
        /// <param name="sourceName">Name of source to create nav samples for.</param>
        /// <param name="imoNumber">IMO of ship to create nav sample for.</param>
        /// <param name="navSampleData">List of nav samples to create.</param>
        /// <returns></returns>
        public int Create(string sourceName, int imoNumber, List<NavSampleData> navSampleData)
        {
            return PostObject<int, List<NavSampleData>>(navSampleData, $"/api/v1/ships/{imoNumber}/navSamples/{sourceName}");
        }

        /// <summary>
        /// Deletes the nav sample with the specified custom ID of the specified source for the ship with the specified IMO.
        /// </summary>
        /// <param name="sourceName">Name of the nav sample source.</param>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="customId">Custom ID.</param>
        /// <returns></returns>
        public NavSample Delete(string sourceName, int imoNumber, int customId)
        {
            var reqString = $"/api/v1/ships/{imoNumber}/navSamples/{sourceName}/{customId}";
            return DeleteObject<NavSample>(reqString);
        }

    }
}
