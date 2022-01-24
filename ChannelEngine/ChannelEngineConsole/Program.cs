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
    class Program
    {
        public static void Main(string[] args)
        {
            //Configuration = configuration;
            //BuildWebHost(args).Run();
            //OrderDetails om = new OrderDetails(_orderManagement);
            //om.GetAllOrders();
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            using var host = CreateHostBuilder(args, configuration).Build();
            GetAllOrderData(host.Services);
            //var s= GetAllOrders();
            //GetAsync();
            Console.WriteLine("Hello World!");
            //BuildWebHost(args).Run();
        }

        public static object GetAllOrders()
        {

            var result = Task.Run(async () => await GetAsync()).Result;
            return result;
        }
        public static async Task<HttpResponseMessage> GetAsync()
        {
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerTokenName, token);
                var result = await client.GetAsync("https://api-dev.channelengine.net/api/v2/orders?statuses=IN_PROGRESS&apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322").ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return result;
                }
                else
                {
                    return null;
                    // throw new HttpResponseException(new HttpResponseMessage(result.StatusCode) { Content = new StringContent(result.ReasonPhrase) });
                }
            }
        }
        private static IHostBuilder CreateHostBuilder(string[] args, IConfiguration configuration)
        {
            var config = ChannelEngineConfiguration.ConfigurationExtensions.GetConfiguration(configuration);
            ChannelEngineConfiguration.Environment env = new ChannelEngineConfiguration.Environment(config.Environment.Name);
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<IOrderDetails, OrderDetails>()
                    .AddTransient<IOrderManagement>(s => new OrderManagement(env))
                    );
        }

        public static List<ProductSold> GetAllOrderData(IServiceProvider services)
        {
            using var serviceScope = services.CreateScope();
            var provider = serviceScope.ServiceProvider;
            var order = provider.GetRequiredService<IOrderDetails>();
            var result = order.GetAllOrders();
            Console.WriteLine("SlNo    Product Name                                      GTIN             Total Quantity");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            foreach (var i in result)
            {
                var prodNameLength = i.Product.Length;
                var pad1 = 50 - prodNameLength;
                var print = i.SlNo.ToString().PadRight(8) + i.Product.PadRight(prodNameLength + pad1) + i.Gtin.PadRight(i.Gtin.Length + 13) + i.Quantity;
                Console.WriteLine(print);
            }

            Console.Write("\nEnter serial number of the product to update the stock in to 25 : ");
            int j = Convert.ToInt32(Console.ReadLine());
            var product = result.Where(f => f.SlNo == j).Select(g => g.Product).FirstOrDefault();
            Console.WriteLine("The selected product is " + product);
            Console.WriteLine("Updating the stock of " + product + " to 25......");
            return result;
        }
        public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args).ConfigureServices(services => services.AddAutofac()).UseStartup<Startup>().Build();
    }
}
