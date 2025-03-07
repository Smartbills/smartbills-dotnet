using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Receipts.Taxes
{
    public record ReceiptTaxCreateRequest
    {
        public string Name { get; set; }

        public decimal Percentage { get; set; }

        public SBMoney Total { get; set; }

        public string TaxIdentificationNumber { get; set; }
    }
}
