using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Business
{
    /// <summary>
    /// Interace for Order Management
    /// </summary>
    public interface IOrderManagement
    {
        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <returns></returns>
        List<Content> GetAllOrders();
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        List<Products> GetProducts();
        /// <summary>
        /// Updates the stock by product.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        UpdateStockResponse UpdateStockByProduct(List<ProductStock> products);
    }
}
