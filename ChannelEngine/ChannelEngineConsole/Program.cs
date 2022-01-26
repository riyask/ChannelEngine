using System;
using System.Net.Http;
using System.Threading.Tasks;
using ChannelEngineBusiness.Business;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ChannelEngineBusiness.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace ChannelEngineConsole
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            using var host = CreateHostBuilder(args, configuration).Build();
            ViewProducts(host.Services);
        }

        /// <summary>
        /// Creates the host builder.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        private static IHostBuilder CreateHostBuilder(string[] args, IConfiguration configuration)
        {
            var config = ChannelEngineConfiguration.ConfigurationExtensions.GetConfiguration(configuration);
            ChannelEngineConfiguration.Environment env = new ChannelEngineConfiguration.Environment(config.Environment.Name);
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<IProductDetails, ProductDetails>()
                    .AddTransient<IOrderManagement>(s => new OrderManagement(env))
                    );
        }

        /// <summary>
        /// Views the products.
        /// </summary>
        /// <param name="services">The services.</param>
        private static void ViewProducts(IServiceProvider services)
        {
            using var serviceScope = services.CreateScope();
            var provider = serviceScope.ServiceProvider;
            var order = provider.GetRequiredService<IProductDetails>();
            order.ViewProducts();
        }
    }
}
