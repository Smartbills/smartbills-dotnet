using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Taxes
{
    public record SBReceiptTax : SmartbillsEntityWithId
    {
        
        public string Name { get; set; }

        
        public decimal Rate { get; set; }

        
        public string TaxIdentificiationNumber { get; set; }
    }
}
