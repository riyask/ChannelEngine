using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Models
{
    /// <summary>
    /// Class for product
    /// </summary>
    public class Products
    {
        /// <summary>
        /// Gets or sets the sl no.
        /// </summary>
        /// <value>
        /// The sl no.
        /// </value>
        public int SlNo { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public string Product { get; set; }
        /// <summary>
        /// Gets or sets the gtin.
        /// </summary>
        /// <value>
        /// The gtin.
        /// </value>
        public string Gtin { get; set; }
        /// <summary>
        /// Gets or sets the merchant product no.
        /// </summary>
        /// <value>
        /// The merchant product no.
        /// </value>
        public string MerchantProductNo { get; set; }
        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public int Stock { get; set; }
    }
}
