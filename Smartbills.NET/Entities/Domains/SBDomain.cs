using Smartbills.NET.Abstractions;
using Smartbills.NET.Constants;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Domains
{
    public record SBDomain : ISmartbillsEntity
    {
        [JsonPropertyName(CommonProperties.Id)]
        public long Id { get; set; }
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        [JsonPropertyName(CommonProperties.CreatedAt)]
        public string CreatedAt { get; set; }
        [JsonPropertyName("validated_at")]
        public string ValidatedAt { get; set; }
        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }
    }
}
