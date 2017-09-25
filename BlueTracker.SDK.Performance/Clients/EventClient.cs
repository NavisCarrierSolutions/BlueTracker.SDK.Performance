using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating event information.
    /// </summary>
    /// <remarks>
    /// An event is defined as a point in time some operational event of
    /// relevance occured (e.g. Begin of Sea Passage, Arrival etc.)
    /// </remarks>
    public class EventClient : ApiWrapper
    {
        /// <summary>
        /// Create a new EventClient instance.
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
        public EventClient(string serverAddress = null, string authorization = null)
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific event object.
        /// </summary>
        /// <param name="id">ID of the event.</param>
        /// <returns>The event object.</returns>
        public Event GetSpecific(int id)
        {
            var route = $"/api/v1/events/{id}";
            var ret = GetObject<Event>(route);

            return ret;
        }

        /// <summary>
        /// Returns a paged list of events (with an optional time range filter).
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of event objects for the specified IMO number within the specified time range.
        /// </returns>
        public PagedSearchResult<EventShort> GetAll(int imoNumber, DateTime? start = null, DateTime? end = null,
            int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var requestString =
                $"/api/v1/ships/{imoNumber}/events?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<EventShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Returns a paged list of event objects since a specific version stamp.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="sinceVersion">Version stamp to filter the events.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of event objects for the specified IMO number, which have a version stamp above
        /// the specified sinceVersion parameter.
        /// </returns>
        /// <remarks>
        /// Whenever a ship related entity (report, leg, voyage etc.) is created or modified, a version counter is increased.
        /// The new or modified entity remembers the version at that moment. This allows the API client to get all
        /// modified entities since the last query.
        /// </remarks>
        public PagedSearchResult<EventShort> GetSinceVersion(int imoNumber, long sinceVersion, int page = 0, int pageSize = 20)
        {
            var requestString =
                $"/api/v1/ships/{imoNumber}/events?sinceVersion={sinceVersion}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<EventShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Creates or updates an event.
        /// </summary>
        /// <param name="eventData">The detailed event object.</param>
        /// <returns>
        /// The newly created event.
        /// </returns>
        public Event CreateOrUpdate(EventData eventData)
        {
            return PostObject<Event, EventData>(eventData, "/api/v1/events");
        }

        /// <summary>
        /// Creates or updates multiple events.
        /// </summary>
        /// <param name="eventData">List of events to be updated or created.</param>
        /// <returns>
        /// The newly created or updated events.
        /// </returns>
        /// <remarks>
        /// Uploads of multiple items must refer to the same IMO number. The maximum number
        /// of items is 25. Further it is required to enable the batch mode for the ship.
        /// </remarks>
        public List<Event> CreateOrUpdate(List<EventData> eventData)
        {
            return PostObject<List<Event>, List<EventData>>(eventData, "/api/v1/events/batch");
        }
    }
}