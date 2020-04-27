using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;
using BlueTracker.SDK.Performance.Model.Enums;
using BlueTracker.SDK.Performance.Model.Processing.Report;
using Newtonsoft.Json.Linq;
using PerformanceReport = BlueTracker.SDK.Performance.DTO.Query.PerformanceReport;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating performance reports.
    /// </summary>
    public class ReportClient : ApiWrapper
    {
        /// <summary>
        /// Create a new ReportClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public ReportClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Create a new ReportClient intance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ReportClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get the metadata of a single report.
        /// </summary>
        /// <param name="id">ID of the report.</param>
        /// <returns>The report metadata object.</returns>
        public PerformanceReport GetSpecific(int id)
        {
            var reqString = $"/api/v1/reports/{id}";
            var ret = GetObject<PerformanceReport>(reqString);
            return ret;
        }

        /// <summary>
        /// Returns a paged list of report metadata objects (with an optional time range filter).
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A list of report metadata objects for the specified IMO number within the specified time range.
        /// </returns>
        public PagedSearchResult<PerformanceReportShort> GetAll(int imoNumber, DateTime? start = null, DateTime? end = null,
            int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var reqString = $"/api/v1/ships/{imoNumber}/reports?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<PerformanceReportShort>>(reqString);

            return result;
        }

        /// <summary>
        /// Return a paged list of report metadata objects since a specific version stamp.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="sinceVersion">Version stamp to filter the reports.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of report metadata objects for the specified IMO number, which have a version stamp above
        /// the specified sinceVersion parameter.
        /// </returns>
        /// <remarks>
        /// Whenever a ship related entity (report, leg, voyage etc.) is created or modified, a version counter is increased.
        /// The new or modified entity remembers the version at that moment. This allows the API client to get all
        /// modified entities since the last query.
        /// </remarks>
        public PagedSearchResult<PerformanceReportShort> GetSinceVersion(int imoNumber, long sinceVersion, int page = 0, int pageSize = 20)
        {
            var reqString = $"/api/v1/ships/{imoNumber}/reports?sinceVersion={sinceVersion}&page={page}&pageSize={pageSize}";
            var result = GetObject<PagedSearchResult<PerformanceReportShort>>(reqString);

            return result;
        }

        /// <summary>
        /// Return the list of reports, which are associated with a specific leg.
        /// </summary>
        /// <param name="legId">ID of the leg.</param>
        /// <returns>
        /// A list of report metadata objects, which are associated with the specified leg.
        /// </returns>
        public List<PerformanceReportShort> GetAllForLeg(int legId)
        {
            var reqString = $"/api/v1/legs/{legId}/reports";
            var ret = GetObject<List<PerformanceReportShort>>(reqString);
            return ret;
        }

        /// <summary>
        /// Get the original report.
        /// </summary>
        /// <param name="reportId">ID of the report.</param>
        /// <returns>The detailed report object.</returns>
        public Model.Basic.Report.PerformanceReport GetOriginal(int reportId)
        {
            var route = $"/api/v1/reports/{reportId}/original";
            var ret = GetObject<Model.Basic.Report.PerformanceReport>(route);
            return ret;
        }

        /// <summary>
        /// Get the complete and processed report.
        /// </summary>
        /// <param name="reportId">ID of the report.</param>
        /// <returns>
        /// A JSON object, which represents the fully processed report details.
        /// </returns>
        public PerformanceReportDetails GetResult(int reportId)
        {
            var route = $"/api/v1/reports/{reportId}/result";
            var ret = GetObject<PerformanceReportDetails>(route);
            return ret;
        }

        /// <summary>
        /// Gets the performance summary for a specific report.
        /// </summary>
        /// <param name="reportId">ID of the report.</param>
        /// <returns>The report performance summary.</returns>
        public PerformanceReportSummary GetSummary(int reportId)
        {
            var route = $"/api/v1/reports/{reportId}/summary";
            var ret = GetObject<PerformanceReportSummary>(route);
            return ret;
        }

        /// <summary>
        /// Creates or updates a report.
        /// </summary>
        /// <param name="report">The detailed report object.</param>
        /// <returns>
        /// The report metadata object which was created for the report.
        /// </returns>
        public PerformanceReport CreateOrUpdate(Model.Basic.Report.PerformanceReport report)
        {
            return PostObject<PerformanceReport, Model.Basic.Report.PerformanceReport>(report, "/api/v1/reports");
        }

        /// <summary>
        /// Creates or updates multiple reports.
        /// </summary>
        /// <param name="reports">List of reports to be updated or created.</param>
        /// <returns>
        /// The newly created or updated reports.
        /// </returns>
        /// <remarks>
        /// Uploads of multiple items must refer to the same IMO number. The maximum number
        /// of items is 25. Further it is required to enable the batch mode for the ship.
        /// </remarks>
        public List<PerformanceReport> CreateOrUpdate(List<Model.Basic.Report.PerformanceReport> reports)
        {
            return PostObject<List<PerformanceReport>, List<Model.Basic.Report.PerformanceReport>>(reports, "/api/v1/reports/batch");
        }

        /// <summary>
        /// Gets an Report by customId and imoNumber.
        /// </summary>
        /// <param name="customId">Custom Id of an report</param>
        /// <param name="imoNumber"></param>
        /// <returns>The performance report.</returns>
        public PerformanceReport GetPerformanceReportByCustomId(string customId, int imoNumber)
        {
            var uri = $"/api/v1/reports/{customId}/{imoNumber}";
            return GetObject<PerformanceReport>(uri);
        }

        /// <summary>
        /// Deletes the performance report with the specified id.
        /// </summary>
        /// <param name="reportId">ID identifying the performance report.</param>
        /// <returns>
        /// The deleted performance report.
        /// </returns>
        public PerformanceReport Delete(int reportId)
        {
            var route = $"/api/v1/reports/{reportId}";
            return DeleteObject<PerformanceReport>(route);
        }

        /// <summary>
        /// Enables or disables the batch mode of the ships data interface.
        /// </summary>
        /// <param name="imoNumber">IMO number of the vessel.</param>
        /// <param name="enableBatchMode">True to enable batch mode; false to disable batch mode.</param>
        /// <returns>The ship object.</returns>
        /// <remarks>
        /// When batch mode is enabled, data items pushed to the vessel do not trigger an immediate re-calculation.
        /// This is useful, if big amounts of items needs to be pushed. When the batch mode is disabled, a full
        /// re-calculation is triggered.
        /// </remarks>
        public Ship SetBatchMode(int imoNumber, bool enableBatchMode)
        {
            var route = $"/api/v1/ships/{imoNumber}/batchMode";
            return PostObject<Ship, bool>(enableBatchMode, route);
        }

        /// <summary>
        /// Triggers a re-calculation of the ship model.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <returns>The ship object.</returns>
        /// <remarks>
        /// Calling this method, will put the ship to <see cref="FeedState.Pending"/> mode, and a re-calulcation
        /// job is queued. The method call will then return. During execution of the re-calculation job, the ships
        /// feed state will be set to <see cref="FeedState.Calculation"/>. When the job is done, the ship feed 
        /// state will be set back to <see cref="FeedState.Online"/>.
        /// </remarks>
        public Ship Calculate(int imoNumber)
        {
            var route = $"/api/v1/ships/{imoNumber}/batchMode";
            return PostEmpty<Ship>(route);
        }
    }
}
