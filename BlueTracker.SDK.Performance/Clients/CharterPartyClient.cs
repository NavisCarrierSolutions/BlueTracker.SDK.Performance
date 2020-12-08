using System;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;
using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Clients
{
    public class CharterPartyClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="CharterPartyClient"/> instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public CharterPartyClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="CharterPartyClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public CharterPartyClient(string serverAddress, string authorization) : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific charter party object.
        /// </summary>
        /// <param name="id">ID of the charter party to retrieve.</param>
        /// <returns>The retrieved charter party object.</returns>
        public CharterParty GetSpecific(int id)
        {
            var route = $"/api/v1/charterParties/{id}";
            var ret = GetObject<CharterParty>(route);

            return ret;
        }

        /// <summary>
        /// Returns a paged list of charter parties (with an optional time range- and state-filter).
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="state">State for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of charter party objects for the specified IMO number within the specified time range.
        /// </returns>
        public PagedSearchResult<CharterPartyShort> GetAll(int imoNumber, DateTime? start = null, DateTime? end = null, 
            CharterPartyState? state = null, int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var requestString =
                $"/api/v1/ships/{imoNumber}/charterParties?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&state={(int?)state}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<CharterPartyShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Creates a charter party.
        /// </summary>
        /// <param name="charterPartyData">The detailed charter party object.</param>
        /// <returns>
        /// The newly created charter party.
        /// </returns>
        public CharterParty Create(CharterPartyData charterPartyData)
        {
            return PostObject<CharterParty, CharterPartyData>(charterPartyData, "/api/v1/charterParties");
        }

        /// <summary>
        /// Updates the charter party with the specified id.
        /// </summary>
        /// <param name="id">Id of charter party to update.</param>
        /// <param name="charterPartyData">The detailed hull event object.</param>
        /// <returns>
        /// The updated charter party.
        /// </returns>
        public CharterParty Update(int id, CharterPartyData charterPartyData)
        {
            return PutObject<CharterParty, CharterPartyData>(charterPartyData, $"/api/v1/charterParties/{id}");
        }
    }
}
