using System;
using System.Net.Http;
using System.Threading.Tasks;
using ChannelEngineBusiness;
namespace ChannelEngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManagement om = new OrderManagement();
            var result= om.GetAllOrders();
            //var s= GetAllOrders();
            //GetAsync();
            Console.WriteLine("Hello World!");
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
    }
}
