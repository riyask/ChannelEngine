using ChannelEngineBusiness.Business;
using ChannelEngineBusiness.Models;
using ChannelEngineConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ChannelEngineConsoleTest
{
    [TestClass]
    public class ProductDetailsTest
    {
        private readonly Mock<IOrderManagement> _mockOrderManagement;
        private readonly ProductDetails _productDetails;
        private readonly Mock<Itest> test;
        public ProductDetailsTest()
        {
            _mockOrderManagement = new Mock<IOrderManagement>();
            _productDetails = new ProductDetails(_mockOrderManagement.Object);
        }

        [TestMethod]
        public void ProductController_Action_ProductDetails()
        {
            //Arrange
            List<Products> products = null;
            _mockOrderManagement.Setup(x => x.GetProducts())
                .Returns<int?>(x => products = new List<Products>
                {
                    new Products { SlNo=1, Product= "T - shirt met lange mouw BASIC petrol: S",Gtin= "8719351029609",Quantity=4 },
                    new Products { SlNo=2, Product= "T - shirt met lange mouw BASIC petrol: M",Gtin= "8719351029609",Quantity=4 },
                    new Products { SlNo=3, Product= "T - shirt met lange mouw BASIC petrol: XL",Gtin= "8719351029609",Quantity=1 },
                    new Products { SlNo=4, Product= "T - shirt met lange mouw BASIC petrol: L",Gtin= "8719351029609",Quantity=1 }
                });

            //Act
            var result = _productDetails.GetProducts();

            // Assert
            Assert.IsInstanceOfType(result, typeof(Products));
            Assert.AreEqual(products.Count, ((IEnumerable<Products>)result).Count());
            Assert.AreEqual(products.First().Product, ((IEnumerable<Products>)result).First().Product);
            Assert.AreEqual(products.Last().Product, ((IEnumerable<Products>)result).Last().Product);
        }

        [TestMethod]
        public void ProductController_Action_UpdateStock_Success()
        {
            //Arrange
            List<ProductStock> updateProduct = new List<ProductStock>()
            {
                new ProductStock(){ MerchantProductNo = "001201-S", Stock = 25 }
            };

            //Act
            var result = _productDetails.updateProducts(updateProduct);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UpdateStockResponse));
            Assert.AreEqual(result.StatusCode, true);
        }

        [TestMethod]
        public void ProductController_Action_UpdateStock_Failure()
        {
            //Arrange
            List<ProductStock> updateProduct = new List<ProductStock>()
            {
                new ProductStock(){ MerchantProductNo = "ABCD", Stock = 25 }
            };

            //Act
            var result = _productDetails.updateProducts(updateProduct);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UpdateStockResponse));
            Assert.AreEqual(result.StatusCode, false);
        }
    }
}
