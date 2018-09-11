using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating owner information.
    /// </summary>
    public class OwnerClient : ApiWrapper
    {
        /// <summary>
        /// Create a new <see cref="OwnerClient"/> class.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public OwnerClient(string authorization)
            : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="OwnerClient"/> class.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public OwnerClient(string serverAddress, string authorization)
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific owner object.
        /// </summary>
        /// <param name="id">ID of the owner to retrieve.</param>
        /// <returns>The retrieved owner object.</returns>
        public Owner GetSpecific(int id)
        {
            var route = $"/api/v1/owners/{id}";
            var ret = GetObject<Owner>(route);

            return ret;
        }

        /// <summary>
        /// Returns a paged list of owners.
        /// </summary>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of owner objects for the company.
        /// </returns>
        public PagedSearchResult<OwnerShort> GetAll(int page = 0, int pageSize = 20)
        {
            var requestString = $"/api/v1/owners/?page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<OwnerShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Creates or updates an owner.
        /// </summary>
        /// <param name="ownerData">The detailed owner object.</param>
        /// <returns>
        /// The newly created or updated owner.
        /// </returns>
        public Owner CreateOrUpdate(OwnerData ownerData)
        {
            return PostObject<Owner, OwnerData>(ownerData, "/api/v1/owners");
        }

        /// <summary>
        /// Updates the owner with the specified id.
        /// </summary>
        /// <param name="id">Id of owner to update.</param>
        /// <param name="ownerData">The detailed owner object.</param>
        /// <returns>
        /// The updated owner.
        /// </returns>
        public Owner Update(int id, OwnerData ownerData)
        {
            return PutObject<Owner, OwnerData>(ownerData, $"/api/v1/owners/{id}");
        }

        /// <summary>
        /// Deletes an owner.
        /// </summary>
        /// <param name="id">ID identifying the owner.</param>
        /// <returns>
        /// The deleted owner.
        /// </returns>
        public Owner Delete(int id)
        {
            var route = $"/api/v1/owners/{id}";
            return DeleteObject<Owner>(route);
        }
    }
}
