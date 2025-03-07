using Smartbills.NET.Entities.Money;
using Smartbills.NET.Services.Receipts;
using System.Collections.Generic;


namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemCreateRequest
    {
        public ReceiptLineItemCreateRequest()
        {

        }

        public ReceiptLineItemCreateRequest(string currency = "CAD")
        {
            Price = new SBMoney(0, currency);
            SubTotal = new SBMoney(0, currency);
            TotalDiscounts = new SBMoney(0, currency);
            TotalDuties = new SBMoney(0, currency);
            Total = new SBMoney(0, currency);
            TotalTaxes = new SBMoney(0, currency);
        }


        public long? ProductId { get; set; }
        public SBMoney Price { get; set; } = new SBMoney(0, "CAD");
        public string Description { get; set; }

        public string VariantId { get; set; }

        public decimal Quantity { get; set; } = 1m;
        public SBMoney SubTotal { get; set; } = new SBMoney(0, "CAD");

        public SBMoney TotalDiscounts { get; set; } = new SBMoney(0, "CAD");

        public SBMoney TotalDuties { get; set; } = new SBMoney(0, "CAD");

        public SBMoney Total { get; set; } = new SBMoney(0, "CAD");

        public SBMoney TotalTaxes { get; set; } = new SBMoney(0, "CAD");

        public List<ReceiptLineItemTaxCreateRequest> Taxes { get; set; } = new List<ReceiptLineItemTaxCreateRequest>();
        public List<ReceiptLineItemDiscountCreateRequest> Discounts { get; set; } = new List<ReceiptLineItemDiscountCreateRequest>();
        public List<ReceiptLineItemModifierCreateRequest> Modifiers { get; set; } = new List<ReceiptLineItemModifierCreateRequest>();

        public bool Taxable { get; set; } = true;
    }
}
