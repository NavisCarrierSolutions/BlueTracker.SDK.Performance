using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;
using System;
using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Clients
{
    public class SeaCargoCharterClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="SeaCargoCharterClient"/> instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>The key BlueCloud_ApiKey is used to specify the API token.</remarks>
        public SeaCargoCharterClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="SeaCargoCharterClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.</remarks>
        public SeaCargoCharterClient(string serverAddress, string authorization) : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets the cargo parcels for the ship with the specified IMO number in the specified time range.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to get cargo parcels for.</param>
        /// <param name="startDate">Start of time range.</param>
        /// <param name="endDate">End of time range.</param>
        /// <returns></returns>^^
        public List<CargoParcel> GetCargoParcelsForShip(int imoNumber, DateTime startDate, DateTime endDate)
        {
            return GetObject<List<CargoParcel>>($"/api/v1/seaCargoCharter/ships/{imoNumber}/cargoParcels?startDate={startDate:yyyy-MM-ddTHH:mm}&endDate={endDate:yyyy-MM-ddTHH:mm}");
        }

        /// <summary>
        /// Gets the voyages with cargo parcels for the specified charterer in the specified time range.
        /// </summary>
        /// <param name="startDate">Start of time range.</param>
        /// <param name="endDate">End of time range.</param>
        /// <param name="chartererId">Custom ID of charterer.</param>
        /// <param name="chartererName">Name of charterer.</param>
        /// <returns></returns>
        public List<VoyageWithCargoParcels> GetVoyages(DateTime startDate, DateTime endDate, string chartererId, string chartererName)
        {
            return GetObject<List<VoyageWithCargoParcels>>($"/api/v1/seaCargoCharter/voyages?startDate={startDate:yyyy-MM-ddTHH:mm}&endDate={endDate:yyyy-MM-ddTHH:mm}&chartererId={chartererId}&chartererName={chartererName}");
        }

        /// <summary>
        /// Gets the voyage emission split for the specified voyage and the specified charterer.
        /// </summary>
        /// <param name="voyageId">ID of voyage.</param>
        /// <param name="chartererId">Custom ID of charterer.</param>
        /// <param name="chartererName">Name of charterer.</param>
        /// <returns></returns>
        public ChartererVoyageEmissionSplit GetVoyageEmissionSplit(int voyageId, string chartererId, string chartererName)
        {
            return GetObject<ChartererVoyageEmissionSplit>($"/api/v1/seaCargoCharter/voyages/{voyageId}/split?chartererId={chartererId}&chartererName={chartererName}");
        }
    }
}
