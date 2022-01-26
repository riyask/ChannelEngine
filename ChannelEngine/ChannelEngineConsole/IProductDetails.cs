using ChannelEngineBusiness.Models;
using System.Collections.Generic;

namespace ChannelEngineConsole
{
    public interface IProductDetails
    {
        void ViewProducts();
        UpdateStockResponse updateProducts(List<ProductStock> products);
        List<Products> GetProducts();
    }
}
