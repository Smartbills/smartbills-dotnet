using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record ReceiptItemTaxCreateRequest : BaseRequest
    {

        
        public long? TaxId { get; set; }

        
        public string Name { get; set; }

        
        public decimal Amount { get; set; }

        
        public decimal? Percentage { get; set; }
    }
}
