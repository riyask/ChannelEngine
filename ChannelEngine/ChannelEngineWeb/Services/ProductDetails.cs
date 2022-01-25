using ChannelEngineBusiness.Business;
using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Services
{
    public class ProductDetails :IProductDetails
    {
        private readonly IOrderManagement _orderManagement;
        public ProductDetails(IOrderManagement orderManagement)
        {
            _orderManagement = orderManagement;
        }
        public List<Products> GetProductsSold()
        {
            var products= _orderManagement.GetProducts();
            return products;
            
        }
    }

    
    
}
