using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public class CreateBankRequest : BaseRequest
    {
        [JsonPropertyName("institution_id")]
        public long InstitutionId { get; set; }

        [JsonPropertyName("consent_expiration")]
        public DateTimeOffset? ConsentExpiration { get; set; }
    }
}