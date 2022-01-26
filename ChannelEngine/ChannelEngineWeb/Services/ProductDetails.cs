using ChannelEngineBusiness.Business;
using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Services
{
    /// <summary>
    /// class ProductDetails
    /// </summary>
    /// <seealso cref="ChannelEngineWeb.Services.IProductDetails" />
    public class ProductDetails :IProductDetails
    {
        /// <summary>
        /// The order management
        /// </summary>
        private readonly IOrderManagement _orderManagement;
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetails"/> class.
        /// </summary>
        /// <param name="orderManagement">The order management.</param>
        public ProductDetails(IOrderManagement orderManagement)
        {
            _orderManagement = orderManagement;
        }
        /// <summary>
        /// Gets the products sold.
        /// </summary>
        /// <returns></returns>
        public List<Products> GetProductsSold()
        {
            var products= _orderManagement.GetProducts();
            return products;
            
        }
        /// <summary>
        /// Updates the products.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        public UpdateStockResponse updateProducts(List<ProductStock> products)
        {
            var response = _orderManagement.UpdateStockByProduct(products);
            return response;
        }
        
    }

    
    
}
