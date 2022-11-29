using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record CreateReceiptItemTaxRequest : BaseRequest
    {

        [JsonPropertyName("tax_id")]
        public long? TaxId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }
    }
}
