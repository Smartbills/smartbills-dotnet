using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public class CreateReceiptTaxRequest
    {
        [JsonPropertyName("tax_id")]
        public long? TaxId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        [JsonPropertyName("total")]
        public decimal Total { get; set; }

    }
}
