using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating base data of ship classes.
    /// </summary>
    public class ShipClassBaseDataClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new ShipClassBaseDataClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public ShipClassBaseDataClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new ShipClassBaseDataClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ShipClassBaseDataClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets base data for a specific ship class.
        /// </summary>
        /// <param name="id">ID of ship class.</param>
        /// <returns>
        /// The base data.
        /// </returns>
        public ShipClassBaseData GetSpecific(int id)
        {
            var route = $"/api/v1/shipClasses/{id}/baseData";
            var ret = GetObject<ShipClassBaseData>(route);
            return ret;
        }

        /// <summary>
        /// Creates or udpates base data for a specific ship class.
        /// </summary>
        /// <param name="id">Id of ship class.</param>
        /// <param name="shipClassBaseData">The detailed ship class base data object.</param>
        /// <returns>
        /// The newly created or updated base data object.
        /// </returns>
        public ShipClassBaseData CreateOrUpdate(int id, Model.Basic.Ship.Ship shipClassBaseData)
        {
            var route = $"/api/v1/shipClasses/{id}/baseData";
            var ret = PostObject<ShipClassBaseData, Model.Basic.Ship.Ship>(shipClassBaseData, route);
            return ret;
        }

        /// <summary>
        /// Delete a ship class base data definition.
        /// </summary>
        /// <param name="id">ID of ship class.</param>
        /// <returns>
        /// The deleted ship class base data definition.
        /// </returns>
        public ShipClassBaseData Delete(int id)
        {
            var route = $"/api/v1/shipClasses/{id}/baseData";
            var ret = DeleteObject<ShipClassBaseData>(route);
            return ret;
        }
    }
}
