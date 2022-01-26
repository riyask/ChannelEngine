using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChannelEngineConfiguration;

namespace ChannelEngineBusiness
{
    /// <summary>
    /// Abstract calss for ChannelEngineBusinessBase
    /// </summary>
    public abstract class ChannelEngineBusinessBase
    {
        /// <summary>
        /// The base URI
        /// </summary>
        protected Uri BaseUri;
        /// <summary>
        /// The API key
        /// </summary>
        protected string ApiKey;
        /// <summary>
        /// The application name
        /// </summary>
        private const string ApplicationName = "ChannelEngineAPI";
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEngineBusinessBase"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        protected ChannelEngineBusinessBase(ChannelEngineConfiguration.Environment environment)
        {
            var ApiBaseUrl = new ApiBaseUrl(environment, ApplicationName);
            BaseUri = ApiBaseUrl.BaseUri;
            ApiKey = ApiBaseUrl.ApiKey;
        }
    }
}
