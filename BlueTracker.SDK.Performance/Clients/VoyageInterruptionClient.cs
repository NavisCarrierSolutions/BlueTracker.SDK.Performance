using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;
using System;

namespace BlueTracker.SDK.Performance.Clients
{
    public class VoyageInterruptionClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new instance of the <see cref="VoyageInterruptionClient"/> client.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        public VoyageInterruptionClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="VoyageInterruptionClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public VoyageInterruptionClient(string serverAddress, string authorization)
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get voyage interruptions for a particular ship.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to get voyage interruptions for.</param>
        /// <param name="start">Start date.</param>
        /// <param name="end">End date.</param>
        /// <param name="sinceShipVersion">Ship version stamp.</param>
        /// <param name="page">Page to get (defaults to 0).</param>
        /// <param name="pageSize">Page size (defaults to 20).</param>
        /// <returns></returns>
        public PagedSearchResult<VoyageInterruption> GetVoyageInterruptions(int imoNumber,
            DateTime? start, DateTime? end, long? sinceShipVersion, int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var route = $"/api/v1/ships/{imoNumber}/voyageInterruptions?page={page}&pageSize={pageSize}&start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}";

            if (sinceShipVersion != null)
            {
                route = $"/api/v1/ships/{imoNumber}/voyageInterruptions?sinceVersion={sinceShipVersion}&page={page}&pageSize={pageSize}";
            }

            var result = GetObject<PagedSearchResult<VoyageInterruption>>(route);
            return result;
        }

        /// <summary>
        /// Gets the voyage interruption with the specified id for the ship with the specified IMO number.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to get voyage interruption for.</param>
        /// <param name="voyageInterruptionId">Id of voyage interruption to get.</param>
        /// <returns></returns>
        public VoyageInterruption GetVoyageInterruptionById(int imoNumber, int voyageInterruptionId)
        {
            var route = $"/api/v1/ships/{imoNumber}/voyageInterruptions/{voyageInterruptionId}";

            var result = GetObject<VoyageInterruption>(route);
            return result;
        }

        /// <summary>
        /// Adds a new voyage interruption
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to add voyage interruption for.</param>
        /// <param name="voyageInterruption">Voyage interruption details.</param>
        /// <returns></returns>
        public VoyageInterruption AddVoyageInterruption(int imoNumber, DTO.Post.VoyageInterruption voyageInterruption)
        {
            return PostObject<VoyageInterruption, DTO.Post.VoyageInterruption>(voyageInterruption, $"/api/v1/ships/{imoNumber}/voyageInterruptions");
        }

        /// <summary>
        /// Updates the voyage interruption with the specified id.
        /// </summary>
        /// <param name="imo">IMO number of ship to update voyage interruption for.</param>
        /// <param name="id">ID of voyage interruption to update.</param>
        /// <param name="voyageInterruption">Voyage interruption details.</param>
        /// <returns></returns>
        public VoyageInterruption UpdateVoyageInterruption(int imoNumber, int id, DTO.Post.VoyageInterruption voyageInterruption)
        {
            return PutObject<VoyageInterruption, DTO.Post.VoyageInterruption>(voyageInterruption, $"/api/v1/ships/{imoNumber}/voyageInterruptions/{id}");
        }

        /// <summary>
        /// Deletes the voyage interruption with the specified id.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to delete voyage interruption for.</param>
        /// <param name="id">ID of voyage interruption to delete.</param>
        /// <returns></returns>
        public VoyageInterruption DeleteVoyageInterruptionAsync(int imoNumber, int id)
        {
            return DeleteObject<VoyageInterruption>($"/api/v1/ships/{imoNumber}/voyageInterruptions/{id}");
        }
    }
}
