using System;
using Newtonsoft.Json;

namespace BlueTracker.SDK.Performance.Core
{
    /// <inheritdoc />
    /// <summary>
    /// A date limited paged search result.
    /// </summary>
    /// <typeparam name="T">Type of items.</typeparam>
    public class DateLimitedSearchResult<T> : PagedSearchResult<T>
    {
        /// <summary>
        /// Start date of filter range.
        /// </summary>
        [JsonProperty(Order = 1)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of filter range.
        /// </summary>
        [JsonProperty(Order = 1)]
        public DateTime? EndDate { get; set; }
    }
}