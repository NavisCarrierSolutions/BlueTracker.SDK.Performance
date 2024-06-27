using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;
using BlueTracker.SDK.Performance.Model.Enums;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Clients
{
    public class IssueClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="IssueClient"/> instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>The key BlueCloud_ApiKey is used to specify the API token.</remarks>
        public IssueClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="IssueClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.</remarks>
        public IssueClient(string serverAddress, string authorization) : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get report issues for a particular ship in a specified time range (maximum 180 days per request).
        /// </summary>
        /// <param name="imo">IMO number of ship to get issues for.</param>
        /// <param name="from">The beginning of the time range (inclusive). Expected to be in UTC.</param>
        /// <param name="to">The end of the time range (inclusive). Expected to be in UTC.</param>
        /// <param name="issueType">Issue type to filter by.</param>
        /// <returns></returns>
        public List<PerformanceReportIssueItem> GetIssuesForShip(int imo, DateTime from, DateTime to, IssueType issueType)
        {
            return GetObject<List<PerformanceReportIssueItem>>($"/api/v1/ships/{imo}/issues?from={from:yyyy-MM-ddTHH:mm}&to={to:yyyy-MM-ddTHH:mm}&issueType={issueType}");
        }
    }
}
