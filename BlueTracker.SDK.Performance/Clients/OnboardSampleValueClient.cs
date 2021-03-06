﻿using System;
using System.Collections.Generic;
using System.Linq;
using BlueTracker.SDK.Performance.Core;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for posting and querying onboard sample values.
    /// </summary>
    public class OnboardSampleValueClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new SampleClient instance.
        /// </summary>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token. 
        /// </remarks>
        public OnboardSampleValueClient(string authorization) :
            base(authorization)
        {
        }

        /// <summary>
        /// Creates a new SampleClient instance.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="authorization">The API token.</param>
        /// <remarks>
        /// The key BlueCloud_ApiKey is used to specify the API token, the key BlueCloud_ServerAddress is used to set the
        /// service address. If the service address is not specified as constructor parameter,
        /// the default service address will be used.
        /// </remarks>
        public OnboardSampleValueClient(string serverAddress, string authorization) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Posts a list of onboard sample to a named sample source for a specfic ship.
        /// </summary>
        /// <param name="samples">Sample data to post.</param>
        /// <param name="sourceName">Name of the sample source.</param>
        /// <param name="imoNumber">IMO number of the ship.</param>
        /// <returns>The count of data posted</returns>
        public int PostSample(string sourceName, int imoNumber, params Model.Basic.Sample.Sample[] samples)
        {
            return PostObject<int, List<Model.Basic.Sample.Sample>>(samples.ToList(),
                $"api/v1/onboardSamples/sources/{sourceName}/{imoNumber}");
        }

        /// <summary>
        /// Query a range of samples for a specific ship across all assigned sample sources for a given time range.
        /// </summary>
        /// <param name="imoNumber">IMO number of ship.</param>
        /// <param name="start">Start time of query</param>
        /// <param name="end">End time of query</param>
        /// <returns>Query result with samples.</returns>
        public List<Model.Basic.Sample.Sample> Query(int imoNumber, DateTime? start = null, DateTime? end = null)
        {
            var url = $"api/v1/onboardSamples/{imoNumber}";

            if (start != null && end != null)
                url += $"?start={start:O}&end={end:O}";
            else if (start != null)
                url += $"?start={start:O}";
            else if (end != null)
                url += $"?end={end:O}";

            return GetObject<List<Model.Basic.Sample.Sample>>(url);
        }

        /// <summary>
        /// Query a range of samples for a ship from a specific sample source.
        /// </summary>
        /// <param name="sourceName">Name of sample source.</param>
        /// <param name="imoNumber">IMO number of ship.</param>
        /// <param name="start">Start time of query</param>
        /// <param name="end">End time of query</param>
        /// <returns>Query result with samples.</returns>
        public List<Model.Basic.Sample.Sample> QueryBySource(string sourceName, int imoNumber, DateTime? start = null, DateTime? end = null)
        {
            var url = $"api/v1/onboardSamples/sources/{sourceName}/{imoNumber}";

            if (start != null && end != null)
                url += $"?start={start:O}&end={end:O}";
            else if (start != null)
                url += $"?start={start:O}";
            else if (end != null)
                url += $"?end={end:O}";

            return GetObject<List<Model.Basic.Sample.Sample>>(url);
        }
    }
}
