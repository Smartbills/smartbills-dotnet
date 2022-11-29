using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Taxes
{
    public record SBReceiptTax : SmartbillsEntityWithId
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        [JsonPropertyName("tax_identification_number")]
        public string TaxIdentificiationNumber { get; set; }
    }
}
