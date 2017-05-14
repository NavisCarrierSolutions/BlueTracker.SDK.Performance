using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.Core
{
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
        /// Total number of itmes.
        /// </summary>
        public int TotalCount { get; set; }
    }

    public class PagedSearchResult<T> : PagedSearchResult
    {
        /// <summary>
        /// List of items of the current page.
        /// </summary>
        public List<T> Items { get; set; }

        public PagedSearchResult()
        {
            Items = new List<T>();
        }
    }
}
