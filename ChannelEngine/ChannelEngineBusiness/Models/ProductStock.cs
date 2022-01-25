using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Models
{
    public class ProductStock
    {
        public string MerchantProductNo { get; set; }
        public int Stock { get; set; }
    }

    public class UpdateStockResponse
    {
        public Content Content { get; set; }
        public int StatusCode { get; set; }
        public object LogId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
