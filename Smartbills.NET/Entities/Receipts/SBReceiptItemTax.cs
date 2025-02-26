using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptItemTax : ISmartbillsEntityWithId
    {

        public long Id { get; set; }


        public long? TaxId { get; set; }


        public string Name { get; set; }


        public decimal Amount { get; set; }


        public decimal? Percentage { get; set; }
    }
}
