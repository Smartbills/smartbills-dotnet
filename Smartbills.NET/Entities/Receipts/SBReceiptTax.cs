using Smartbills.NET.Entities.Taxes;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptTax : SBEntity
    {
        public decimal Total { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public decimal Rate { get; set; }
        public string Name { get; set; }
        public SBTax Tax { get; set; }
    }
}
