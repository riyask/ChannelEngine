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
        public List<Content> GetAllOrders()
        {
            var orders = Task.Run(async () => await GetAllOrdersAsync()).Result;
            return orders;
        }
        private async Task<List<Content>> GetAllOrdersAsync()
        {
            try
            {
                HttpClient client = new HttpClient();
                var result = await client.GetAsync($"{BaseUri}api/v2/orders?statuses={Status.IN_PROGRESS}&apikey={ApiKey}").ConfigureAwait(false);
                var response = result.Content.ReadAsStringAsync().Result;
                var orders = JsonConvert.DeserializeObject<Order>(response);
                return orders.Content;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Products> GetProducts()
        {
            var orders = GetAllOrders();
            var lines = orders.SelectMany(f => f.Lines);
            var products = lines.GroupBy(g => new { g.MerchantProductNo }).Select((h, i) => new Products { SlNo = i + 1, Product = h.FirstOrDefault().Description, Gtin = h.FirstOrDefault().Gtin, MerchantProductNo = h.Key.MerchantProductNo, Quantity = h.Sum(j => j.Quantity) });
            return products.OrderByDescending(g => g.Quantity).Take(5).ToList();
        }

        public UpdateStockResponse UpdateStockByProduct(List<ProductStock> product)
        {
            var response = Task.Run(async () => await UpdateStockByProductSync(product)).Result;
            return response;
        }

        private async Task<UpdateStockResponse> UpdateStockByProductSync(List<ProductStock> product)
        {
            try
            {
                HttpClient client = new HttpClient();
                var productToUpdate = System.Text.Json.JsonSerializer.Serialize(product);
                var content = new StringContent(productToUpdate, Encoding.UTF8, "application/json");
                var result = await client.PutAsync($"{BaseUri}api/v2/offer?apikey={ApiKey}", content).ConfigureAwait(false);
                var responseData = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<UpdateStockResponse>(responseData);
                return response;
            }
            catch(Exception ex)
            {
                throw ;
            }
        }
    }
}
