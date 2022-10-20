using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.BankInstitutions
{
    public record UpdateBankInstitutionRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("products")]
        public string Products { get; set; }
        [JsonPropertyName("countries")]
        public string Countries { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }
    }
}