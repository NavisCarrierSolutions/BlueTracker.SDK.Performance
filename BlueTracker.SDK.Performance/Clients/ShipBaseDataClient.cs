using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating base data of ships.
    /// </summary>
    public class ShipBaseDataClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ShipBaseDataClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public ShipBaseDataClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new ShipBaseDataClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ShipBaseDataClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get all ship base data definitions for a specific ship (by IMO number).
        /// </summary>
        /// <param name="imoNumber">7-digit IMO-number of ship.</param>
        /// <returns>A list of ship base data definitions.</returns>
        public IList<ShipBaseDataShort> GetAll(int imoNumber)
        {
            var requestString = $"/api/v1/ships/{imoNumber}/baseData";

            var result = GetObject<List<ShipBaseDataShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Create or update a ship base data definition.
        /// </summary>
        /// <param name="imoNumber">7-digit IMO-number of ship.</param>
        /// <param name="baseData">Base data definition.</param>
        /// <param name="effectiveFrom">Timestamp from which the definition is effective.</param>
        /// <returns>The newly created or updated definition.</returns>
        public ShipBaseData CreateOrUpdate(int imoNumber, Model.Basic.Ship.Ship baseData, DateTime? effectiveFrom = null)
        {
            var requestString = $"/api/v1/ships/{imoNumber}/baseData";

            if (effectiveFrom != null)
            {
                requestString = $"{requestString}?effectiveFrom={effectiveFrom:yyyy-MM-ddTHH:mm}";
            }

            var result = PostObject<ShipBaseData, Model.Basic.Ship.Ship>(baseData, requestString);

            return result;
        }

        /// <summary>
        /// Get ship base data definitions effective at a specific timestamp.
        /// </summary>
        /// <param name="imoNumber">7-digit IMO-number of ship.</param>
        /// <param name="effectiveOn">Effective date and time.</param>
        /// <returns>A ship base data definition.</returns>
        public Model.Basic.Ship.Ship GetByDate(int imoNumber, DateTime effectiveOn)
        {
            var requestString = $"/api/v1/ships/{imoNumber}/baseData/{effectiveOn:yyyy-MM-ddTHH:mm}";

            var result = GetObject<Model.Basic.Ship.Ship>(requestString);

            return result;
        }

        /// <summary>
        /// Get a specific ship base data definition.
        /// </summary>
        /// <param name="imoNumber">7-digit IMO-number of ship.</param>
        /// <param name="id">ID identifying the ship base data definition.</param>
        /// <returns>A ship base data definition.</returns>
        public ShipBaseData GetById(int imoNumber, int id)
        {
            var requestString = $"/api/v1/ships/{imoNumber}/baseData/{id}";

            var result = GetObject<ShipBaseData>(requestString);

            return result;
        }

        /// <summary>
        /// Update a ship base data definition.
        /// </summary>
        /// <param name="id">ID identifying the ship base data definition.</param>
        /// <param name="imoNumber">7-digit IMO-number of ship.</param>
        /// <param name="baseData">Base data definition.</param>
        /// <param name="effectiveFrom">Timestamp from which the definition is effective.</param>
        /// <returns>The updated definition.</returns>
        public ShipBaseData Update(int id, int imoNumber, ShipBaseData baseData, DateTime? effectiveFrom = null)
        {
            var requestString = $"/api/v1/ships/{imoNumber}/baseData/{id}";
            if (effectiveFrom != null)
            {
                requestString = $"{requestString}?effectiveFrom={effectiveFrom:yyyy-MM-ddTHH:mm}";
            }
            var result = PostObject<ShipBaseData, ShipBaseData>(baseData, requestString);

            return result;
        }
    }
}
