using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptItemTaxes
{
    public record SBReceiptItemTax : ISmartbillsEntityWithId
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

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
