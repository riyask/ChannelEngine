using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{
    public sealed class Configuration
    {
        public Configuration()
        {
        }

        public string ApplicationName { get; set; }
        public Environment Environment { get; set; }
    }
}
