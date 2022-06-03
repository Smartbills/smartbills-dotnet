using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public class ReceiptListItemDTO
    {
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }
        [JsonPropertyName("total")]
        public decimal Total { get; set; }

    }
}
