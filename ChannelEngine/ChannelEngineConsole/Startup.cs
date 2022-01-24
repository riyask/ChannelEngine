using Autofac;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChannelEngineBusiness.Business;
using ChannelEngineBusiness;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using ChannelEngineConfiguration;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ChannelEngineConsole
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Configuration ChannelEngineConfiguration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ChannelEngineConfiguration = configuration.GetConfiguration();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                {
                    Name = "ChannelEngine"
                }));
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            //builder.RegisterModule<AppAutofacModule>();
            builder.Register(x => new OrderManagement(ChannelEngineConfiguration.Environment)).As<IOrderManagement>().SingleInstance();
           // builder.Register(x => new OrderDetails()).As<IOrderDetails>().SingleInstance();

        }
        public void OrderManagement()
        {
            //OrderDetails order = new OrderDetails();
            //order.GetAllOrders();
        }
    }
}
