using ChannelEngineBusiness.Models;
using ChannelEngineWeb.Models;
using ChannelEngineWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineWeb.Controllers
{
    /// <summary>
    /// class ProductController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class ProductController : Controller
    {
        /// <summary>
        /// The product details
        /// </summary>
        private readonly IProductDetails _productDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="productDetails">The product details.</param>
        public ProductController(IProductDetails productDetails)
        {
            _productDetails = productDetails;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            var products = _productDetails.GetProductsSold();
            return View(products);
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Updates the stock.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        [HttpPut]
        public UpdateStockResponse UpdateStock([FromBody] ProductStock product)
        {
            List<ProductStock> updateProduct = new List<ProductStock>()
            {
                new ProductStock(){ MerchantProductNo = product.MerchantProductNo, Stock = product.Stock }
            };
            var response = _productDetails.updateProducts(updateProduct);
            return response;
        }
    }
}
