using ChannelEngineBusiness.Models;
using ChannelEngineWeb.Controllers;
using ChannelEngineWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ChannelEngineWebTest
{
    /// <summary>
    /// class ProductControllerTest
    /// </summary>
    [TestClass]
    public class ProductControllerTest
    {
        /// <summary>
        /// The mock product details
        /// </summary>
        private readonly Mock<IProductDetails> _mockProductDetails;
        /// <summary>
        /// The controller
        /// </summary>
        private readonly ProductController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductControllerTest"/> class.
        /// </summary>
        public ProductControllerTest()
        {
            _mockProductDetails = new Mock<IProductDetails>();
            _controller = new ProductController(_mockProductDetails.Object);
        }

        /// <summary>
        /// Products the controller action product details.
        /// </summary>
        [TestMethod]
        public void ProductController_Action_ProductDetails()
        {
            //Arrange
            List<Products> products = null;
            _mockProductDetails.Setup(x => x.GetProductsSold())
                .Returns<int?>(x => products = new List<Products>
                {
                    new Products { SlNo=1, Product= "T - shirt met lange mouw BASIC petrol: S",Gtin= "8719351029609",Quantity=4 },
                    new Products { SlNo=2, Product= "T - shirt met lange mouw BASIC petrol: M",Gtin= "8719351029609",Quantity=4 },
                    new Products { SlNo=3, Product= "T - shirt met lange mouw BASIC petrol: XL",Gtin= "8719351029609",Quantity=1 },
                    new Products { SlNo=4, Product= "T - shirt met lange mouw BASIC petrol: L",Gtin= "8719351029609",Quantity=1 }
                });

            //Act
            var result = _controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(products.Count, ((IEnumerable<Products>)result.Model).Count());
            Assert.AreEqual(products.First().Product, ((IEnumerable<Products>)result.Model).First().Product);
            Assert.AreEqual(products.Last().Product, ((IEnumerable<Products>)result.Model).Last().Product);
        }

        /// <summary>
        /// Products the controller action update stock.
        /// </summary>
        [TestMethod]
        public void ProductController_Action_UpdateStock()
        {
            //Arrange
            var product = new ProductStock { MerchantProductNo = "001201-S", Stock = 25 };
            
            //Act
            var result = _controller.UpdateStock(product);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(result.StatusCode, true);
        }

        /// <summary>
        /// Products the controller action update stock failure.
        /// </summary>
        [TestMethod]
        public void ProductController_Action_UpdateStock_Failure()
        {
            //Arrange
            var product = new ProductStock { MerchantProductNo = "ABCD", Stock = 25 };

            //Act
            var result = _controller.UpdateStock(product);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(result.StatusCode, false);
        }
    }
}
