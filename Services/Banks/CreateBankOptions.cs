using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Smartbills.Client.Entities;

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