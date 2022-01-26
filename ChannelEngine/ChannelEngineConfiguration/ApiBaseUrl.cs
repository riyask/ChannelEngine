using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{
    /// <summary>
    /// Class for ApiBaseUrl
    /// </summary>
    public class ApiBaseUrl
    {
        /// <summary>
        /// The base URI
        /// </summary>
        public Uri BaseUri;
        /// <summary>
        /// The API key
        /// </summary>
        public string ApiKey;
        /// <summary>
        /// The uris
        /// </summary>
        public static readonly IList<ApiUri> Uris = new List<ApiUri>
                                                        {
                                                            {new ApiUri(Environment.DEV,"https://api-dev.channelengine.net/","ChannelEngineAPI","541b989ef78ccb1bad630ea5b85c6ebff9ca3322" )},
                                                        };
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiBaseUrl"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        /// <param name="applicationName">Name of the application.</param>
        public ApiBaseUrl(Environment environment, string applicationName)
        {
            BaseUri = new Uri(Uris.FirstOrDefault(a => a.Environment.Name == environment.Name && a.ApplicationName == applicationName)?.Uri);
            ApiKey = Uris.FirstOrDefault(a => a.Environment.Name == environment.Name && a.ApplicationName == applicationName)?.ApiKey;
        }
    }
}
