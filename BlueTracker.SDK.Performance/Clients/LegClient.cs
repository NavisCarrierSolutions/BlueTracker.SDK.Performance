﻿using System;
using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Post;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// Client for getting, creating and updating leg information.
    /// </summary>
    /// <remarks>
    /// A leg is defined as the period between the departure of a port until
    /// the departure of the next port.
    /// </remarks>
    public class LegClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new LegClient instance.
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
        public LegClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets a specific leg object.
        /// </summary>
        /// <param name="id">ID of the leg.</param>
        /// <returns>The leg object.</returns>
        public Leg GetSpecific(int id)
        {
            var route = $"/api/v1/legs/{id}";
            var ret = GetObject<Leg>(route);
            return ret;
        }

        /// <summary>
        /// Gets the performance summary for a specific leg.
        /// </summary>
        /// <param name="id">ID of the leg.</param>
        /// <returns>The leg performance summary.</returns>
        public LegSummary GetSummary(int id)
        {
            var route = $"/api/v1/legs/{id}/summary";
            var ret = GetObject<LegSummary>(route);
            return ret;
        }

        /// <summary>
        /// Returns a paged list of legs (with an optional time range filter).
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="start">Start date and time for the query.</param>
        /// <param name="end">End date and time for the query.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of leg objects for the specified IMO number within the specified time range.
        /// </returns>
        /// <remarks>
        /// The time filter (start and end parameters) are compared against the departure time of
        /// the leg (beginning of the leg). The arrival time (end of the leg) is not considered.
        /// </remarks>
        public PagedSearchResult<LegShort> GetAll(int imoNumber, DateTime? start = null, DateTime? end = null, int page = 0,
            int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            var requestString =
                $"/api/v1/ships/{imoNumber}/legs?start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<LegShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Returns a paged list of leg objects since a specific version stamp.
        /// </summary>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <param name="sinceVersion">Version stamp to filter the legs.</param>
        /// <param name="page">The page number of the query. (Optional. Default: 0)</param>
        /// <param name="pageSize">The page size of the query. (Optional. Default: 20)</param>
        /// <returns>
        /// A paged list of leg objects for the specified IMO number, which have a version stamp above
        /// the specified sinceVersion parameter.
        /// </returns>
        /// <remarks>
        /// Whenever a ship related entity (report, leg, voyage etc.) is created or modified, a version counter is increased.
        /// The new or modified entity remembers the version at that moment. This allows the API client to get all
        /// modified entities since the last query.
        /// </remarks>
        public PagedSearchResult<LegShort> GetSinceVersion(int imoNumber, long sinceVersion, int page = 0, int pageSize = 20)
        {
            var requestString =
                $"/api/v1/ships/{imoNumber}/legs?sinceVersion={sinceVersion}&page={page}&pageSize={pageSize}";

            var result = GetObject<PagedSearchResult<LegShort>>(requestString);

            return result;
        }

        /// <summary>
        /// Returns the list of legs, which are associated with a specific voyage.
        /// </summary>
        /// <param name="voyageId">ID of the voyage.</param>
        /// <returns>
        /// A list of leg objects, which are associated with the specified voyage.
        /// </returns>
        public List<LegShort> GetAllForVoyage(int voyageId)
        {
            var route = $"/api/v1/voyages/{voyageId}/legs";
            return GetObject<List<LegShort>>(route);
        }

        /// <summary>
        /// Creates or updates a leg.
        /// </summary>
        /// <param name="legData">The detailed leg object.</param>
        /// <returns>
        /// The leg object returned from the service (including ID).
        /// </returns>
        public Leg CreateOrUpdate(LegData legData)
        {
            return PostObject<Leg, LegData>(legData, "/api/v1/legs");
        }
    }
}
