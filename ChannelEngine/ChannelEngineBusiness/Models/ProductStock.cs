using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Models
{
    /// <summary>
    /// Class for product stock
    /// </summary>
    public class ProductStock
    {
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

    /// <summary>
    /// 
    /// </summary>
    public class UpdateStockResponse
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public Content Content { get; set; }
        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public int StatusCode { get; set; }
        /// <summary>
        /// Gets or sets the log identifier.
        /// </summary>
        /// <value>
        /// The log identifier.
        /// </value>
        public object LogId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="UpdateStockResponse"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        public bool Success { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }
    }
}
