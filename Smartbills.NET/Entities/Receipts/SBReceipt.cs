using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Entities.Barcode;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Entities.Documents;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Entities.Merchants;
using Smartbills.NET.Entities.ReceiptDiscounts;
using Smartbills.NET.Entities.ReceiptPayments;
using Smartbills.NET.Entities.Taxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceipt : SmartbillsEntityWithId
    {

        public SBReceiptMerchant Merchant { get; set; }
        public SBLocation Location { get; set; }

        public SBCustomer Customer { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }

        public List<SBReceiptItem> Items { get; set; } = new List<SBReceiptItem>();

        public decimal TotalItems { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalDuties { get; set; }
        public decimal TotalShipping { get; set; }
        public decimal TotalTip { get; set; }
        public decimal TotalFees { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTaxes { get; set; }

        public decimal Total { get; set; }
        public string Currency { get; set; }
        public bool TaxesIncluded { get; set; }
        public List<SBReceiptPayment> Payments { get; set; } = new List<SBReceiptPayment>();

        public List<SBReceiptTax> Taxes { get; set; } = new List<SBReceiptTax>();
        public List<SBReceiptFee> Fees { get; set; } = new List<SBReceiptFee>();
        //public ReceiptMetadata Metadata { get; set; }
        public decimal TotalWeight { get; set; }

        public List<SBReceiptDiscount> Discounts { get; set; }

        public string ReceiptId { get; set; }
        public string OrderNumber { get; set; }

        public string CancelReason { get; set; }

        public string PaymentStatus { get; set; }

        public DateTimeOffset? DueDate { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UploadedAt { get; set; }
        public DateTimeOffset? CancelledAt { get; set; }
        //public SBReceiptSource Source { get; set; }
        //public SBReceiptType Type { get; set; }


        public List<SBDocument> Documents { get; set; } = new List<SBDocument>();
        //public ReceiptBankTransaction BankTransaction { get; set; }



        

        //public ReceiptBarcode Barcode { get; set; }

        public string OriginalReceiptUrl { get; set; }
        //public SBReview Review { get; set; }

        public string SignedUrl { get; set; }
        //public S User { get; set; }


    }
}
