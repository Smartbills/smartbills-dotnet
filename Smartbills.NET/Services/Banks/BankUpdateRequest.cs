using Smartbills.NET.Abstractions;
using Smartbills.NET.Services.BankAccounts;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Banks
{
    public record BankUpdateRequest : BaseRequest, IPlaidEntity
    {
        
        public long InstitutionId { get; set; }

        
        public DateTimeOffset? ConsentExpiration { get; set; }

        
        public List<BankAccountUpdateRequest> BankAccounts = new();

        
        public string PlaidId { get; set; }
    }
}