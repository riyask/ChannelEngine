using ChannelEngineBusiness.Business;
using ChannelEngineBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConsole
{
    /// <summary>
    /// Calss for IProductDetails
    /// </summary>
    /// <seealso cref="ChannelEngineConsole.IProductDetails" />
    public class ProductDetails : IProductDetails
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
        /// Views the products.
        /// </summary>
        public void ViewProducts()
        {
            var products = GetProducts();
            displayProducts(products);
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public List<Products> GetProducts()
        {
            return _orderManagement.GetProducts();            
        }
        /// <summary>
        /// Displays the products.
        /// </summary>
        /// <param name="products">The products.</param>
        private void displayProducts(List<Products> products)
        {
            try
            {
                Console.WriteLine("SlNo    Product Name                                      GTIN             Total Quantity");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                foreach (var i in products)
                {
                    var prodNameLength = i.Product.Length;
                    var pad1 = 50 - prodNameLength;
                    var print = i.SlNo.ToString().PadRight(8) + i.Product.PadRight(prodNameLength + pad1) + i.Gtin.PadRight(i.Gtin.Length + 13) + i.Quantity;
                    Console.WriteLine(print);
                }

                Console.Write("\nEnter serial number of the product to update the stock in to 25 : ");
                int siNo = Convert.ToInt32(Console.ReadLine());
                var productToUpate = products.Where(f => f.SlNo == siNo).FirstOrDefault();
                if (productToUpate != null)
                {


                    Console.WriteLine("The selected product is " + productToUpate.Product);
                    Console.WriteLine("Updating the stock of " + productToUpate.Product + " to 25......");
                    List<ProductStock> updateProduct = new List<ProductStock>()
                    {
                        new ProductStock(){ MerchantProductNo = productToUpate.MerchantProductNo, Stock = 25 }
                    };
                    var response = updateProducts(updateProduct);
                    displayUpdateMessage(response, productToUpate);
                }
                else
                {
                    displayUpdateMessage(null, null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        /// <summary>
        /// Displays the update message.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="product">The product.</param>
        private void displayUpdateMessage(UpdateStockResponse response, Products product)
        {
            if (product != null)
            {
                var message = response.Success ? $"The Product { product.Product} stock updated to 25 Successfully!!" : response.Message;
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Please enter a valid SINo.");
            }
        }
    }

}
