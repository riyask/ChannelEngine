using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Business
{
    public interface IOrderManagement
    {
        List<ProductSold> GetAllOrders();
    }
}
