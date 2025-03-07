using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Services.Images;
using Smartbills.NET.Services.Locations;
using Smartbills.NET.Services.Receipts.Fees;
using Smartbills.NET.Services.Receipts.Payments;
using Smartbills.NET.Services.Receipts;
using Smartbills.NET.Services.Receipts.LineItems;
using Smartbills.NET.Services.Receipts.Taxes;
using System;
using System.Collections.Generic;
using Smartbills.NET.Entities.Barcode;

namespace Smartbills.NET.Services
{
    public record ReceiptCreateRequest : IOptionalLocationIdDTO
    {
        public ReceiptCreateRequest()
        {
        }
        public ReceiptCreateRequest(string currency)
        {
            Currency = currency;
            TotalDiscounts = new SBMoney(0, Currency);
            TotalFees = new SBMoney(0, Currency);

            SubTotal = new SBMoney(0, Currency);

            TotalTip = new SBMoney(0, Currency);

            TotalDuties = new SBMoney(0, Currency);

            TotalShipping = new SBMoney(0, Currency);


            TotalTaxes = new SBMoney(0, Currency);

            Total = new SBMoney(0, Currency);

        }

        public long? MerchantId { get; set; }
        public long? LocationId { get; set; }
        public LocationCreateRequest Location { get; set; }

        public CustomerCreateRequest Customer { get; set; }
        public long? CustomerId { get; set; }
        public string ReceiptId { get; set; }
        public long? EmployeeId { get; set; }

        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public List<ReceiptLineItemCreateRequest> Items { get; set; } = new List<ReceiptLineItemCreateRequest>();
        public List<ReceiptFeeCreateRequest> Fees { get; set; } = new List<ReceiptFeeCreateRequest>();

        public string Currency { get; set; } = "CAD";

        public DateTimeOffset? Date { get; set; }

        public DateTimeOffset? DueDate { get; set; }

        public DateTimeOffset? CancelledAt { get; set; }

        public string CancelReason { get; set; }
        public string OrderNumber { get; set; }
        public string PaymentStatus { get; set; }
        public List<ReceiptDiscountCreateRequest> Discounts { get; set; }


        public List<ReceiptTaxCreateRequest> Taxes { get; set; } = new List<ReceiptTaxCreateRequest>();


        public bool TaxesIncluded { get; set; }

        public SBMoney TotalDiscounts { get; set; } = new SBMoney(0, "CAD");
        public SBMoney TotalFees { get; set; } = new SBMoney(0, "CAD");

        public SBMoney SubTotal { get; set; } = new SBMoney(0, "CAD");

        public SBMoney TotalTip { get; set; } = new SBMoney(0, "CAD");

        public SBMoney TotalDuties { get; set; } = new SBMoney(0, "CAD");

        public SBMoney TotalShipping { get; set; } = new SBMoney(0, "CAD");


        public SBMoney TotalTaxes { get; set; } = new SBMoney(0, "CAD");

        public SBMoney Total { get; set; } = new SBMoney(0, "CAD");

        public decimal TotalWeight { get; set; }

        public string Source { get; set; }
        public SBReceiptType Type { get; set; }

        public ReceiptMetadataCreateRequest ReceiptMetadata { get; set; }


        public List<ReceiptPaymentCreateRequest> Payments { get; set; } = new List<ReceiptPaymentCreateRequest>();

        public SBReceiptBarcode Barcode { get; set; }

        public string OriginalReceiptUrl { get; set; }

        public ReceiptReviewCreateRequest Review { get; set; }

        public ImageUploadRequest Signature { get; set; }

        public DateTimeOffset? BillingPeriodStartDate { get; set; }
        public DateTimeOffset? BillingPeriodEndDate { get; set; }
        public SBMoney TotalPayments { get; set; }

        public long? OrganizationId { get; set; }
    }
}
