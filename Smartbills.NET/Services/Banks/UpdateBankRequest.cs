using Smartbills.NET.Abstractions;
using Smartbills.NET.Services.BankAccounts;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Banks
{
    public record UpdateBankRequest : BaseRequest, IPlaidEntity
    {
        [JsonPropertyName("institution_id")]
        public long InstitutionId { get; set; }

        [JsonPropertyName("consent_expiration")]
        public DateTimeOffset? ConsentExpiration { get; set; }

        [JsonPropertyName("bank_accounts")]
        public List<UpdateBankAccountRequest> BankAccounts = new();

        [JsonPropertyName("plaid_id")]
        public string PlaidId { get; set; }
    }
}