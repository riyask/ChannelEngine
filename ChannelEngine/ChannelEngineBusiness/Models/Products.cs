using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Models
{
    public class Products
    {
        public int SlNo { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public string Gtin { get; set; }
        public string MerchantProductNo { get; set; }
        public int Stock { get; set; }
    }
}
