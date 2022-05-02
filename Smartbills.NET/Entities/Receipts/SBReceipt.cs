using Smartbills.Client.Entities.Taxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SBReceipt
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("company")]
        public SBCompany Company { get; set; }

        [JsonPropertyName("items")]

        public List<SBReceiptItem> Items { get; set; }

        [JsonPropertyName("total_items")]

        public decimal TotalItems { get; set; }
        [JsonPropertyName("sub_total")]

        public decimal SubTotal { get; set; }
        [JsonPropertyName("taxes")]

        public List<SBReceiptTax> Taxes { get; set; }
        [JsonPropertyName("total_taxes")]
        public decimal TotalTaxes { get; set; }
        [JsonPropertyName("total_discount")]
        public decimal TotalDiscount { get; set; }
        [JsonPropertyName("total_duties")]
        public decimal TotalDuties { get; set; }
        [JsonPropertyName("total_shipping")]
        public decimal TotalShipping { get; set; }
        [JsonPropertyName("total_tip")]
        public decimal TotalTip { get; set; }

        [JsonPropertyName("total")]

        public decimal Total { get; set; }


        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("taxes_included")]
        public bool TaxesIncluded { get; set; }
        //public List<SBReceiptTransactionVM> Transactions { get; set; }

        [JsonPropertyName("store_id")]
        public long? StoreId { get; set; }

        [JsonPropertyName("receipt_metadata")]
        public SBReceiptMetadata ReceiptMetadata { get; set; }

        [JsonPropertyName("total_weight")]
        public decimal TotalWeight { get; set; }

        // public List<SBReceiptDiscount> DiscountCodes { get; set; }
        //public GetCompanyCustomerVM Customer { get; set; }
        //public GetBillingAddressVM BillingAddress { get; set; }
        //public GetBillingAddressVM ShippingAddress { get; set; }

        [JsonPropertyName("order_number")]
        public string OrderNumber { get; set; }

        [JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; }

        [JsonPropertyName("payment_status")]

        public string PaymentStatus { get; set; }

        [JsonPropertyName("uploaded_at")]
        public DateTimeOffset UploadedAt { get; set; }

        [JsonPropertyName("cancelled_at")]
        public DateTimeOffset? CancelledAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("documents")]
        public List<SBDocument> Documents { get; set; } = new List<SBDocument>();
        //[JsonPropertyName("bank_transaction")]
        //public BankTransactionListItemDTO BankTransaction { get; set; }
        [JsonPropertyName("barcode")]
        public SBBarcode Barcode { get; set; }
    }
}
