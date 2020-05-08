using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Core
{
    /// <summary>
    /// Wrapper for a list of items with paging information.
    /// </summary>
    public class PagedSearchResult
    {
        /// <summary>
        /// Current page number.
        /// </summary>
        public int PageNo { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        public int TotalCount { get; set; }
    }

    /// <inheritdoc />
    public class PagedSearchResult<T> : PagedSearchResult
    {
        /// <summary>
        /// List of items of the current page.
        /// </summary>
        public List<T> Items { get; set; }

        /// <inheritdoc />
        public PagedSearchResult()
        {
            Items = new List<T>();
        }
    }
}
