using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineBusiness.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    /// <summary>
    /// Class for Order
    /// </summary>
    public class BillingAddress
    {
        /// <summary>
        /// Gets or sets the line1.
        /// </summary>
        /// <value>
        /// The line1.
        /// </value>
        public string Line1 { get; set; }
        /// <summary>
        /// Gets or sets the line2.
        /// </summary>
        /// <value>
        /// The line2.
        /// </value>
        public object Line2 { get; set; }
        /// <summary>
        /// Gets or sets the line3.
        /// </summary>
        /// <value>
        /// The line3.
        /// </value>
        public object Line3 { get; set; }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public object CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>
        /// The name of the street.
        /// </value>
        public string StreetName { get; set; }
        /// <summary>
        /// Gets or sets the house nr.
        /// </summary>
        /// <value>
        /// The house nr.
        /// </value>
        public string HouseNr { get; set; }
        /// <summary>
        /// Gets or sets the house nr addition.
        /// </summary>
        /// <value>
        /// The house nr addition.
        /// </value>
        public object HouseNrAddition { get; set; }
        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public object Region { get; set; }
        /// <summary>
        /// Gets or sets the country iso.
        /// </summary>
        /// <value>
        /// The country iso.
        /// </value>
        public string CountryIso { get; set; }
        /// <summary>
        /// Gets or sets the original.
        /// </summary>
        /// <value>
        /// The original.
        /// </value>
        public object Original { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ShippingAddress
    {
        /// <summary>
        /// Gets or sets the line1.
        /// </summary>
        /// <value>
        /// The line1.
        /// </value>
        public string Line1 { get; set; }
        /// <summary>
        /// Gets or sets the line2.
        /// </summary>
        /// <value>
        /// The line2.
        /// </value>
        public object Line2 { get; set; }
        /// <summary>
        /// Gets or sets the line3.
        /// </summary>
        /// <value>
        /// The line3.
        /// </value>
        public object Line3 { get; set; }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public object CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>
        /// The name of the street.
        /// </value>
        public string StreetName { get; set; }
        /// <summary>
        /// Gets or sets the house nr.
        /// </summary>
        /// <value>
        /// The house nr.
        /// </value>
        public string HouseNr { get; set; }
        /// <summary>
        /// Gets or sets the house nr addition.
        /// </summary>
        /// <value>
        /// The house nr addition.
        /// </value>
        public object HouseNrAddition { get; set; }
        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public object Region { get; set; }
        /// <summary>
        /// Gets or sets the country iso.
        /// </summary>
        /// <value>
        /// The country iso.
        /// </value>
        public string CountryIso { get; set; }
        /// <summary>
        /// Gets or sets the original.
        /// </summary>
        /// <value>
        /// The original.
        /// </value>
        public object Original { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Line
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is fulfillment by marketplace.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is fulfillment by marketplace; otherwise, <c>false</c>.
        /// </value>
        public bool IsFulfillmentByMarketplace { get; set; }
        /// <summary>
        /// Gets or sets the gtin.
        /// </summary>
        /// <value>
        /// The gtin.
        /// </value>
        public string Gtin { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the stock location.
        /// </summary>
        /// <value>
        /// The stock location.
        /// </value>
        public object StockLocation { get; set; }
        /// <summary>
        /// Gets or sets the unit vat.
        /// </summary>
        /// <value>
        /// The unit vat.
        /// </value>
        public double UnitVat { get; set; }
        /// <summary>
        /// Gets or sets the line total incl vat.
        /// </summary>
        /// <value>
        /// The line total incl vat.
        /// </value>
        public double LineTotalInclVat { get; set; }
        /// <summary>
        /// Gets or sets the line vat.
        /// </summary>
        /// <value>
        /// The line vat.
        /// </value>
        public double LineVat { get; set; }
        /// <summary>
        /// Gets or sets the original unit price incl vat.
        /// </summary>
        /// <value>
        /// The original unit price incl vat.
        /// </value>
        public double OriginalUnitPriceInclVat { get; set; }
        /// <summary>
        /// Gets or sets the original unit vat.
        /// </summary>
        /// <value>
        /// The original unit vat.
        /// </value>
        public double OriginalUnitVat { get; set; }
        /// <summary>
        /// Gets or sets the original line total incl vat.
        /// </summary>
        /// <value>
        /// The original line total incl vat.
        /// </value>
        public double OriginalLineTotalInclVat { get; set; }
        /// <summary>
        /// Gets or sets the original line vat.
        /// </summary>
        /// <value>
        /// The original line vat.
        /// </value>
        public double OriginalLineVat { get; set; }
        /// <summary>
        /// Gets or sets the original fee fixed.
        /// </summary>
        /// <value>
        /// The original fee fixed.
        /// </value>
        public double OriginalFeeFixed { get; set; }
        /// <summary>
        /// Gets or sets the bundle product merchant product no.
        /// </summary>
        /// <value>
        /// The bundle product merchant product no.
        /// </value>
        public object BundleProductMerchantProductNo { get; set; }
        /// <summary>
        /// Gets or sets the juris code.
        /// </summary>
        /// <value>
        /// The juris code.
        /// </value>
        public object JurisCode { get; set; }
        /// <summary>
        /// Gets or sets the name of the juris.
        /// </summary>
        /// <value>
        /// The name of the juris.
        /// </value>
        public object JurisName { get; set; }
        /// <summary>
        /// Gets or sets the vat rate.
        /// </summary>
        /// <value>
        /// The vat rate.
        /// </value>
        public double VatRate { get; set; }
        /// <summary>
        /// Gets or sets the extra data.
        /// </summary>
        /// <value>
        /// The extra data.
        /// </value>
        public List<object> ExtraData { get; set; }
        /// <summary>
        /// Gets or sets the channel product no.
        /// </summary>
        /// <value>
        /// The channel product no.
        /// </value>
        public string ChannelProductNo { get; set; }
        /// <summary>
        /// Gets or sets the merchant product no.
        /// </summary>
        /// <value>
        /// The merchant product no.
        /// </value>
        public string MerchantProductNo { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the cancellation requested quantity.
        /// </summary>
        /// <value>
        /// The cancellation requested quantity.
        /// </value>
        public int CancellationRequestedQuantity { get; set; }
        /// <summary>
        /// Gets or sets the unit price incl vat.
        /// </summary>
        /// <value>
        /// The unit price incl vat.
        /// </value>
        public double UnitPriceInclVat { get; set; }
        /// <summary>
        /// Gets or sets the fee fixed.
        /// </summary>
        /// <value>
        /// The fee fixed.
        /// </value>
        public double FeeFixed { get; set; }
        /// <summary>
        /// Gets or sets the fee rate.
        /// </summary>
        /// <value>
        /// The fee rate.
        /// </value>
        public double FeeRate { get; set; }
        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        /// <value>
        /// The condition.
        /// </value>
        public string Condition { get; set; }
        /// <summary>
        /// Gets or sets the expected delivery date.
        /// </summary>
        /// <value>
        /// The expected delivery date.
        /// </value>
        public DateTime ExpectedDeliveryDate { get; set; }
    }


    /// <summary>
    /// 
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the channel.
        /// </summary>
        /// <value>
        /// The name of the channel.
        /// </value>
        public string ChannelName { get; set; }
        /// <summary>
        /// Gets or sets the channel identifier.
        /// </summary>
        /// <value>
        /// The channel identifier.
        /// </value>
        public int ChannelId { get; set; }
        /// <summary>
        /// Gets or sets the name of the global channel.
        /// </summary>
        /// <value>
        /// The name of the global channel.
        /// </value>
        public string GlobalChannelName { get; set; }
        /// <summary>
        /// Gets or sets the global channel identifier.
        /// </summary>
        /// <value>
        /// The global channel identifier.
        /// </value>
        public int GlobalChannelId { get; set; }
        /// <summary>
        /// Gets or sets the channel order support.
        /// </summary>
        /// <value>
        /// The channel order support.
        /// </value>
        public string ChannelOrderSupport { get; set; }
        /// <summary>
        /// Gets or sets the channel order no.
        /// </summary>
        /// <value>
        /// The channel order no.
        /// </value>
        public string ChannelOrderNo { get; set; }
        /// <summary>
        /// Gets or sets the merchant order no.
        /// </summary>
        /// <value>
        /// The merchant order no.
        /// </value>
        public string MerchantOrderNo { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is business order.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is business order; otherwise, <c>false</c>.
        /// </value>
        public bool IsBusinessOrder { get; set; }
        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>
        /// The updated at.
        /// </value>
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// Gets or sets the merchant comment.
        /// </summary>
        /// <value>
        /// The merchant comment.
        /// </value>
        public object MerchantComment { get; set; }
        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        /// <value>
        /// The billing address.
        /// </value>
        public BillingAddress BillingAddress { get; set; }
        /// <summary>
        /// Gets or sets the shipping address.
        /// </summary>
        /// <value>
        /// The shipping address.
        /// </value>
        public ShippingAddress ShippingAddress { get; set; }
        /// <summary>
        /// Gets or sets the sub total incl vat.
        /// </summary>
        /// <value>
        /// The sub total incl vat.
        /// </value>
        public double SubTotalInclVat { get; set; }
        /// <summary>
        /// Gets or sets the sub total vat.
        /// </summary>
        /// <value>
        /// The sub total vat.
        /// </value>
        public double SubTotalVat { get; set; }
        /// <summary>
        /// Gets or sets the shipping costs vat.
        /// </summary>
        /// <value>
        /// The shipping costs vat.
        /// </value>
        public double ShippingCostsVat { get; set; }
        /// <summary>
        /// Gets or sets the total incl vat.
        /// </summary>
        /// <value>
        /// The total incl vat.
        /// </value>
        public double TotalInclVat { get; set; }
        /// <summary>
        /// Gets or sets the total vat.
        /// </summary>
        /// <value>
        /// The total vat.
        /// </value>
        public double TotalVat { get; set; }
        /// <summary>
        /// Gets or sets the original sub total incl vat.
        /// </summary>
        /// <value>
        /// The original sub total incl vat.
        /// </value>
        public double OriginalSubTotalInclVat { get; set; }
        /// <summary>
        /// Gets or sets the original sub total vat.
        /// </summary>
        /// <value>
        /// The original sub total vat.
        /// </value>
        public double OriginalSubTotalVat { get; set; }
        /// <summary>
        /// Gets or sets the original shipping costs incl vat.
        /// </summary>
        /// <value>
        /// The original shipping costs incl vat.
        /// </value>
        public double OriginalShippingCostsInclVat { get; set; }
        /// <summary>
        /// Gets or sets the original shipping costs vat.
        /// </summary>
        /// <value>
        /// The original shipping costs vat.
        /// </value>
        public double OriginalShippingCostsVat { get; set; }
        /// <summary>
        /// Gets or sets the original total incl vat.
        /// </summary>
        /// <value>
        /// The original total incl vat.
        /// </value>
        public double OriginalTotalInclVat { get; set; }
        /// <summary>
        /// Gets or sets the original total vat.
        /// </summary>
        /// <value>
        /// The original total vat.
        /// </value>
        public double OriginalTotalVat { get; set; }
        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public List<Line> Lines { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the company registration no.
        /// </summary>
        /// <value>
        /// The company registration no.
        /// </value>
        public object CompanyRegistrationNo { get; set; }
        /// <summary>
        /// Gets or sets the vat no.
        /// </summary>
        /// <value>
        /// The vat no.
        /// </value>
        public object VatNo { get; set; }
        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        /// <value>
        /// The payment method.
        /// </value>
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Gets or sets the payment reference no.
        /// </summary>
        /// <value>
        /// The payment reference no.
        /// </value>
        public object PaymentReferenceNo { get; set; }
        /// <summary>
        /// Gets or sets the shipping costs incl vat.
        /// </summary>
        /// <value>
        /// The shipping costs incl vat.
        /// </value>
        public double ShippingCostsInclVat { get; set; }
        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        /// <value>
        /// The order date.
        /// </value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Gets or sets the channel customer no.
        /// </summary>
        /// <value>
        /// The channel customer no.
        /// </value>
        public object ChannelCustomerNo { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ValidationErrors
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public List<Content> Content { get; set; }
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the total count.
        /// </summary>
        /// <value>
        /// The total count.
        /// </value>
        public int TotalCount { get; set; }
        /// <summary>
        /// Gets or sets the items per page.
        /// </summary>
        /// <value>
        /// The items per page.
        /// </value>
        public int ItemsPerPage { get; set; }
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
        /// Gets or sets a value indicating whether this <see cref="Order"/> is success.
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
        public object Message { get; set; }
        /// <summary>
        /// Gets or sets the validation errors.
        /// </summary>
        /// <value>
        /// The validation errors.
        /// </value>
        public ValidationErrors ValidationErrors { get; set; }
    }
}
