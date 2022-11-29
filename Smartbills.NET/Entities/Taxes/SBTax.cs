using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Taxes
{
    public record SBTax : SmartbillsEntityWithId
    {
        [JsonPropertyName("tax_identification_number")]
        public string TaxIdentificationNumber { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        [JsonPropertyName("merchant_id")]
        public long MerchantId { get; set; }

    }
}
