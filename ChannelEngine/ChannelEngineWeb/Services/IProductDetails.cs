using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Services
{
    /// <summary>
    /// interface IProductDetails 
    /// </summary>
    public interface IProductDetails
    {
        /// <summary>
        /// Gets the products sold.
        /// </summary>
        /// <returns></returns>
        List<Products> GetProductsSold();
        /// <summary>
        /// Updates the products.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        UpdateStockResponse updateProducts(List<ProductStock> products);
    }
}
