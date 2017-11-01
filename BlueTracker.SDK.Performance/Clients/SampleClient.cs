using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueTracker.SDK.Performance.Core;

namespace BlueTracker.SDK.Performance.Clients
{
    /// <summary>
    /// 
    /// </summary>
    public class SampleClient: ApiWrapper
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
        public SampleClient(string serverAddress = null, string authorization = null) :
            base(serverAddress, authorization)
        {
        }

        /// <summary>
        /// Posts a sample of named sample source.
        /// </summary>
        /// <param name="sample">Sample data to post</param>
        /// <param name="sourceName">The Name of the sample source</param>
        /// <returns>A short version of the posted data.</returns>
        public Query.Sample PostSample(Sample.Sample sample, string sourceName)
        {
            return PostObject<Query.Sample, Sample.Sample>(sample, $"api/v1/onboardSamples/sources/{sourceName}/values");
        }

        public Query.Sample Query(int sourceId, int imoNumber, long time)
        {
            return GetObject<Query.Sample>($"api/v1/onboardSamples/sources/{sourceId}/{imoNumber}/{time}");
        }
    }
}
