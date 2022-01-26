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
    /// <summary>
    /// Class for Order Management
    /// </summary>
    /// <seealso cref="ChannelEngineBusiness.ChannelEngineBusinessBase" />
    /// <seealso cref="ChannelEngineBusiness.Business.IOrderManagement" />
    public class OrderManagement : ChannelEngineBusinessBase, IOrderManagement
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderManagement"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public OrderManagement(ChannelEngineConfiguration.Environment environment) : base(environment)
        {
        }
        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <returns></returns>
        public List<Content> GetAllOrders()
        {
            var orders = Task.Run(async () => await GetAllOrdersAsync()).Result;
            return orders;
        }
        /// <summary>
        /// Gets all orders asynchronous.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public List<Products> GetProducts()
        {
            var orders = GetAllOrders();
            var lines = orders.SelectMany(f => f.Lines);
            var products = lines.GroupBy(g => new { g.MerchantProductNo }).Select((h, i) => new Products { SlNo = i + 1, Product = h.FirstOrDefault().Description, Gtin = h.FirstOrDefault().Gtin, MerchantProductNo = h.Key.MerchantProductNo, Quantity = h.Sum(j => j.Quantity) });
            return products.OrderByDescending(g => g.Quantity).Take(5).ToList();
        }

        /// <summary>
        /// Updates the stock by product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public UpdateStockResponse UpdateStockByProduct(List<ProductStock> product)
        {
            var response = Task.Run(async () => await UpdateStockByProductSync(product)).Result;
            return response;
        }

        /// <summary>
        /// Updates the stock by product synchronize.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
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
