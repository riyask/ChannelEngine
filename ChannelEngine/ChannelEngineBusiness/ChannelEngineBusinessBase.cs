using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChannelEngineConfiguration;

namespace ChannelEngineBusiness
{
    public abstract class ChannelEngineBusinessBase
    {
        protected Uri BaseUri;
        protected string ApiKey;
        private const string ApplicationName = "ChannelEngineAPI";        
        protected ChannelEngineBusinessBase(ChannelEngineConfiguration.Environment environment)
        {
            var ApiBaseUrl = new ApiBaseUrl(environment, ApplicationName);
            BaseUri = ApiBaseUrl.BaseUri;
            ApiKey = ApiBaseUrl.ApiKey;
        }
    }
}
