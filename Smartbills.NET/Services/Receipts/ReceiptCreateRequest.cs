using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Services.Addresses;
using Smartbills.NET.Services.Barcodes;
using Smartbills.NET.Services.Customers;
using Smartbills.NET.Services.ReceiptDiscounts;
using Smartbills.NET.Services.ReceiptFees;
using Smartbills.NET.Services.ReceiptItems;
using Smartbills.NET.Services.ReceiptMetadata;
using Smartbills.NET.Services.ReceiptPayments;
using Smartbills.NET.Services.ReceiptReviews;
using Smartbills.NET.Services.ReceiptTaxes;
using Smartbills.NET.Services.Taxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptCreateRequest : BaseRequest
    {

        public long? MerchantId { get; set; }
        public long? LocationId { get; set; }
        public long? EmployeeId { get; set; }

        public CustomerCreateRequest Customer { get; set; }
        public long? CustomerId { get; set; }
        public string ReceiptId { get; set; }

        public BillingAddressCreateRequest BillingAddress { get; set; }
        public BillingAddressCreateRequest ShippingAddress { get; set; }
        public List<ReceiptItemCreateRequest> Items { get; set; } = new List<ReceiptItemCreateRequest>();
        public List<ReceiptFeeCreateRequest> Fees { get; set; } = new List<ReceiptFeeCreateRequest>();

        public string Currency { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? DueDate { get; set; }

        public DateTimeOffset? CancelledAt { get; set; }

        public string CancelReason { get; set; }
        public string OrderNumber { get; set; }
        public string PaymentStatus { get; set; }
        public List<ReceiptDiscountRequest> Discounts { get; set; }

        public decimal TotalDiscounts { get; set; }

        public List<ReceiptTaxCreateRequest> Taxes { get; set; } = new List<ReceiptTaxCreateRequest>();


        public bool TaxesIncluded { get; set; }

        public decimal TotalTip { get; set; }

        public decimal TotalDuties { get; set; }

        public decimal TotalShipping { get; set; }

        public decimal TotalFees { get; set; }

        public decimal TotalWeight { get; set; }

        public decimal TotalTaxes { get; set; }

        public decimal Total { get; set; }


        public decimal SubTotal { get; set; }


        public string Source { get; set; }
        //public SBReceiptType Type { get; set; } = SBReceiptType.Official;
        public ReceiptMetadataCreateRequest ReceiptMetadata { get; set; }
        public List<ReceiptPaymentCreateRequest> Payments { get; set; } = new List<ReceiptPaymentCreateRequest>();

        public BarcodeCreateRequest Barcode { get; set; }

        public string OriginalReceiptUrl { get; set; }

        public ReceiptReviewCreateRequest Review { get; set; }

    }
}
