using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Banks
{
    public record SBBank : SmartbillsEntityWithId
    {
        public SBBank() : base()
        {
        }

        [JsonPropertyName("institution")]
        public SBBankInstitution Institution { get; set; }

        [JsonPropertyName("consent_expiration")]
        public DateTimeOffset ConsentExpiration { get; set; }
        public SBBankState State { get; set; } = SBBankState.NOT_STARTED;

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("bank_accounts")]
        public List<SBBankAccount> BankAccounts { get; set; } = new();

    }
}
