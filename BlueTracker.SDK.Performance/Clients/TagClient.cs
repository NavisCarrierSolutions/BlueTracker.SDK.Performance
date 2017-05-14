using BlueTracker.SDK.Performance.Core;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating tags.
    /// </summary>
    public class TagClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new TagClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// Instead of specifying the server address and the API token with constructur parameters,
        /// they can be set in the appSettings section of the app.config. The key BlueCloud_ApiKey
        /// is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is neither specified as constructor parameter,
        /// nor in the app settings, the default service address will be used.
        /// </remarks>
        public TagClient(string serverAddress = null, string authorization = null) 
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
        public Query.Tag GetSpecific(int id)
        {
            var route = $"/api/v1/tags/{id}";
            var ret = GetObject<Query.Tag>(route);
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
        public PagedSearchResult<Query.Tag> GetAll(int page = 0, int pageSize = 20)
        {
            var route = $"/api/v1/tags?page={page}&pageSize={pageSize}";
            var ret = GetObject<PagedSearchResult<Query.Tag>>(route);
            return ret;
        }

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="tagData">The tag data for creation.</param>
        /// <returns>
        /// The newly created tag.
        /// </returns>
        public Query.Tag Create(Post.TagData tagData)
        {
            const string route = "/api/v1/tags";
            return PostObject<Query.Tag, Post.TagData>(tagData, route);
        }

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="id">ID identifying the tag.</param>
        /// <param name="tagData">The tag data for update.</param>
        /// <returns>
        /// The updated tag.
        /// </returns>
        public Query.Tag Update(int id, Post.TagData tagData)
        {
            var route = $"/api/v1/tags/{id}";
            return PutObject<Query.Tag, Post.TagData>(tagData, route);
        }

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="id">ID identifying the tag.</param>
        /// <returns>
        /// The deleted tag.
        /// </returns>
        public Query.Tag Delete(int id)
        {
            var route = $"/api/v1/tags/{id}";
            return DeleteObject<Query.Tag>(route);
        }

        /// <summary>
        /// Attaches a tag to a ship.
        /// </summary>
        /// <param name="id">ID of tag to be attached.</param>
        /// <param name="imoNumber">IMO number of ship.</param>
        /// <returns>The newly created association.</returns>
        public Query.ShipTag TagShip(int id, int imoNumber)
        {
            var route = $"/api/v1/tags/{id}/ships/{imoNumber}";
            return PutObject<Query.ShipTag, object>(null, route);
        }

        /// <summary>
        /// Detaches a tag from a ship.
        /// </summary>
        /// <param name="id">ID of the tag to be detached.</param>
        /// <param name="imoNumber">IMO number of ship.</param>
        /// <returns>The removed association.</returns>
        public Query.ShipTag UntagShip(int id, int imoNumber)
        {
            var route = $"/api/v1/tags/{id}/ships/{imoNumber}";
            return DeleteObject<Query.ShipTag>(route);
        }
    }
}