using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ChannelEngineConfiguration
{
    /// <summary>
    /// Class for ConfigurationExtensions
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        public static Configuration GetConfiguration(this IConfiguration configuration)
        {
            var section = configuration.GetSection("ChannelEngine");
            var s = new Environment(section.GetValue<string>("environment"));
            return new Configuration
            {
                Environment = new Environment(section.GetValue<string>("environment"))
            };
        }
    }
}
