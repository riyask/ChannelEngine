using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{
    /// <summary>
    /// Class for ApiUri
    /// </summary>
    public class ApiUri
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUri"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="apiKey">The API key.</param>
        public ApiUri(Environment environment, string uri, string applicationName, string apiKey)
        {
            Environment = environment;
            Uri = uri;
            ApplicationName = applicationName;
            ApiKey = apiKey;
        }
        /// <summary>
        /// Gets the environment.
        /// </summary>
        /// <value>
        /// The environment.
        /// </value>
        public Environment Environment { get; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>
        /// The URI.
        /// </value>
        public string Uri { get; }
        /// <summary>
        /// Gets the name of the application.
        /// </summary>
        /// <value>
        /// The name of the application.
        /// </value>
        public string ApplicationName { get; }
        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public string ApiKey { get; }
    }
}
