using ChannelEngineBusiness.Models;
using System.Collections.Generic;

namespace ChannelEngineConsole
{
    /// <summary>
    /// Interface for IProductDetails
    /// </summary>
    public interface IProductDetails
    {
        /// <summary>
        /// Views the products.
        /// </summary>
        void ViewProducts();
        /// <summary>
        /// Updates the products.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        UpdateStockResponse updateProducts(List<ProductStock> products);
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        List<Products> GetProducts();
    }
}
