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
using ChannelEngineConfiguration;
using ChannelEngineBusiness.Enum;

namespace ChannelEngineBusiness.Business
{
    public class OrderManagement : ChannelEngineBusinessBase, IOrderManagement
    {

        public OrderManagement(ChannelEngineConfiguration.Environment environment) : base(environment)
        {
        }
        public List<ProductSold> GetAllOrders()
        {
            var result = Task.Run(async () => await GetAllOrdersAsync()).Result;
            return result;
        }
        private async Task<List<ProductSold>> GetAllOrdersAsync()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync($"{BaseUri}api/v2/orders?statuses={Status.IN_PROGRESS}&apikey={ApiKey}").ConfigureAwait(false);
            var response = result.Content.ReadAsStringAsync().Result;
            var orders = JsonConvert.DeserializeObject<Order>(response);
            var lines = orders.Content.SelectMany(f => f.Lines);
            var products = lines.GroupBy(g => new { g.MerchantProductNo }).Select((h, i) => new ProductSold { SlNo = i + 1, Product = h.FirstOrDefault().Description, Gtin = h.FirstOrDefault().Gtin, MerchantProductNo = h.Key.MerchantProductNo, Quantity = h.Sum(j => j.Quantity) });
            return products.OrderByDescending(g => g.Quantity).Take(5).ToList();
        }
    }
}
