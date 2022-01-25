using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Services
{
    public interface IProductDetails
    {
        List<Products> GetProductsSold();
        UpdateStockResponse updateProducts(List<ProductStock> products);
    }
}
