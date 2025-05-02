using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Barcode;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.Receipts.LineItems;
using Smartbills.NET.Entities.Receipts.Payments;
using Smartbills.NET.Entities.Users;

using System;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceipt : SBEntity, ITimestamp
    {
        public SBReceipt()
        {
        }

        public SBReceiptAttachment Attachment { get; set; }
        public SBReceiptMerchant Merchant { get; set; }
        public SBReceiptLocation Location { get; set; }

        public SBReceiptCustomer Customer { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }

        public List<SBReceiptLineItem> LineItems { get; set; } = [];

        public SBMoney TotalItems { get; set; } = new SBMoney();
        public SBMoney TotalPayments { get; set; } = new SBMoney();
        public SBMoney TotalDiscounts { get; set; } = new SBMoney();
        public SBMoney TotalDuties { get; set; } = new SBMoney();
        public SBMoney TotalShipping { get; set; } = new SBMoney();
        public SBMoney TotalTip { get; set; } = new SBMoney();
        public SBMoney TotalFees { get; set; } = new SBMoney();
        public SBMoney SubTotal { get; set; } = new SBMoney();
        public SBMoney TotalTaxes { get; set; } = new SBMoney();

        public SBMoney Total { get; set; } = new SBMoney();

        //public bool TaxesIncluded { get; set; }
        public List<SBReceiptPayment> Payments { get; set; } = new List<SBReceiptPayment>();

        public List<SBReceiptTax> Taxes { get; set; } = new List<SBReceiptTax>();
        //public List<ReceiptFee> Fees { get; set; } = new List<ReceiptFee>();
        ////public ReceiptMetadata Metadata { get; set; }
        //public decimal TotalWeight { get; set; }

        //public List<ReceiptDiscount> Discounts { get; set; } = new();

        public string ReceiptId { get; set; }
        //public string OrderNumber { get; set; }

        //public string CancelReason { get; set; }

        //public string PaymentStatus { get; set; }


        //public SBReceiptSource Source { get; set; }
        public SBReceiptType Type { get; set; }

        // public SBReceiptBankTransaction BankTransaction { get; set; }


        public SBReceiptBarcode Barcode { get; set; }

        //public string OriginalReceiptUrl { get; set; }
        //public Review Review { get; set; }

        public SBUser User { get; set; }
        public string Url { get; set; }

        public DateTimeOffset Date { get; set; }
        public DateTimeOffset? CancelledAt { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public DateTimeOffset? ClosedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
