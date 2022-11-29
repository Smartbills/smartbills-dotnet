using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record UpdateTaxRequest : BaseRequest
    {
        [JsonPropertyName("tax_identification_number")]
        public string TaxIdentificationNumber { get; set; }
        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
