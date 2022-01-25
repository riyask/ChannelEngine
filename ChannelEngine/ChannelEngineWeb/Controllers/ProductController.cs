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
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductDetails _productDetails;

        public ProductController(ILogger<HomeController> logger, IProductDetails productDetails)
        {
            _logger = logger;
            _productDetails = productDetails;
        }

        public IActionResult Index()
        {
            var products = _productDetails.GetProductsSold();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

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
