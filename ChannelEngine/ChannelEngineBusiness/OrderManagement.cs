using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ChannelEngineBusiness.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChannelEngineBusiness
{
    public class OrderManagement : IOrderManagement
    {
        public object GetAllOrders()
        {
            var result = Task.Run(async () => await GetAllOrdersAsync()).Result;
            return result;
        }
        private async Task<Order> GetAllOrdersAsync()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("https://api-dev.channelengine.net/api/v2/orders?statuses=IN_PROGRESS&apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322").ConfigureAwait(false);
            var a = result.Content.ReadAsStringAsync().Result;
            JObject json = JObject.Parse(a);
            var a1 = JsonConvert.DeserializeObject<Order>(a);
            return a1;
        }
    }
}
