﻿using System.Collections.Generic;
using BlueTracker.SDK.Performance.Core;
using BlueTracker.SDK.Performance.Query;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <inheritdoc />
    /// <summary>
    /// Client for getting onboard sample sources.
    /// </summary>
    public class OnboardSampleSourceClient : ApiWrapper
    {
        /// <summary>
        /// Creates a new SampleClient instance.
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
        public OnboardSampleSourceClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Gets all onboard sample sources for the company
        /// </summary>
        /// <returns>List of all sample sources</returns>
        public List<OnboardSampleSource> GetAll()
        {
            return GetObject<List<OnboardSampleSource>>("/api/v1/onboardSamples/sources");
        }

        /// <summary>
        /// Get a specific sample source identified by name
        /// </summary>
        /// <param name="sourceName">The name of the sample source</param>
        /// <returns>The sample source</returns>
        public OnboardSampleSource Get(string sourceName)
        {
            return GetObject<OnboardSampleSource>($"/api/v1/onboardSamples/sources/{sourceName}");
        }

        /// <summary>
        /// Get a specific sample source identified by Id
        /// </summary>
        /// <param name="sourceId">The Id of the sample source</param>
        /// <returns>The sample source</returns>
        public OnboardSampleSource Get(int sourceId)
        {
            return GetObject<OnboardSampleSource>($"/api/v1/onboardSamples/sources/{sourceId}");
        }
    }
}
