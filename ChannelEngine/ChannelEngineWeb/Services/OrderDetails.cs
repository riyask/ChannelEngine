using ChannelEngineBusiness.Business;
using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Services
{
    public class OrderDetails :IOrderDetails
    {
        private readonly IOrderManagement _orderManagement;
        public OrderDetails(IOrderManagement orderManagement)
        {
            _orderManagement = orderManagement;
        }
        public List<ProductSold> GetAllOrders()
        {
            var result= _orderManagement.GetAllOrders();
            return result;
        }
    }

    
    
}
