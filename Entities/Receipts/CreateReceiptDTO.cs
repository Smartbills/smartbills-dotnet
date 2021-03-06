
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Smartbills.Client.Entities.Companies;
using Smartbills.Client.Entities.ReceiptDiscounts;
using Smartbills.Client.Entities.ReceiptItems;
using Smartbills.Client.Entities.ReceiptMetadata;
using Smartbills.Client.Entities.Taxes;
using Smartbills.Client.Entities.Transactions;

namespace Smartbills.Client.Entities.Receipts
{
    public class CreateReceiptDTO
    {
        [JsonPropertyName("company_id")]
        public Guid? CompanyId {get;set;}

        [JsonPropertyName("customer")]
        public CreateCompanyCustomerRequest Customer { get; set; }
        [JsonPropertyName("billing_address")]
        //public CreateBillingAddressDTO BillingAddress { get; set; }
        //[JsonPropertyName("shipping_address")]
        //public CreateBillingAddressDTO ShippingAddress { get; set; }
        //[JsonPropertyName("items")]
        public List<CreateReceiptItemDTO> Items { get; set; } = new List<CreateReceiptItemDTO>();

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("cancelled_at")]
        public DateTimeOffset? CancelledAt { get; set; }
        [MaxLength(255)]

        [JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; }
        [JsonPropertyName("payment_status")]
        public string PaymentStatus { get; set; }
        [JsonPropertyName("discount_codes")]
        public List<CreateReceiptDiscountDTO> DiscountCodes { get; set; }

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
        [JsonPropertyName("total")]

        public decimal Total { get; set; }

        [JsonPropertyName("subtotal")]

        public decimal SubTotal { get; set; }

        [JsonPropertyName("receipt_metadata")]

        public CreateReceiptMetadataDTO ReceiptMetadata { get; set; }
        [JsonPropertyName("store_id")]

        public Guid? StoreId { get; set; }

        //[JsonPropertyName("transactions")]

        //public List<CreateReceiptTransactionDTO> Transactions { get; set; }

        //[JsonPropertyName("barcode")]
        //public CreateBarcodeDTO Barcode{ get; set; }

    }
}
