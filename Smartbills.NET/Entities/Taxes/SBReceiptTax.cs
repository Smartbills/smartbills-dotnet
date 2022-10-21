using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Taxes
{
    public record SBReceiptTax
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        [JsonPropertyName("total")]
        public decimal Total { get; set; }

        [JsonPropertyName("tin")]
        public string TIN { get; set; }
    }
}
