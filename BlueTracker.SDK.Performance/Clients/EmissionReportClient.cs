using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Clients
{
    public class EmissionReportClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EmissionReportClient"/> client.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        public EmissionReportClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="EmissionReportClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public EmissionReportClient(string serverAddress, string authorization)
            : base(serverAddress, authorization)
        {
        }

        public List<MrvAnnualReport> GetMrvEmissionReports(int year, int[] shipImos, bool showEea)
        {
            var requestString = $"/api/v1/emissionReports/mrv/{year}";
            string queryString = GetQueryString(shipImos);
            var param = queryString.Length == 0 ? "?" : "&";

            return GetObject<List<MrvAnnualReport>>($"{requestString}{queryString}{param}showEea={showEea}");
        }

        private static string GetQueryString(int[] shipImos)
        {
            var queryString = new StringBuilder();

            foreach (var imo in shipImos)
            {
                var param = queryString.Length == 0 ? "?" : "&";
                queryString.AppendFormat("{0}shipImos={1}", param, imo);
            }

            return queryString.ToString();
        }
    }
}
