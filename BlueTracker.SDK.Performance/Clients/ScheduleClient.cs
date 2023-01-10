using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.DTO.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Clients
{
    public class ScheduleClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ScheduleClient"/> client.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        public ScheduleClient(string authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Create a new <see cref="ScheduleClient"/> instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public ScheduleClient(string serverAddress, string authorization)
            : base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Get schedules for a particular ship.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to get schedules for.</param>
        /// <param name="start">Start date.</param>
        /// <param name="end">End date.</param>
        /// <param name="sinceShipVersion">Ship version stamp.</param>
        /// <param name="page">Page to get (defaults to 0).</param>
        /// <param name="pageSize">Page size (defaults to 20).</param>
        /// <returns></returns>
        public PagedSearchResult<Schedule> GetSchedules(int imoNumber,
            DateTime? start, DateTime? end, long? sinceShipVersion, int page = 0, int pageSize = 20)
        {
            if (start == null)
                start = DateTime.MinValue;

            if (end == null)
                end = DateTime.MaxValue;

            if (sinceShipVersion == null)
                sinceShipVersion = 0;

            var route = $"/api/v1/ships/{imoNumber}/schedules?sinceShipVersion={sinceShipVersion}&page={page}&pageSize={pageSize}&start={start:yyyy-MM-ddTHH:mm}&end={end:yyyy-MM-ddTHH:mm}";
            var result = GetObject<PagedSearchResult<Schedule>>(route);
            return result;
        }

        /// <summary>
        /// Adds a new schedule
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to add schedule for.</param>
        /// <param name="schedule">Schedule details.</param>
        /// <returns></returns>
        public Schedule AddSchedule(int imoNumber, DTO.Post.Schedule schedule)
        {
            return PostObject<Schedule, DTO.Post.Schedule>(schedule, $"/api/v1/ships/{imoNumber}/schedules");
        }

        /// <summary>
        /// Updates the schedule with the specified id.
        /// </summary>
        /// <param name="imo">IMO number of ship to update schedule for.</param>
        /// <param name="id">ID of schedule to update.</param>
        /// <param name="schedule">Schedule details.</param>
        /// <returns></returns>
        public Schedule UpdateSchedule(int imoNumber, int id, DTO.Post.Schedule schedule)
        {
            return PutObject<Schedule, DTO.Post.Schedule>(schedule, $"/api/v1/ships/{imoNumber}/schedules/{id}");
        }

        /// <summary>
        /// Updates the schedule with the specified custom id.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to update schedule for.</param>
        /// <param name="customId">Custom ID of schedule to update.</param>
        /// <param name="schedule">Schedule details.</param>
        /// <returns></returns>
        public Schedule UpdateScheduleByCustomId(int imoNumber, string customId, DTO.Post.Schedule schedule)
        {
            return PutObject<Schedule, DTO.Post.Schedule>(schedule, $"/api/v1/ships/{imoNumber}/schedules/{customId}/custom");
        }

        /// <summary>
        /// Deletes the schedule with the specified id.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to delete schedule for.</param>
        /// <param name="id">ID of schedule to delete.</param>
        /// <returns></returns>
        public Schedule DeleteScheduleAsync(int imoNumber, int id)
        {
            return DeleteObject<Schedule>($"/api/v1/ships/{imoNumber}/schedules/{id}");
        }

        /// <summary>
        /// Deleted the schedule with the specified custom id.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship to delete schedule for.</param>
        /// <param name="customId">Custom ID of schedule to delete.</param>
        /// <returns></returns>
        public Schedule DeleteScheduleByCustomIdAsync(int imoNumber, string customId)
        {
            return DeleteObject<Schedule>($"/api/v1/ships/{imoNumber}/schedules/{customId}/custom");
        }
    }
}
