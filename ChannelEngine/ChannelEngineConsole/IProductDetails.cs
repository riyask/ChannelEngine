using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConsole
{
    public interface IProductDetails
    {
        void ViewProducts();
        UpdateStockResponse updateProducts(List<ProductStock> products);
    }
}
