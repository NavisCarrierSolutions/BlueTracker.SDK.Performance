using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Post;
using BlueTracker.SDK.Performance.DTO.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting, creating and updating tags.
    /// </summary>
    public class TagClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new TagClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token.
        /// </remarks>
        public TagClient(string authorization)
            : base(authorization)
        {
        }

        /// <summary>
        /// Creates a new TagClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public TagClient(string serverAddress, string authorization) 
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific tag.
        /// </summary>
        /// <param name="id">ID of the tag.</param>
        /// <returns>
        /// The tag.
        /// </returns>
        public Tag GetSpecific(int id)
        {
            var route = $"/api/v1/tags/{id}";
            var ret = GetObject<Tag>(route);
            return ret;
        }

        /// <summary>
        /// Returns a paged list of tags.
        /// </summary>
        /// <param name="page">Page of the result (default: 0).</param>
        /// <param name="pageSize">Size of the page (default: 20).</param>
        /// <returns>
        /// A paged list of tags.
        /// </returns>
        public PagedSearchResult<Tag> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/tags?page={page}&pageSize={pageSize}";
            var ret = GetObject<PagedSearchResult<Tag>>(route);
            return ret;
        }

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="tagData">The tag data for creation.</param>
        /// <returns>
        /// The newly created tag.
        /// </returns>
        public Tag Create(TagData tagData)
        {
            const string route = "/api/v1/tags";
            return PostObject<Tag, TagData>(tagData, route);
        }

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="id">ID identifying the tag.</param>
        /// <param name="tagData">The tag data for update.</param>
        /// <returns>
        /// The updated tag.
        /// </returns>
        public Tag Update(int id, TagData tagData)
        {
            var route = $"/api/v1/tags/{id}";
            return PutObject<Tag, TagData>(tagData, route);
        }

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="id">ID identifying the tag.</param>
        /// <returns>
        /// The deleted tag.
        /// </returns>
        public Tag Delete(int id)
        {
            var route = $"/api/v1/tags/{id}";
            return DeleteObject<Tag>(route);
        }

        /// <summary>
        /// Attaches a tag to a ship.
        /// </summary>
        /// <param name="id">ID of tag to be attached.</param>
        /// <param name="imoNumber">IMO number of ship.</param>
        /// <returns>The newly created association.</returns>
        public ShipTag TagShip(int id, int imoNumber)
        {
            var route = $"/api/v1/tags/{id}/ships/{imoNumber}";
            return PutObject<ShipTag, object>(null, route);
        }

        /// <summary>
        /// Detaches a tag from a ship.
        /// </summary>
        /// <param name="id">ID of the tag to be detached.</param>
        /// <param name="imoNumber">IMO number of ship.</param>
        /// <returns>The removed association.</returns>
        public ShipTag UntagShip(int id, int imoNumber)
        {
            var route = $"/api/v1/tags/{id}/ships/{imoNumber}";
            return DeleteObject<ShipTag>(route);
        }
    }
}