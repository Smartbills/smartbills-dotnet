using Smartbills.NET.Services.Addresses;
using Smartbills.NET.Services.Customers;
using Smartbills.NET.Services.ReceiptDiscounts;
using Smartbills.NET.Services.ReceiptFees;
using Smartbills.NET.Services.ReceiptItems;
using Smartbills.NET.Services.ReceiptMetadata;
using Smartbills.NET.Services.ReceiptTaxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptUpdateRequest : BaseRequest
    {
        
        public long? MerchantId { get; set; }

        
        public CustomerUpdateRequest Customer { get; set; }

        
        public long? CustomerId { get; set; }
        public long? EmployeeId { get; set; }


        public BillingAddressUpdateRequest BillingAddress { get; set; }
        
        public BillingAddressUpdateRequest ShippingAddress { get; set; }
        
        public List<ReceiptItemUpdateRequest> Items { get; set; } = new List<ReceiptItemUpdateRequest>();

        
        public string Currency { get; set; }

        
        public DateTimeOffset CreatedAt { get; set; }

        
        public DateTimeOffset? CancelledAt { get; set; }

        
        public string CancelReason { get; set; }
        
        public string PaymentStatus { get; set; }
        
        public List<ReceiptDiscountRequest> Discounts { get; set; } = new List<ReceiptDiscountRequest>();

        
        //public List<ReceiptFeeUpdateRequest> Fees { get; set; } = new List<ReceiptFeeUpdateRequest>();



        
        public decimal TotalDiscounts { get; set; }

        

        public List<ReceiptTaxUpdateRequest> Taxes { get; set; } = new List<ReceiptTaxUpdateRequest>() { };

        

        public bool TaxesIncluded { get; set; }
        

        public decimal TotalTip { get; set; }
        

        public decimal TotalDuties { get; set; }
        

        public decimal TotalShipping { get; set; }
        

        public decimal TotalWeight { get; set; }
        





        public decimal TotalTaxes { get; set; }

        
        public decimal TotalFees { get; set; }

        

        public decimal Total { get; set; }

        

        public decimal SubTotal { get; set; }

        

        public ReceiptMetadataUpdateRequest ReceiptMetadata { get; set; }
        

        public long? LocationId { get; set; }

        //

        //public List<ReceiptTransactionUpdateRequest> Transactions { get; set; }

        //
        //public BarcodeUpdateRequest Barcode{ get; set; }

    }
}
