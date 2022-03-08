using Smartbills.Client.Entities.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities.Receipts
{
    public class ReceiptListItemDTO
    {
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }
        [JsonPropertyName("total")]
        public decimal Total { get; set; }

    }
}
