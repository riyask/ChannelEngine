using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConsole
{
    public interface IOrderDetails
    {
        List<ProductSold> GetAllOrders();
    }
}
