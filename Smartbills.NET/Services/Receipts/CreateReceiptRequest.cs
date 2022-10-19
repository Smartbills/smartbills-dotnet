using Smartbills.NET.Entities.ReceiptDiscounts;
using Smartbills.NET.Services._base;
using Smartbills.NET.Services.Addresses;
using Smartbills.NET.Services.Customers;
using Smartbills.NET.Services.ReceiptFees;
using Smartbills.NET.Services.ReceiptItems;
using Smartbills.NET.Services.ReceiptMetadata;
using Smartbills.NET.Services.Taxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Receipts
{
    public record CreateReceiptRequest : BaseRequest
    {
        [JsonPropertyName("merchant_id")]
        public long? MerchantId { get; set; }

        [JsonPropertyName("customer")]
        public CreateCustomerRequest Customer { get; set; }

        [JsonPropertyName("customer_id")]
        public CreateCustomerRequest CustomerId { get; set; }

        [JsonPropertyName("billing_address")]
        public CreateBillingAddressRequest BillingAddress { get; set; }
        [JsonPropertyName("shipping_address")]
        public CreateBillingAddressRequest ShippingAddress { get; set; }
        [JsonPropertyName("items")]
        public List<CreateReceiptItemRequest> Items { get; set; } = new List<CreateReceiptItemRequest>();

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("cancelled_at")]
        public DateTimeOffset? CancelledAt { get; set; }

        [JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; }
        [JsonPropertyName("payment_status")]
        public string PaymentStatus { get; set; }
        [JsonPropertyName("discount_codes")]
        public List<CreateReceiptDiscountRequest> DiscountCodes { get; set; }

        [JsonPropertyName("fees")]
        public List<CreateReceiptFeeRequest> Fees { get; set; } = new List<CreateReceiptFeeRequest>();



        [JsonPropertyName("total_discounts")]
        public decimal TotalDiscounts { get; set; }

        [JsonPropertyName("taxes")]

        public List<CreateReceiptTaxRequest> Taxes { get; set; } = new List<CreateReceiptTaxRequest>() { };

        [JsonPropertyName("taxes_included")]

        public bool TaxesIncluded { get; set; }
        [JsonPropertyName("total_tip")]

        public decimal TotalTip { get; set; }
        [JsonPropertyName("total_duties")]

        public decimal TotalDuties { get; set; }
        [JsonPropertyName("total_shipping")]

        public decimal TotalShipping { get; set; }
        [JsonPropertyName("total_weight")]

        public decimal TotalWeight { get; set; }
        [JsonPropertyName("total_taxes")]





        public decimal TotalTaxes { get; set; }

        [JsonPropertyName("total_fees")]
        public decimal TotalFees { get; set; }

        [JsonPropertyName("total")]

        public decimal Total { get; set; }

        [JsonPropertyName("subtotal")]

        public decimal SubTotal { get; set; }

        [JsonPropertyName("receipt_metadata")]

        public CreateReceiptMetadataRequest ReceiptMetadata { get; set; }
        [JsonPropertyName("store_id")]

        public long? LocationId { get; set; }

        //[JsonPropertyName("transactions")]

        //public List<CreateReceiptTransactionDTO> Transactions { get; set; }

        //[JsonPropertyName("barcode")]
        //public CreateBarcodeDTO Barcode{ get; set; }

    }
}
