using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{
    public class ApiBaseUrl
    {
        public Uri BaseUri;
        public string ApiKey;
        public static readonly IList<ApiUri> Uris = new List<ApiUri>
                                                        {
                                                            {new ApiUri(Environment.DEV,"https://api-dev.channelengine.net/","ChannelEngineAPI","541b989ef78ccb1bad630ea5b85c6ebff9ca3322" )},
                                                        };
        public ApiBaseUrl(Environment environment, string applicationName)
        {
            BaseUri = new Uri(Uris.FirstOrDefault(a => a.Environment.Name == environment.Name && a.ApplicationName == applicationName)?.Uri);
            ApiKey = Uris.FirstOrDefault(a => a.Environment.Name == environment.Name && a.ApplicationName == applicationName)?.ApiKey;
        }
    }
}
