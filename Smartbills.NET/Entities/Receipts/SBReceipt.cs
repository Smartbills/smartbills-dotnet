using Smartbills.Core.DTO;
using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Entities.Barcode;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Entities.Merchants;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceipt : SmartbillsEntityWithId
    {

        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }


        public SBMerchant Merchant { get; set; }

        public List<SBReceiptItem> Items { get; set; } = new List<SBReceiptItem>();

        public decimal TotalItems { get; set; }

        public decimal SubTotal { get; set; }

        public List<SBReceiptTax> Taxes { get; set; } = new List<SBReceiptTax>();
        public List<SBReceiptFee> Fees { get; set; } = new List<SBReceiptFee>();


        public string Currency { get; set; }

        public bool TaxesIncluded { get; set; }
        public List<SBReceiptTransaction> Transactions { get; set; } = new List<SBReceiptTransaction>();

        public SBLocation Location { get; set; }

        public Dictionary<string,string> Metadata { get; set; }
        public decimal TotalWeight { get; set; }

        public SBCustomer Customer { get; set; }

        public string OrderNumber { get; set; }

        public string CancelReason { get; set; }

        public string PaymentStatus { get; set; }

        public DateTimeOffset UploadedAt { get; set; }

        public DateTimeOffset? CancelledAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        //public List<DocumentResponse> Documents { get; set; } = new List<DocumentResponse>();
        public SBBankTransaction BankTransaction { get; set; }


        public SBBarcode Barcode { get; set; }
        public string Source { get; set; }

        public string OriginalReceiptUrl { get; set; }

        public string SignedUrl { get; set; }
        public SBReceiptReview Review { get; set; }

        public decimal TotalTaxes { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalDuties { get; set; }
        public decimal TotalShipping { get; set; }
        public decimal TotalTip { get; set; }
        public decimal TotalFees { get; set; }
        public decimal Total { get; set; }
        public SBReceiptType Type { get; set; }


    }
}
