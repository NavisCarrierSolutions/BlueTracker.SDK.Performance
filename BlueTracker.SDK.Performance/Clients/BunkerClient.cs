using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    public class BunkerClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="BunkerClient"/> instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public BunkerClient(string authorization) : base(authorization)
        {
        }
        /// <summary>
        /// Create a new <see cref="BunkerClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public BunkerClient(string serverAddress, string authorization) : base(serverAddress, authorization)
        {
        }

        public List<BunkerChargeDetail> GetBunkerData(int imoNumber, int? year = null)
        {
            var route = $"/api/v1/bunker/{imoNumber}";
            if (year.HasValue)
                route += $"?year={year.Value}";

            return GetObject<List<BunkerChargeDetail>>(route);
        }

    }
}
