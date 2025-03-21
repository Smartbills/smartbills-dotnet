using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Barcode;
using Smartbills.NET.Services.Receipts.Payments;
using Smartbills.NET.Services.Receipts.LineItems;
using System;
using System.Collections.Generic;
using Smartbills.NET.Services.Receipts.ReceiptTaxes;
using Smartbills.NET.Services.Merchants.Customers;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptUpdateRequest
    {
        public long? MerchantId { get; set; }
        public long? LocationId { get; set; }

        public long? EmployeeId { get; set; }

        public CustomerUpdateRequest Customer { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public List<ReceiptLineItemUpdateRequest> Items { get; set; } = new List<ReceiptLineItemUpdateRequest>();

        public string Currency { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset? CancelledAt { get; set; }

        public string CancelReason { get; set; }
        public string PaymentStatus { get; set; }


        public decimal TotalDiscounts { get; set; }


        public List<ReceiptTaxUpdateRequest> Taxes { get; set; } = new List<ReceiptTaxUpdateRequest>() { };


        public bool TaxesIncluded { get; set; }

        public decimal TotalTip { get; set; }

        public decimal TotalDuties { get; set; }

        public decimal TotalShipping { get; set; }

        public decimal TotalWeight { get; set; }

        public decimal TotalTaxes { get; set; }

        public decimal Total { get; set; }


        public decimal SubTotal { get; set; }


        // public UpdateReceiptMetadataRequest ReceiptMetadata { get; set; }



        public List<ReceiptPaymentUpdateRequest> Transactions { get; set; }

        public SBReceiptBarcode Barcode { get; set; }
    }
}
