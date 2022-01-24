using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{
    public class ApiUri
    {
        public ApiUri(Environment environment, string uri, string applicationName, string apiKey)
        {
            Environment = environment;
            Uri = uri;
            ApplicationName = applicationName;
            ApiKey = apiKey;
        }
        public Environment Environment { get; }
        public string Uri { get; }
        public string ApplicationName { get; }
        public string ApiKey { get; }
    }
}
