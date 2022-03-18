using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Services
{
    public class CreateBankRequest : BaseRequest
    {
        [JsonPropertyName("institution_id")]
        public Guid InstitutionId { get; set; }

        [JsonPropertyName("consent_expiration")]
        public DateTimeOffset? ConsentExpiration { get; set; }
    }
}